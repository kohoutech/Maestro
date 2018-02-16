/* ----------------------------------------------------------------------------
Transonic Score Library
Copyright (C) 1997-2018 George E Greaney

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
    public class Beat
    {

        public Measure measure;
        public float beat;
        public List<Symbol> symbols;
        public float xpos;

        //public static int a = 6;
        //public static int b = 6;
        //public static int c = 14;
        //public int tick;
        //public int sympos;
        //public int width;
        //public bool hasSharp;

        public Beat(Measure _measure, int _beat)
        {
            measure = _measure;
            beat = _beat;
            symbols = new List<Symbol>();
            xpos = 0;

            //tick = (beat * measure.staff.division) / Measure.quantization;
            //width = a + c;
            //hasSharp = false;
        }

        public void addSymbol(Symbol sym)
        {
            symbols.Add(sym);
            //if (sym is Note)
            //{
            //    Note note = (Note)sym;
            //    hasSharp |= note.hasSharp;
            //}
        }

        public void setAttributes(Attributes attr)
        {
        }

        public void setPos(float _pos)
        {
            xpos = _pos;
            //sympos = hasSharp ? a + b : a;
            //foreach (Symbol sym in symbols)
            //{
            //    sym.xpos = sympos;
            //}
            //width = sympos + c;
            //sympos += xpos;
        }

        public void paint(Graphics g)
        {
            //int left = xorg + xpos;
            //g.DrawLine(Pens.Blue, xorg, top, xorg, top + Staff.grandHeight);
            //g.DrawLine(Pens.Green, xorg+a, top, xorg+a, top + Staff.grandHeight);
            foreach (Symbol sym in symbols)
            {
                sym.paint(g);
            }
        }
    }

//-----------------------------------------------------------------------------

    public class Backup : Symbol 
    {
        public double duration;
    }

    public class Forward : Symbol 
    {
        public double duration;
    }
}
