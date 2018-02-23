﻿/* ----------------------------------------------------------------------------
Transonic Score Library
Copyright (C) 1997-2018  George E Greaney

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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Transonic.Score
{
    public class ScoreSheet : UserControl
    {
        IScoreWindow window;
        private HScrollBar horzScroll;
        ScoreDoc score;

        public ScoreSheet(IScoreWindow _window)
        {
            window = _window;
            score = null;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.horzScroll = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // horzScroll
            // 
            this.horzScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horzScroll.Location = new System.Drawing.Point(0, 195);
            this.horzScroll.Name = "horzScroll";
            this.horzScroll.Size = new System.Drawing.Size(650, 17);
            this.horzScroll.TabIndex = 0;
            this.horzScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horzScroll_Scroll);
            // 
            // ScoreSheet
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.horzScroll);
            this.DoubleBuffered = true;
            this.Name = "ScoreSheet";
            this.Size = new System.Drawing.Size(650, 212);
            this.ResumeLayout(false);

        }

        public  void setScore(ScoreDoc _score)
        {
            score = _score;
            score.sheet = this;
            score.resize(this.Width, this.Height);
            horzScroll.Maximum = (int)score.curPart.staves[0].width;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (score != null)
            {
                score.resize(this.Width, this.Height);
            }
            Invalidate();
        }

        private void horzScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }


//- painting ------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (score != null)
            {
                score.paint(g);
            }            
        }
    }

//-----------------------------------------------------------------------------

    //for communication with the program's UI that is using the score sheet
    public interface IScoreWindow
    {
    }

}

//Console.WriteLine("there's no sun in the shadow of the wizard");
