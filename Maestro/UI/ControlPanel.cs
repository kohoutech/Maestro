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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Transonic.MIDI;

namespace Maestro.UI
{
    public partial class ControlPanel : UserControl
    {
        public MaestroWindow maestroWindow;
        public Sequence curSequence;

        bool isPlaying;

        public ControlPanel(MaestroWindow _superWindow)
        {
            maestroWindow = _superWindow;
            InitializeComponent();
            isPlaying = false;
        }

        public void setSequence(Sequence seq) 
        {
            curSequence = seq;
            hsbSeqPos.Maximum = seq.duration;
            hsbSeqPos.LargeChange = seq.division;
            hsbSeqPos.SmallChange = seq.division / 8;

            //populate track selector drop down with track names
            List<String> trackNames = new List<string>();
            for (int i = 1; i < seq.tracks.Count; i++)
            {
                String trackName = seq.tracks[i].name;
                if (trackName == null)
                    trackName = "Track " + i.ToString();
                trackNames.Add(trackName);
            }
            cbxTracks.DataSource = trackNames;
            hsbSeqPos.Enabled = true;
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
        }

        public void timerTick(int tick, int msTime)
        {
            int msVal = msTime % 1000;
            int secPos = msTime / 1000;
            int secVal = secPos % 60;
            int minPos = secPos / 60;
            int minVal = minPos % 60;
            int hrVal = minPos / 60;
            lblPosCounter.Text = hrVal.ToString("D2") + ":" + minVal.ToString("D2") + ":" +
                secVal.ToString("D2") + "." + msVal.ToString("D3");

            hsbSeqPos.Value = tick;
            Invalidate();            
        }

        public void setPlaying(bool on) 
        {
            isPlaying = on;
        }

//- control events ------------------------------------------------------------

        private void chkHalfSpeed_CheckedChanged(object sender, EventArgs e)
        {
            maestroWindow.halfSpeedSequence(chkHalfSpeed.Checked);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                maestroWindow.playSequence();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            maestroWindow.stopSequence();
        }

        private void hsbSeqPos_Scroll(object sender, ScrollEventArgs e)
        {
            if (!isPlaying)
            {
                maestroWindow.setSequencePos(hsbSeqPos.Value);
            }
        }

        private void cbxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
                maestroWindow.setDisplayTrack(cbxTracks.SelectedIndex + 1);
        }
    }
}
