/* ----------------------------------------------------------------------------
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
using System.Xml;

using Transonic.Score;

namespace Transonic.Score.Symbols
{
    public class Note : Symbol
    {
        public const int quantization = 8;         //quantize notes to 1/32 note pos (quarter note / 8)

        public const String flat = "\u266d";
        public const String natural = "\u266e";
        public const String sharp = "\u266f";

        //public const String quarter = "\u2669";

        public int noteNumber;          //midi pitch
        public int ledgerLinesAbove;
        public bool ledgerLinesMiddle;
        public int ledgerLinesBelow;
        public bool hasSharp;

        public bool cue;
        public bool chord;
        public int step;
        public double alter;
        public int octave;
        public double duration;
        public string voice;
        public string notetype;
        public int dot;

        public Note()
        {
            cue = false;
            chord = false;
            step = 0;
            alter = 0.0;
            octave = 0;
            duration = 0.0;
            voice = "";
            notetype = "quarter";
            dot = 0;
        }

        public Note(int _start, int _noteNum, int _dur)
        {
            startTick = _start;
            noteNumber = _noteNum;
            duration = _dur;

            octave = noteNumber / 12;
            step = noteNumber % 12;
            ledgerLinesAbove = 0;
            ledgerLinesMiddle = false;
            ledgerLinesBelow = 0;
        }

        public override void setMeasure(Measure measure)
        {
            base.setMeasure(measure);

            //startTick -= measure.startTick;

            ////quantize start to nearest beat
            //double val = (double)startTick / measure.staff.division;
            //beat = (int)((val * quantization) + 0.5f);

            ////quatize duration to next beat
            //val = (double)duration / measure.staff.division;
            //len = (int) Math.Ceiling((val * quantization * 2));

            //setVertPos();
            //hasSharp = (keyOfC[step] == 1);
        }

        int[] scaleTones = { 0, 0, 1, 1, 2, 3, 3, 4, 4, 5, 5, 6 };
        int[] keyOfC = { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 };

        //set verical note pos relative to top of staff
        //notes from middle C and higher belong to the treble clef, notes below middle C belong to bass clef
        public void setVertPos()
        { 
            //int halfStep = Staff.lineSpacing / 2;

            ////treble clef
            //if (noteNumber >= 60)
            //{
            //    int cpos = Staff.lineSpacing * 5;        //pos of middle C
            //    ypos = cpos - (((octave - 5) * halfStep * 7) + (scaleTones[step] * halfStep));
            //    if (ypos < 0)
            //    {
            //        ledgerLinesAbove = ypos / Staff.lineSpacing;
            //    }
            //    ledgerLinesMiddle |= (noteNumber == 60 | noteNumber == 61);

            //}

            ////bass clef
            //else
            //{
            //    int cpos = Staff.grandHeight + Staff.lineSpacing * 12 + halfStep;    //pos of MIDI C = 0
            //    ypos = cpos - ((octave * halfStep * 7) + (scaleTones[step] * halfStep));
            //    if (ypos > Staff.grandHeight)
            //    {
            //        ledgerLinesBelow = (ypos - Staff.grandHeight) / Staff.lineSpacing;
            //    }
            //}
        }

//- display -------------------------------------------------------------------

        public override void paint(Graphics g, int xorg, int top)
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

            //if (hasSharp)
            //{
            //    Font sharpfont = new Font("Arial", 14);
            //    g.DrawString(sharp, sharpfont, Brushes.Red, xorg - 12, top - 12);

            //}

            //g.FillEllipse(Brushes.Red, xorg, top - 4, 8, 8);
            //g.DrawLine(Pens.Red, xorg + 8, top, xorg + 8, top - Staff.lineSpacing * 3);

        }

//- reading/writing -----------------------------------------------------------

        public static Note parseNoteXML(System.Xml.XmlNode noteNode)
        {
            Note note = new Note();

            XmlNodeList childnodes = noteNode.ChildNodes;
            int count = childnodes.Count;
            int num = 0;

            //choice
            if (childnodes[num].Name.Equals("grace"))
            {
                parseGraceXML(num++, childnodes, note);
                if (childnodes[num].Name.Equals("cue"))
                {
                    note.cue = true;
                    num++;
                    num = parseFullNoteXML(num, childnodes, note);
                    
                }
                else
                {
                    num = parseFullNoteXML(num, childnodes, note);
                    for (int i = 0; i < 2; i++)
                    {
                        if (childnodes[num].Name.Equals("tie"))
                        {
                            parseTieXML(num++, childnodes, note);
                        }
                    }
                }
            }
            else if (childnodes[num].Name.Equals("cue")) 
            {
                note.cue = true;
                num++;
                num = parseFullNoteXML(num, childnodes, note);
                num = parseDurationXML(num, childnodes, note);
            }
            else { 
                num = parseFullNoteXML(num, childnodes, note);
                num = parseDurationXML(num, childnodes, note);
                for (int i = 0; i < 2; i++)
                {
                    if (childnodes[num].Name.Equals("tie"))
                    {
                        parseTieXML(num++, childnodes, note);
                    }
                }
            }

            if (childnodes[num].Name.Equals("instrument")) 
            {
                parseInstrumentXML(num++, childnodes, note);
            }
            num = parseEditorialVoice(num++, childnodes, note);             //required
            if ((num < count) && childnodes[num].Name.Equals("type"))
            {
                parseNoteTypeXML(num++, childnodes, note);
            };
            while ((num < count) && childnodes[num].Name.Equals("dot")) 
            {
                parseDotXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("accidental")) 
            {
                parseAccidentalXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("time-modification")) 
            {
                parseTimeModificationXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("stem")) 
            {
                parseStemXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("notehead")) 
            {
                parseNoteheadXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("notehead-text")) 
            {
                parseNoteheadTextXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("staff")) 
            {
                num = parseStaffXML(num, childnodes, note);
            };
            for (int i = 0; i < 8; i++)
            {
                if ((num < count) && childnodes[num].Name.Equals("beam"))
                {
                    parseBeamXML(num++, childnodes, note);
                };
            }
            while ((num < count) && childnodes[num].Name.Equals("notations")) 
            {
                parseNotationsXML(num++, childnodes, note);
            };
            while ((num < count) && childnodes[num].Name.Equals("lyric")) 
            {
                parseLyricXML(num++, childnodes, note);
            };
            if ((num < count) && childnodes[num].Name.Equals("play"))
            {
                parsePlayXML(num++, childnodes, note);
            };
            return note;
        }

        public static void parseGraceXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }
        
        public static int parseFullNoteXML(int num, XmlNodeList childnodes, Note note)
        {
            int count = childnodes.Count;
            if ((num < count) && childnodes[num].Name.Equals("chord"))
            {
                note.chord = true;
                num++;
            };
            if (childnodes[num].Name.Equals("pitch"))
            {
                parsePitchXML(childnodes[num++], note);
            }
            else if (childnodes[num].Name.Equals("unpitched"))
            {
                parseUnpitchedXML(childnodes[num++], note);
            }
            else
            {
                parseRestXML(childnodes[num++], note);
            }
            return num;
        }

        private static void parsePitchXML(XmlNode pitchNode, Note note)
        {
            int num = 0;
            XmlNodeList childnodes = pitchNode.ChildNodes;
            string stepstr = childnodes[num++].InnerText.ToUpper();
            note.step = stepstr[0] - 'A';
            if (childnodes[num].Name.Equals("alter"))
            {
                note.alter = Convert.ToDouble(childnodes[num++].InnerText);
            }
            note.octave = Convert.ToInt32(childnodes[num].InnerText);
        }

        private static void parseUnpitchedXML(XmlNode unpitchedNode, Note note)
        {
            throw new NotImplementedException();
        }

        private static void parseRestXML(XmlNode restNode, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseTieXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static int parseDurationXML(int num, XmlNodeList childnodes, Note note)
        {
            note.duration = Convert.ToDouble(childnodes[0].Value);
            return 1;
        }

        public static void parseInstrumentXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static int parseEditorialVoice(int p, XmlNodeList childnodes, Note note)
        {
            int num = p;
            if (childnodes[num].Name.Equals("footnote"))
            {
                num = parseFootnoteXML(num, childnodes, note);
            }
            if (childnodes[num].Name.Equals("level"))
            {
                num = parseLevelXML(num, childnodes, note);
            }
            if (childnodes[num].Name.Equals("voice"))
            {
                num = parseVoiceXML(num, childnodes, note);
            }
            return num;
        }

        private static int parseVoiceXML(int num, XmlNodeList childnodes, Note note)
        {
            note.voice = childnodes[0].Value;
            return 1;            
        }

        private static int parseLevelXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        private static int parseFootnoteXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseNoteTypeXML(int p, XmlNodeList childnodes, Note note)
        {
            note.notetype = childnodes[p].Value;
        }

        public static void parseDotXML(int p, XmlNodeList childnodes, Note note)
        {
            note.dot++;
        }

        public static void parseAccidentalXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseTimeModificationXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }
        
        public static void parseStemXML(int p, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
        }

        public static void parseNoteheadXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseNoteheadTextXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static int parseStaffXML(int num, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
            return 1;
        }

        public static void parseBeamXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseNotationsXML(int p, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
        }

        public static void parseLyricXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parsePlayXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }
     }
}
