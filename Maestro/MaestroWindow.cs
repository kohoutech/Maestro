/* ----------------------------------------------------------------------------
Maestro : a music notation editor
Copyright (C) 1996-2017  George E Greaney

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
using Maestro.UI;

namespace Maestro
{
    public partial class MaestroWindow : Form, IMidiView, iKeyboardWindow
    {
        MidiSystem midiSystem;
        Transport transport;
        Sequence currentSeq;
        public int displayTrackNum;

        ControlPanel controlPanel;
        KeyboardBar keyboard;        

        public MaestroWindow()
        {
            midiSystem = new MidiSystem();
            transport = new Transport(this);
            transport.init();
            currentSeq = new Sequence(Sequence.DEFAULTDIVISION);

            InitializeComponent();

            //control panel
            controlPanel = new ControlPanel(this);
            controlPanel.Location = new Point(0, maestroMenu.Height);
            controlPanel.Width = this.ClientSize.Width;
            this.Controls.Add(controlPanel);

            //keyboard bar
            keyboard = new KeyboardBar(this, KeyboardBar.Range.EIGHTYEIGHT, KeyboardBar.KeySize.SMALL);
            keyboard.Location = new Point(0, controlPanel.Bottom);
            keyboard.Width = this.ClientSize.Width;
            keyboard.selectedColor = Color.Yellow;
            this.Controls.Add(keyboard);

            displayTrackNum = 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            transport.shutdown();
        }

//- actions -------------------------------------------------------------------

        public void openSequence(String filename) 
        {
            currentSeq = MidiFile.readMidiFile(filename);
            this.Text = "Maestro [" + filename + "]";
            currentSeq.setMidiSystem(midiSystem);
            transport.setSequence(currentSeq);
            controlPanel.setSequence(currentSeq);
            playTransportMenuItem.Enabled = true;
            stopTransportMenuItem.Enabled = true;
            //currentSeq.dump();
        }

        public void playSequence()
        {
            transport.playSequence();
            masterTimer.Start();
            controlPanel.setPlaying(true);
        }

        public void stopSequence()
        {
            transport.stopSequence();
            masterTimer.Stop();
            controlPanel.setPlaying(false);            
        }

        public void halfSpeedSequence(bool on)
        {
            transport.halfSpeedSequence(on);
        }

        public void setSequencePos(int tick)
        {
            keyboard.allKeysUp();
            transport.setSequencePos(tick);
            int mstime = transport.getMilliSecTime();
            controlPanel.timerTick(tick, mstime);
        }

        public void setDisplayTrack(int trackNum)
        {
            keyboard.allKeysUp();
            displayTrackNum = trackNum;
        }

//- file events ---------------------------------------------------------------

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            String filename;
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.DefaultExt = "*.mid";
            openFileDialog.Filter = "midi files|*.mid|All files|*.*";
            openFileDialog.ShowDialog();
            filename = openFileDialog.FileName;
            if (filename.Length > 0)
            {
                openSequence(filename);
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
            String msg = "Maestro\nversion 1.0.1\n" + "\xA9 Transonic Software 1996-2017\n" + "http://transonic.kohoutech.com";
            MessageBox.Show(msg, "About");
        }

//- view methods --------------------------------------------------------------

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            int tick = transport.tickNum;
            int mstime = transport.getMilliSecTime();
            controlPanel.timerTick(tick, mstime);
        }

        public void handleMessage(int track, Transonic.MIDI.Message message)
        {
            if (track == displayTrackNum)
            {
                if (message is NoteOnMessage)
                {
                    NoteOnMessage onMsg = (NoteOnMessage)message;
                    if (onMsg.velocity > 0)
                    {
                        keyboard.setKeyDown(onMsg.noteNumber);
                    }
                    else
                    {
                        keyboard.setKeyUp(onMsg.noteNumber);
                    }
                }
                if (message is Transonic.MIDI.NoteOffMessage)
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
        }

//- iKeyboardWindow methods ---------------------------------------------------

        //for the moment pressing keys on the keyboard widget doesn't do anything, maybe later...
        public void onKeyDown(int keyNumber)
        {
        }

        public void onKeyUp(int keyNumber)
        {
        }

    }
}

