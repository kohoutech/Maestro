﻿/* ----------------------------------------------------------------------------
Transonic Score Library
Copyright (C) 1997-2017  George E Greaney

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
        public ScoreSheet sheet;
        public List<Measure> measures;
        public int number;
        public int division;
        public int leftMeasureNum;
        public int rightMeasureNum;

        //dimensions based upon typograhy in Beethoven's Complete Piano Sonatas, Dover ed.
        public static int staffMargin = 50;
        public static int lineSpacing = 8;
        public static int staffHeight = lineSpacing * 4;
        public static int staffSpacing = lineSpacing * 6;                           //space between staves is 1.5 staff height
        public static int grandHeight = staffHeight + staffSpacing + staffHeight;   //two staves + the space between them

        public Staff(ScoreSheet _sheet, int num, int div)
        {
            sheet = _sheet;
            number = num;
            division = div;
            measures = new List<Measure>();
            leftMeasureNum = 0;
            rightMeasureNum = 0;
        }

        public void addMeasure (Measure measure) 
        {
            measures.Add(measure);
        }

        public int getBeatPos(int tick)
        {
            int measure = getBeatMeasure(tick);
            int result = measures[measure].getBeatPos(tick);
            return result;
        }

        public int getBeatMeasure(int tick)
        {
            int i = 0;
            while ((i < measures.Count - 1) && (measures[i + 1].startTime < tick))
                i++;
            return i;
        }

        public void setCurrentMeasure(int tick)
        {
            int i = 0;
            while ((i < measures.Count - 1) && (measures[i+1].startTime < tick)) 
                i++;
            leftMeasureNum = i;            
        }

        public void dump()
        {
            Console.WriteLine("Staff " + number);
            foreach (Measure measure in measures)
            {
                measure.dump();
            }
            Console.WriteLine();
        }

        public void drawStaff(Graphics g, int ypos)
        {
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(Pens.Black, 0, ypos, sheet.Width, ypos);
                ypos += lineSpacing;
            }
        }

        public void paint(Graphics g)
        {
            int ypos = staffMargin;
            drawStaff(g,ypos);
            ypos += (staffSpacing + staffHeight);
            drawStaff(g, ypos);

            int i = leftMeasureNum;
            int xpos = measures[i].staffpos;
            while ((i < measures.Count) && (measures[i].staffpos - xpos < sheet.Width))
            {
                Measure measure = measures[i++];
                measure.paint(g, xpos, staffMargin);
            }
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
