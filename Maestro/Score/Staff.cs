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

        public float spacing;
        public float top;
        public float left;
        public float right;
        public float height;

        public Staff(Part _part)
        {
            part = _part;
            score = part.score;

            spacing = 10;
            top = 50;
            left = 0;
            right = 200;
            height = 50;
        }

//- display -------------------------------------------------------------------

        public void drawStaff(Graphics g, float ypos)
        {
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(Pens.Black, left, ypos, right, ypos);
                ypos += spacing;
            }
        }

        public void paint(Graphics g)
        {
            float ypos = top;
            drawStaff(g, ypos);                 //treble clef
            ypos = top + (4 * spacing) + height;
            drawStaff(g, ypos);                 //bass clef
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
