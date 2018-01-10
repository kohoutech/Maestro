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
using System.Xml;

using Transonic.Score.Symbols;

namespace Transonic.Score
{
    public class Measure
    {
        //dimensions based upon typograhy in Beethoven's Complete Piano Sonatas, Dover ed.
        public static int minWidth = 48;
        public const int quantization = 8;         //quantize rests to 1/32 note pos (quarter note / 8)

        public Part part;
        public Measure prevMeasure;
        public Measure nextMeasure;

        List<Symbol> symbols;               //symbols that aren't on beats
        List<Beat> beats;

        public int number;                  //measure number 
        public int startTick;               //measure start time in ticks
        public int length;                  //number of beats in measure, determined by most recent key signature

        public TimeSignature timeSig;
        public KeySignature keySig;
        public int timeNumer;
        public int timeDenom;
        public int key;

        public int staffpos;                //ofs in staff, in pixels
        public int width;                   //width of measure in pixels

        public Measure(Part _part, int num)
        {
            part = _part;
            symbols = new List<Symbol>();
            beats = new List<Beat>();
            number = num;
        }

        public Measure(Staff _staff, int num, int _startTick, int numer, int denom, int _key)
        {
            prevMeasure = null;
            nextMeasure = null;

            symbols = new List<Symbol>();
            beats = new List<Beat>();

            number = num;
            startTick = _startTick;
            timeSig = null;
            keySig = null;

            timeNumer = numer;
            timeDenom = denom;
            key = _key;
            length = numer * quantization / (denom / 4);

            staffpos = 0;
            width = 50;
        }

        public void setTimeSignature(TimeSignature _timeSig) {
            timeSig = _timeSig;
        }

        public void setKeySignature(KeySignature _keySig)
        {
            keySig = _keySig;
        }

        public void addSymbol(Symbol sym)
        {
            symbols.Add(sym);
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

        //public void groupSymbols()
        //{
        //    int beat = 0;
        //    BeatGroup group = new BeatGroup(this, beat);
        //    beats.Add(group);
        //    foreach (Symbol sym in symbols)
        //    {
        //        if (sym.beat > beat)
        //        {
        //            beat = sym.beat;
        //            group = new BeatGroup(this, beat);
        //            beats.Add(group);
        //        }
        //        group.addSymbol(sym);
        //    }
        //}

        //public void layoutSymbols(Measure prev)
        //{
        //    insertRests();
        //    //BarLine barline = new BarLine();
        //    //barline.start = timeNumer;
        //    //barline.startTick = staff.division * timeNumer;
        //    //symbols.Add(barline);

        //    groupSymbols();
        //    int symPos = 0;
        //    foreach (BeatGroup beat in beats)
        //    {
        //        beat.setPos(symPos);
        //        symPos += beat.width;
        //    }

        //    //link to other measures
        //    prevMeasure = prev;
        //    if (prev != null)
        //    {
        //        prev.nextMeasure = this;
        //    }

        //    //set measure pos and width
        //    staffpos = (prev != null) ? prev.staffpos + prev.width : 0;
        //    width = symPos;
        //    if (width < minWidth) width = minWidth;
        //}

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

            ////measure num
            //g.DrawString(number.ToString(), SystemFonts.DefaultFont, Brushes.Black, left, top - 14);

            ////symbols
            //for (int i = 0; i < beats.Count; i++)
            //{
            //    beats[i].paint(g, left, top);
            //}

            ////barline
            //g.DrawLine(Pens.Black, left + width, top, left + width, top + Staff.grandHeight);
        }

//- reading/writing -----------------------------------------------------------

        public static void parseMeasureXML(XmlNode measureNode, Part part)
        {
            XmlAttributeCollection attrs = measureNode.Attributes;
            int number = Convert.ToInt32(attrs["number"].Value);        //required attr

            Measure measure = new Measure(part, number);
            part.measures.Add(measure);

            foreach (XmlNode dataNode in measureNode.ChildNodes)
            {
                Console.WriteLine("have data type = " + dataNode.Name);

                switch(dataNode.Name) 
                {
                    case "note":
                        Note note = Note.parseNoteXML(dataNode);
                        break;
                    case "backup": break;
                    case "forward": break;
                    case "direction": break;
                    case "attributes": break;
                    case "print": break;
                    case "barline": break;
                    default : break;
                }
            }
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
