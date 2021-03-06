﻿/* ----------------------------------------------------------------------------
Maestro : a music notation editor
Copyright (C) 1996-2018  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Transonic.MIDI;
using Transonic.MIDI.Engine;
using Transonic.MIDI.System;
using Transonic.Widget;
using Transonic.Score;
using Transonic.Score.MusicXML;
using Transonic.Score.Midi;
using Maestro.UI;

namespace Maestro
{
    public partial class MaestroWindow : Form, IMidiView, IKeyboardWindow, IScoreWindow
    {
        //widgets
        ControlPanel controlPanel;
        ScoreSheet scoreSheet;
        KeyboardBar keyboard;

        ScoreDoc currentScore;

        //midi
        MidiSystem midiSystem;
        Transport transport;
        Sequence currentSeq;
        public int displayPartNum;


        public MaestroWindow()
        {
            currentScore = null;

            //midi
            midiSystem = new MidiSystem();
            transport = new Transport(this);
            transport.init();
            currentSeq = new Sequence();
            displayPartNum = 0;

            InitializeComponent();

            //control panel
            controlPanel = new ControlPanel(this);
            controlPanel.Location = new Point(0, maestroMenu.Bottom);
            controlPanel.Size = new Size(this.Width, controlPanel.Height);
            this.Controls.Add(controlPanel);

            //keyboard bar
            keyboard = new KeyboardBar(this, KeyboardBar.Range.EIGHTYEIGHT, KeyboardBar.KeySize.SMALL);
            keyboard.selectedColor = Color.Yellow;
            keyboard.BackColor = Color.Yellow;
            keyboard.Location = new Point(0, maestroStatus.Top - keyboard.Height);
            keyboard.Size = new Size(this.Width, keyboard.Height);            
            this.Controls.Add(keyboard);

            //score sheet
            scoreSheet = new ScoreSheet(this);
            scoreSheet.Location = new Point(0, controlPanel.Bottom);
            scoreSheet.Size = new Size(this.ClientSize.Width, keyboard.Top - controlPanel.Bottom);
            //scoreSheet.Dock = DockStyle.Fill;
            this.Controls.Add(scoreSheet);            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (controlPanel != null) 
            {            
                controlPanel.Size = new Size(this.Width, controlPanel.Height);
            }
            if (keyboard != null)
            {
                keyboard.Location = new Point(0, maestroStatus.Top - keyboard.Height);
                keyboard.Size = new Size(this.Width, keyboard.Height);
            }
            if (scoreSheet != null)
            {
                scoreSheet.Location = new Point(0, controlPanel.Bottom);
                scoreSheet.Size = new Size(this.ClientSize.Width, keyboard.Top - controlPanel.Bottom);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            transport.shutdown();
        }

//- actions -------------------------------------------------------------------

        public void openScore(String filename)
        {
            currentScore = MusicXMLReader.loadFromMusicXML(filename);
            scoreSheet.setScore(currentScore);
            this.Text = "Maestro [" + filename + "]";
            currentSeq = ScoreMidi.ConvertScoreToMidi(currentScore);
            transport.setSequence(currentSeq);
            controlPanel.setSequence(currentSeq);
            playTransportMenuItem.Enabled = true;
            stopTransportMenuItem.Enabled = true;
            setTrackOutput();
        }

        public void setTrackOutput()
        {
            for (int i = 0; i < currentSeq.tracks.Count; i++)
            {
                currentSeq.tracks[i].setOutputDevice(midiSystem.outputDevices[0]);
                currentSeq.tracks[i].setOutputChannel(i);
            }
        }

        public void playSequence()
        {
            transport.play();
            masterTimer.Start();
            controlPanel.setPlaying(true);
        }

        public void stopSequence()
        {
            transport.stop();
            masterTimer.Stop();
            controlPanel.setPlaying(false);            
        }

        public void halfSpeedSequence(bool on)
        {
            transport.setPlaybackSpeed(on);
        }

        public void setSequencePos(int tick)
        {
            keyboard.allKeysUp();
            transport.setCurrentPos(tick);
            int mstime = transport.getCurrentTime();
            controlPanel.timerTick(tick, mstime);
            setScorePos();
        }

        public void setScorePos()
        {
            int measure;
            decimal beat;
            transport.getCurrentBeat(out measure, out beat);
            scoreSheet.setCurrentBeat(measure, beat);
        }

        public void setDisplayPart(int partNum)
        {
            keyboard.allKeysUp();
            displayPartNum = partNum;
            scoreSheet.setCurrentPart(partNum);
        }

//- file events ---------------------------------------------------------------

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            String filename;
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.DefaultExt = "*.mxl";
            //openFileDialog.Filter = "musicxml files|*.mxl|midi files|*.mid|All files|*.*";
            openFileDialog.Filter = "musicxml files|*.mxl|All files|*.*";
            openFileDialog.ShowDialog();
            filename = openFileDialog.FileName;
            //filename = "MyEtude.mxl";
            if (filename.Length > 0)
            {
                openScore(filename);
            }
        }

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//- transport events ----------------------------------------------------------

        private void playTransportMenuItem_Click(object sender, EventArgs e)
        {
            playSequence();
        }

        private void stopTransportMenuItem_Click(object sender, EventArgs e)
        {
            stopSequence();
        }

//- help events ---------------------------------------------------------------

        private void aboutHelpMenuItem_Click(object sender, EventArgs e)
        {
            String msg = "Maestro\nversion 1.2.0\n" + "\xA9 Transonic Software 1996-2018\n" + "http://transonic.kohoutech.com";
            MessageBox.Show(msg, "About");
        }

//- view methods --------------------------------------------------------------

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            int tick = transport.getCurrentPos();
            int mstime = transport.getCurrentTime();
            controlPanel.timerTick(tick, mstime);
            setScorePos();            
        }

        public void handleMessage(int track, Transonic.MIDI.Message message)
        {
            if (track == displayPartNum)
            {
                if (message is NoteOnMessage)
                {
                    NoteOnMessage onMsg = (NoteOnMessage)message;
                    keyboard.setKeyDown(onMsg.noteNumber);
                }
                if (message is NoteOffMessage)
                {
                    NoteOffMessage offMsg = (NoteOffMessage)message;
                    keyboard.setKeyUp(offMsg.noteNumber);
                }
            }
        }

        public void sequenceDone()
        {
            masterTimer.Stop();
            controlPanel.setPlaying(false);
            keyboard.allKeysUp();            
        }

//- iKeyboardWindow methods ---------------------------------------------------

        //for the moment pressing keys on the keyboard widget doesn't do anything, maybe later...
        public void onKeyPress(int keyNumber)
        {
        }

        public void onKeyRelease(int keyNumber)
        {
        }

    }
}

