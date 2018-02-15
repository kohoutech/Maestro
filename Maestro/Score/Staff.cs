/* ----------------------------------------------------------------------------
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
using System.Drawing;
using System.Drawing.Drawing2D;

using Transonic.Score.Symbols;

namespace Transonic.Score
{
    public class Staff
    {
        public ScoreDoc score;
        public Part part;

        public Staff(Part _part)
        {
            part = _part;
            score = part.score;
        }

//- display -------------------------------------------------------------------

        public void drawStaff(Graphics g, ref float ypos)
        {
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(Pens.Black, 0.0f, ypos, score.docWidth, ypos);
                ypos += score.staffSpacing;
            }
        }

        public void paint(Graphics g)
        {
            float ypos = score.staffMargin;
            drawStaff(g, ref ypos);
            ypos += score.staffHeight;
            drawStaff(g, ref ypos);

            //int i = leftMeasureNum;
            //int xpos = 0;
            //while ((i < measures.Count) && (xpos < sheet.Width))
            //{
            //    Measure measure = measures[i++];
            //    measure.paint(g, xpos, staffMargin);
            //    xpos += measure.width;
            //}
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
