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
using System.Drawing;
using System.Drawing.Drawing2D;

using Transonic.Score;

namespace Transonic.Score.Symbols
{
    public class Note : Symbol
    {
        public enum NOTETYPE
        {
            Note1024 = 0,
            Note512,
            Note256,
            Note128,
            SixtyFourth,
            ThirtySecond,
            Sixteenth,
            Eighth,
            Quarter,
            Half,
            Whole,
            DoubleWhole,
            QuadWhole,
            OctoWhole
        }

        public enum NOTESIZE
        {
            Full = 0,
            Cue,
            Gracecue,
            Large
        }


        public const int quantization = 8;         //quantize notes to 1/32 note pos (quarter note / 8)

        public const String flat = "\u266d";
        public const String natural = "\u266e";
        public const String sharp = "\u266f";

        //public const String quarter = "\u2669";

        public int notenum;
        public int octave;
        public int step;
        public int alter;
        public bool hasAccidental;
        public int accidental;
        public decimal semitones;
        public bool chord;
        public bool cue;
        public bool rest;
        public decimal duration;
        public NOTETYPE notetype;
        public NOTESIZE notesize;
        public bool dot;
        public int staffnum;

        public Stem stem;
        public Beam beam;

        public int ledgerLinesAbove;
        public bool ledgerLinesMiddle;
        public int ledgerLinesBelow;        

        public Note() : base()
        {
            chord = false;
            cue = false;
            rest = false;
            notenum = 0;
            octave = 0;
            step = 0;
            alter = 0;
            hasAccidental = false;
            accidental = 0;
            semitones = 0;
            duration = 0;
            notetype = NOTETYPE.Quarter;
            notesize = NOTESIZE.Full;
            dot = false;
            staffnum = 1;
        }

        string[] noteletters = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public override void dump()        
        {
            if (!rest)
            {
                String pitchstr = noteletters[(notenum % 12)] + ((notenum / 12) - 1).ToString();
                Console.WriteLine("note pitch = " + pitchstr + " duration = " + duration);
            }
            else
            {
                Console.WriteLine("rest : duration = " + duration);
            }
        }

        //public Note(int _start, int _noteNum, int _dur)
        //{
        //    startTick = _start;
        //    noteNumber = _noteNum;
        //    duration = _dur;

        //    octave = noteNumber / 12;
        //    step = noteNumber % 12;
        //    ledgerLinesAbove = 0;
        //    ledgerLinesMiddle = false;
        //    ledgerLinesBelow = 0;
        //}

        //int[] scaleTones = { 0, 0, 1, 1, 2, 3, 3, 4, 4, 5, 5, 6 };
        //int[] keyOfC = { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 };

        int[,] circleOfFifths = {{-1, -1, -1, 0, -1, -1, -1},         //Gb
                                 {0, -1, -1, 0, -1, -1, -1},         //Db
                                 {0, -1, -1, 0, 0, -1, -1},         //Ab
                                 {0, 0, -1, 0, 0, -1, -1},         //Eb
                                 {0, 0, -1, 0, 0, 0, -1},         //Bb
                                 {0, 0, 0, 0, 0, 0, -1},         //F
                                 {0, 0, 0, 0, 0, 0, 0},         //C
                                 {0, 0, 0, 1, 0, 0, 0},         //G
                                 {1, 0, 0, 1, 0, 0, 0},         //D
                                 {1, 0, 0, 1, 1, 0, 0},         //A
                                 {1, 1, 0, 1, 1, 0, 0},         //E
                                 {1, 1, 0, 1, 1, 1, 0},         //B
                                 {1, 1, 1, 1, 1, 1, 0}          //F#                                
                                };

        //set verical note pos relative to top of staff
        //notes from middle C and higher belong to the treble clef, notes below middle C belong to bass clef
        public override void layout()
        {
            left = 0;
            float halfStep = staff.spacing / 2;

            //treble clef
            if (notenum >= 60)
            {
                float cpos = staff.spacing * 5;                             //pos of middle C = 60
                top = (cpos) - ((octave - 5) * halfStep * 7) - (step * halfStep);
            }

            //bass clef
            else
            {
                float bottom = staff.spacing * 8 + staff.separation;
                float cpos = bottom + (staff.spacing * 12 + halfStep);    //pos of MIDI C = 0
                top = cpos - (octave * halfStep * 7) - (step * halfStep);
            }

            int scalealter = circleOfFifths[(beat.measure.attr.key + 6),step];
            if (scalealter != alter)
            {
                hasAccidental = true;
                accidental = alter;
            }
        }

//- display -------------------------------------------------------------------

        public override void paint(Graphics g)
        {
            //xorg += xpos;
            //if (ledgerLinesAbove < 0)
            //{
            //    int linepos = top - Staff.lineSpacing;
            //    for (int i = 0; i > ledgerLinesAbove; i--)
            //    {
            //        g.DrawLine(Pens.Red, xorg - 2, linepos, xorg + 10, linepos);
            //        linepos -= Staff.lineSpacing;
            //    }
            //}

            //if (ledgerLinesMiddle)
            //{
            //    g.DrawLine(Pens.Red, xorg - 2, top + (Staff.lineSpacing * 5), xorg + 10, top + (Staff.lineSpacing * 5));
            //}

            //if (ledgerLinesBelow > 0)
            //{
            //    int linepos = top + Staff.grandHeight + Staff.lineSpacing;
            //    for (int i = 0; i < ledgerLinesBelow; i++)
            //    {
            //        g.DrawLine(Pens.Red, xorg - 2, linepos, xorg + 10, linepos);
            //        linepos += Staff.lineSpacing;
            //    }
            //}

            //top += ypos;

            if (hasAccidental)
            {
                Font symfont = new Font("Arial", 14);
                switch (accidental)
                {
                    case 0:
                        g.DrawString(natural, symfont, Brushes.Red, xpos - 14, ypos - 12);
                        break;
                    case 1:
                        g.DrawString(sharp, symfont, Brushes.Red, xpos - 14, ypos - 12);
                        break;
                    case -1:
                        g.DrawString(flat, symfont, Brushes.Red, xpos - 14, ypos - 12);
                        break;
                    default:
                        break;
                }
                symfont.Dispose();
            }

            if (notetype.CompareTo(NOTETYPE.Half) < 0)
            {
                g.FillEllipse(Brushes.Red, xpos - 4, ypos - 4, 8, 8);
            }
            else
            {
                g.DrawEllipse(Pens.Red, xpos - 4, ypos - 4, 8, 8);
                g.DrawEllipse(Pens.Red, xpos - 3, ypos - 3, 6, 6);
            }
            //g.DrawLine(Pens.Red, xorg + 8, top, xorg + 8, top - Staff.lineSpacing * 3);

        }

     }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
