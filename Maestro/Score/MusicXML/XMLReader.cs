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
    public class XMLReader
    {

//- root nodes ----------------------------------------------------------------

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
                throw new MusicXMLReadException("MusicMXL error loading file " + filename + " : " + e.Message);
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
                throw new MusicXMLReadException("MusicMXL error - unknown root element: " + xmlDoc.DocumentElement.Name);
            }

            return doc;
        }

        private static int parseScoreHeader(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            int count = xmlNodeList.Count;
            int num = 0;
            if ((num < count) && xmlNodeList[num].Name.Equals("work")) {
                doc.work = parseWorkXML(xmlNodeList[num++]);                
            };
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

        public static void parseDotXML(int p, XmlNodeList childnodes, Note note)
        {
            note.dot++;
        }

//- complex types -------------------------------------------------------------

        public static Accidental parseAccidentalXML(XmlNode node)
        {
            return null;
        }

        public static void parseAccidentalMarkXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseAccidentalTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseAccordXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseAccordionRegistrationXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseAppearanceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseArpeggiateXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseArrowXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseArticulationsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseAttributesXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBackupXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBarStyleColorXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBarlineXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBarreXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBassXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBassAlterXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBassStepXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBeamXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBeamXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseBeatRepeatXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBeatUnitTiedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBeaterXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBendXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBookmarkXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBracketXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseBreathMarkXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseCaesuraXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseCancelXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseClefXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseCodaXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseCreditXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDashesXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDefaultsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDegreeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDegreeAlterXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDegreeTypeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDegreeValueXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDirectionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDirectionTypeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDistanceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseDynamicsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseElisionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyFontXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyLineXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyPlacementSmuflXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyPlacementXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyPrintObjectStyleAlignXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyPrintStyleAlignIdXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEmptyTrillSoundXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEncodingXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseEndingXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseExtendXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFeatureXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFermataXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFigureXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFiguredBassXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFingeringXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFirstFretXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFormattedSymbolIdXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFormattedTextIdXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFormattedTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseForwardXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFrameNoteXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFrameXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseFretXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGlassXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGlissandoXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGlyphXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGraceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGraceXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseGroupBarlineXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGroupNameXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGroupSymbolXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseGroupingXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHammerOnPullOffXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHandbellXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHarmonClosedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHarmonMuteXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHarmonicXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHarmonyXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHarpPedalsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHeelToeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHoleXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHoleClosedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseHorizontalTurnXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseIdentificationXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseImageXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseInstrumentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseInstrumentXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseInterchangeableXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseInversionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseKeyXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseKeyAccidentalXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseKeyOctaveXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseKindXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLevelXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLineWidthXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLinkXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLyricXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLyricXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseLyricFontXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseLyricLanguageXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMeasureLayoutXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMeasureNumberingXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMeasureRepeatXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMeasureStyleXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMetronomeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMetronomeBeamXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMetronomeNoteXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMetronomeTiedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMetronomeTupletXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMidiDeviceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMidiInstrumentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMiscellaneousXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMiscellaneousFieldXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMordentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseMultipleRestXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNameDisplayXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNonArpeggiateXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNotationsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNotationsXML(int p, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
        }
        
        public static void parseNoteXML(XmlNode node, Symbol sym)
        {
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
                note.accidental = parseAccidentalXML(childnodes[num++]);
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
        
        public static void parseNoteSizeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNoteTypeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNoteTypeXML(int p, XmlNodeList childnodes, Note note)
        {
            note.notetype = childnodes[p].Value;
        }

        public static void parseNoteheadXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNoteheadXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseNoteheadTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseNoteheadTextXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseOctaveShiftXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOffsetXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOpusXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOrnamentsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherAppearanceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherDirectionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherNotationXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherPlacementTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherPlayXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseOtherTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePageLayoutXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePageMarginsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePartGroupXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePartListXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePartNameXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsPartSymbolXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePedalXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePedalTuningXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePerMinuteXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePercussionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePitchXML(XmlNode node, Symbol sym)
        {
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
        
        public static void parsePitchedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePlacementTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePlayXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePlayXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parsePrincipalVoiceXML(XmlNode node, Symbol sym)
        {
        }

        public static void parsePrintXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseRepeatXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseRestXML(XmlNode node, Symbol sym)
        {
        }

        private static void parseRestXML(XmlNode restNode, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseRootXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseRootAlterXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseRootStepXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseScalingXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseScordaturaXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseScoreInstrumentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseScorePartXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSegnoXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSlashXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSlideXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSlurXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSoundXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStaffDetailsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStaffDivideXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStaffLayoutXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStafftuningXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStemXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStemXML(int p, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
        }

        public static void parseStickXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStringXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStringMuteXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStrongAccentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseStyleTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSupportsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSystemDividersXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSystemLayoutXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseSystemMarginsXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTapXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTechnicalXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTextElementDataXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTieXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTieXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseTiedXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTimeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTimeModificationXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTimeModificationXML(int p, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseTransposeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTremoloXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTupletXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTupletDotXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTupletNumberXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTupletPortionXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTupletTypeXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseTypedTextXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseUnpitchedXML(XmlNode node, Symbol sym)
        {
        }

        private static void parseUnpitchedXML(XmlNode unpitchedNode, Note note)
        {
            throw new NotImplementedException();
        }

        public static void parseVirtualInstrumentXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseWavyLineXML(XmlNode node, Symbol sym)
        {
        }

        public static void parseWedgeXML(XmlNode node, Symbol sym)
        {
        }

        public static Work parseWorkXML(XmlNode node)
        {
            return null;
        }

//- element groups -------------------------------------------------------------

        public static int parseAllMarginsXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }
        
                    public static int parseBeatUnitXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }


        public static int parseDisplayStepOctaveXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseDurationXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseDurationXML(int num, XmlNodeList childnodes, Note note)
        {
            note.duration = Convert.ToDouble(childnodes[0].Value);
            return 1;
        }

        public static int parseEditorialVoiceDirectionXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseEditorialVoiceXML(int num, XmlNodeList childnodes, Symbol sym)
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

        public static int parseEditorialXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseFootnoteXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        private static int parseFootnoteXML(int num, XmlNodeList childnodes, Note note)
        {
            throw new NotImplementedException();
        }

        public static int parseFullNoteXML(int num, XmlNodeList childnodes, Symbol sym)
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

        public static int parseHarmonyChordXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseLayoutXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseLeftRightMarginsXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseLevelXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseMusicDataXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseNonTraditionalKeyXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parsePartGroupXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseScoreHeaderXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseScorePartXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseSlashXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseStaffXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseStaffXML(int num, XmlNodeList childnodes, Note note)
        {
            //throw new NotImplementedException();
            return 1;
        }
        
        public static int parseTimeSignatureXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseTraditionalKeyXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseTuningXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        public static int parseVoiceXML(int num, XmlNodeList childnodes, Symbol sym)
        {
            throw new NotImplementedException();
        }

        private static int parseVoiceXML(int num, XmlNodeList childnodes, Note note)
        {
            note.voice = childnodes[0].Value;
            return 1;
        }
    }

//-----------------------------------------------------------------------------

    public class MusicXMLReadException : Exception
    {
        public MusicXMLReadException(String msg) : base(msg) { }
    }
}
