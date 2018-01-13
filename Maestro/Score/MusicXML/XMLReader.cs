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
using System.Xml;

using Transonic.Score;
using Transonic.Score.Symbols;

namespace Transonic.Score.MusicXML
{
    class XMLReader
    {
        public static ScoreDoc loadFromMusicXML(ScoreSheet sheet, String filename)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.XmlResolver = null;
            try
            {
                xmlDoc.Load(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine("exception loading MXL file: " + e.Message);
            }

            ScoreDoc doc = new ScoreDoc(sheet);
            doc.filename = filename;

            if (xmlDoc.DocumentElement.Name.Equals("score-partwise"))
            {
                parseScorePartwise(xmlDoc.DocumentElement.ChildNodes, doc);
            }
            else if (xmlDoc.DocumentElement.Name.Equals("score-timewise"))
            {
                parseScoreTimewise(xmlDoc.DocumentElement.ChildNodes, doc);
            }
            else
            {
            }

            return doc;
        }

        private static int parseScoreHeader(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            int count = xmlNodeList.Count;
            int num = 0;
            if ((num < count) && xmlNodeList[num].Name.Equals("work")) { num++; };
            if ((num < count) && xmlNodeList[num].Name.Equals("movement-number")) { num++; };
            if ((num < count) && xmlNodeList[num].Name.Equals("movement-title")) { num++; };
            if ((num < count) && xmlNodeList[num].Name.Equals("identification")) { num++; };
            if ((num < count) && xmlNodeList[num].Name.Equals("defaults")) { num++; };
            while ((num < count) && xmlNodeList[num].Name.Equals("credit")) { num++; };
            if ((num < count) && xmlNodeList[num].Name.Equals("part-list")) { num++; };
            return num;
        }

        private static void parseScorePartwise(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            int num = parseScoreHeader(xmlNodeList, doc);
            while (num < xmlNodeList.Count)
            {
                if (xmlNodeList[num].Name.Equals("part"))             //only child type we have for now, there may be more
                {
                    XMLReader.parsePartXML(xmlNodeList[num], doc);
                    num++;
                }
            }
        }

        private static void parseScoreTimewise(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            throw new NotImplementedException();
        }

        public static void parsePartXML(System.Xml.XmlNode partNode, ScoreDoc score)
        {
            XmlAttributeCollection attrs = partNode.Attributes;
            String idstr = attrs["id"].Value;                       //required attr


            Part part = new Part(score, idstr);
            score.parts.Add(part);

            foreach (XmlNode node in partNode.ChildNodes)
            {
                XMLReader.parseMeasureXML(node, part);
            }
        }

        public static void parseMeasureXML(XmlNode measureNode, Part part)
        {
            XmlAttributeCollection attrs = measureNode.Attributes;
            int number = Convert.ToInt32(attrs["number"].Value);        //required attr

            Measure measure = new Measure(part, number);
            part.measures.Add(measure);

            foreach (XmlNode dataNode in measureNode.ChildNodes)
            {
                Console.WriteLine("have data type = " + dataNode.Name);

                switch (dataNode.Name)
                {
                    case "note":
                        Note note = parseNoteXML(dataNode);
                        break;
                    case "backup": break;
                    case "forward": break;
                    case "direction": break;
                    case "attributes": break;
                    case "print": break;
                    case "barline": break;
                    default: break;
                }
            }
        }

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
            else
            {
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
