﻿/* ----------------------------------------------------------------------------
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
    public class Measure
    {
        //dimensions based upon typograhy in Beethoven's Complete Piano Sonatas, Dover ed.
        public static int minWidth = 48;
        public const int quantization = 8;         //quantize rests to 1/32 note pos (quarter note / 8)

        public Part part;
        public Staff staff;
        public Measure prevMeasure;
        public Measure nextMeasure;

        List<Beat> beats;        

        public int number;                  //measure number 
        public decimal length;              //number of beats in measure, determined by most recent key signature


        public float staffpos;                //ofs in staff in measure, in pixels
        public float width;                   //width of measure, sum of all beat widths, in pixels
        public float xpos;

        public Measure(Part _part, int _number, Measure prev)
        {
            part = _part;
            staff = null;
            number = _number;
            prevMeasure = prev;
            if (prevMeasure != null)
            {
                prevMeasure.nextMeasure = this;
            }
            nextMeasure = null;

            beats = new List<Beat>();
            length = 0;

            staffpos = 0;
            width = 0;
        }

        //public void setTimeSignature(TimeSignature _timeSig) {
        //    timeSig = _timeSig;
        //}

        //public void setKeySignature(KeySignature _keySig)
        //{
        //    keySig = _keySig;
        //}

        public void setPrint(Print print)
        {
        }

        public void setBarLine(Barline barline)
        {
        }

        public void dump()
        {
            Console.WriteLine("measure number " + number);
            for (int i = 0; i < beats.Count; i++)
            {
                beats[i].dump();
            }
        }


//- beats -------------------------------------------------------------------

        public Beat getBeat(decimal beatPos)
        {
            Beat result = null;
            foreach (Beat beat in beats)
            {
                if (Math.Abs(beat.beatpos - beatPos) < Beat.BEATQUANT)
                {
                    result = beat;
                    break;
                }
            }
            if (result == null)
            {
                result = new Beat(this, beatPos);
                beats.Add(result);
                beats.Sort((a, b) => a.beatpos.CompareTo(b.beatpos));
                length = beats[beats.Count - 1].beatpos;
            }
            return result;
        }

//- layout -------------------------------------------------------------------

        ////insert a rest at any point in the measure there isn't a note playing
        //public void insertRests()
        //{
        //    if (symbols.Count == 0)     //no notes at all, insert measure long rest
        //    {
        //        Rest rest = new Rest(0, timeNumer * quantization);
        //        symbols.Add(rest);
        //        rest.setMeasure(this);
        //    }
        //    else
        //    {
        //        List<Symbol> syms = new List<Symbol>();
        //        int beat = 0;
        //        for (int i = 0; i < symbols.Count; i++)
        //        {
        //            Note note = (Note)symbols[i];
        //            if (note.beat > beat)
        //            {
        //                int restLen = note.beat - beat;
        //                Rest rest = new Rest(beat, restLen);
        //                syms.Add(rest);
        //                rest.setMeasure(this);
        //            }
        //            if (beat < (note.beat + note.len))
        //            {
        //                beat = (note.beat + note.len);
        //            }
        //            syms.Add(note);
        //        }
        //        symbols = syms;
        //        if (beat < (timeNumer * quantization))                  //any remaining time in measure
        //        {
        //            int restLen = (timeNumer * quantization) - beat;
        //            Rest rest = new Rest(beat, restLen);
        //            symbols.Add(rest);
        //            rest.setMeasure(this);
        //        }
        //    }
        //}

        //layout beats inside measure - determine measure's width
        public void layoutBeats()
        {
        //    insertRests();
        //    //BarLine barline = new BarLine();
        //    //barline.start = timeNumer;
        //    //barline.startTick = staff.division * timeNumer;
        //    //symbols.Add(barline);

            float beatPos = 20;             //hardwired offset of first beat in measure, will change
            foreach (Beat beat in beats)
            {
                beat.measpos = beatPos;
                beat.layoutSymbols();
                beatPos += beat.width;                
            }

            width = beatPos;
            if (width < minWidth) width = minWidth;
        }

        public void setPos(float _xpos)
        {
            xpos = staffpos + _xpos;
            foreach (Beat beat in beats)
            {
                beat.setPos(xpos);
            }
        }


        ////translate tick to pixels for this measure
        //public int getBeatPos(int tick)
        //{
        //    tick -= startTick;
        //    int i = 0;
        //    while ((i < beats.Count - 1) && (tick > beats[i+1].tick))
        //        i++;
        //    int pos = beats[i].sympos;
        //    return pos; 
        //}

//- display -------------------------------------------------------------------
 
        public void paint(Graphics g)
        {            

            //measure num
            g.DrawString(number.ToString(), SystemFonts.DefaultFont, Brushes.Black, xpos, staff.top - 14);

            //beats
            for (int i = 0; i < beats.Count; i++)
            {
                beats[i].paint(g);
            }

            //barline
            g.DrawLine(Pens.Black, xpos + width, staff.top, xpos + width, staff.bottom);
        }

    }

//- measure attributes --------------------------------------------------------

    public enum KEYMODE
    {
        Major, 
        Minor, 
        Dorian, 
        Phrygian, 
        Lydian, 
        Mixolydian, 
        Aeolian, 
        Ionian, 
        Locrian, 
        None
    }

    public class Attributes 
    {
        public decimal divisions;
        public int timeNumer;
        public int timeDenom;
        public int key;
        public KEYMODE mode;

        public TimeSignature timeSig;
        public KeySignature keySig;

        public Attributes()
        {
            timeNumer = 4;
            timeDenom = 4;
            key = 0;
            mode = KEYMODE.Major;

            timeSig = null;
            keySig = null;
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
