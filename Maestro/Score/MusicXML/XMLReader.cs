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

        private static void parseScorePartwise(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            int num = 0;
            parseScoreHeaderXML(ref num, xmlNodeList, doc);
            while (num < xmlNodeList.Count)
            {
                if (xmlNodeList[num].Name.Equals("part"))             //only child type we have for now, there may be more
                {
                    XMLReader.parsePartXML(xmlNodeList[num++], doc);                    
                }
            }
        }

        private static void parseScoreTimewise(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            throw new NotImplementedException();
        }

        public static void parsePartXML(System.Xml.XmlNode partNode, ScoreDoc score)
        {
            Part part = new Part(score);
            score.parts.Add(part);

            XmlAttributeCollection attrs = partNode.Attributes;
            if (attrs["id"].Value != null)
            {
                part.id = attrs["id"].Value;                       //required attr
            }
            else
            {
                throw new MusicXMLReadException("MusicMXL error - part missing required id attribute");
            }

            foreach (XmlNode node in partNode.ChildNodes)
            {
                if (node.Name.Equals("measure"))
                {
                    XMLReader.parseMeasureXML(node, part);
                }
            }
        }

        public static void parseMeasureXML(XmlNode measureNode, Part part)
        {
            Measure measure = new Measure(part);
            part.measures.Add(measure);

            XmlAttributeCollection attrs = measureNode.Attributes;
            if (attrs["number"].Value != null)
            {
                measure.number = Convert.ToInt32(attrs["number"].Value);        //required attr
            }
            else
            {
                throw new MusicXMLReadException("MusicMXL error - measure missing required number attribute");
            }

            //music-data group
            foreach (XmlNode dataNode in measureNode.ChildNodes)
            {
                switch (dataNode.Name)
                {
                    case "note":
                        Note note = parseNoteXML(dataNode);
                        break;
                    case "backup":
                        Backup backup = parseBackupXML(dataNode);
                        break;
                    case "forward":
                        Forward forward = parseForwardXML(dataNode);
                        break;
                    case "direction": 
                        Direction direction = parseDirectionXML(dataNode);
                        break;
                    case "attributes": 
                        Attributes attributes = parseAttributesXML(dataNode);
                        break;
                    case "harmony":
                        Harmony harmony = parseHarmonyXML(dataNode);
                        break;
                    case "figured-bass":
                        FiguredBass figuredBass = parseFiguredBassXML(dataNode);
                        break;
                    case "print": 
                        Print print = parsePrintXML(dataNode);
                        break;
                    case "sound":
                        Sound sound = parseSoundXML(dataNode);
                        break;
                    case "barline": 
                        Barline barline = parseBarlineXML(dataNode);
                        break;
                    case "grouping":
                        Grouping grouping = parseGroupingXML(dataNode);
                        break;
                    case "link":
                        Link link = parseLinkXML(dataNode);
                        break;
                    case "bookmark":
                        Bookmark bookmark = parseBookmarkXML(dataNode);
                        break;
                    default: break;
                }
            }
        }

//- complex types -------------------------------------------------------------

        public static Accidental parseAccidentalXML(XmlNode node)
        {
            return null;
        }

        public static AccidentalMark parseAccidentalMarkXML(XmlNode node)
        {
            return null;
        }

        public static AccidentalText parseAccidentalTextXML(XmlNode node)
        {
            return null;
        }

        public static Accord parseAccordXML(XmlNode node)
        {
            return null;
        }

        public static AccordionRegistration parseAccordionRegistrationXML(XmlNode node)
        {
            return null;
        }

        public static Appearance parseAppearanceXML(XmlNode node)
        {
            return null;
        }

        public static Arpeggiate parseArpeggiateXML(XmlNode node)
        {
            return null;
        }

        public static Arrow parseArrowXML(XmlNode node)
        {
            return null;
        }

        public static Articulations parseArticulationsXML(XmlNode node)
        {
            return null;
        }

        public static Attributes parseAttributesXML(XmlNode node)
        {
            Console.WriteLine("parsing attributes node");
            return null;
        }

        public static Backup parseBackupXML(XmlNode node)
        {
            Console.WriteLine("parsing backup node");
            return null;
        }

        public static BarStyleColor parseBarStyleColorXML(XmlNode node)
        {
            return null;
        }

        public static Barline parseBarlineXML(XmlNode node)
        {
            Console.WriteLine("parsing barline node");
            return null;
        }

        public static Barre parseBarreXML(XmlNode node)
        {
            return null;
        }

        public static Bass parseBassXML(XmlNode node)
        {
            return null;
        }

        public static BassAlter parseBassAlterXML(XmlNode node)
        {
            return null;
        }

        public static BassStep parseBassStepXML(XmlNode node)
        {
            return null;
        }

        public static Beam parseBeamXML(XmlNode node)
        {
            return null;
        }

        //public static void parseBeamXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static BeatRepeat parseBeatRepeatXML(XmlNode node)
        {
            return null;
        }

        public static BeatUnitTied parseBeatUnitTiedXML(XmlNode node)
        {
            return null;
        }

        public static Beater parseBeaterXML(XmlNode node)
        {
            return null;
        }

        public static Bend parseBendXML(XmlNode node)
        {
            return null;
        }

        public static Bookmark parseBookmarkXML(XmlNode node)
        {
            return null;
        }

        public static Bracket parseBracketXML(XmlNode node)
        {
            return null;
        }

        public static BreathMark parseBreathMarkXML(XmlNode node)
        {
            return null;
        }

        public static Caesura parseCaesuraXML(XmlNode node)
        {
            return null;
        }

        public static Cancel parseCancelXML(XmlNode node)
        {
            return null;
        }

        public static Clef parseClefXML(XmlNode node)
        {
            return null;
        }

        public static Coda parseCodaXML(XmlNode node)
        {
            return null;
        }

        public static Credit parseCreditXML(XmlNode node)
        {
            return null;
        }

        public static Dashes parseDashesXML(XmlNode node)
        {
            return null;
        }

        public static Defaults parseDefaultsXML(XmlNode node)
        {
            return null;
        }

        public static Degree parseDegreeXML(XmlNode node)
        {
            return null;
        }

        public static DegreeAlter parseDegreeAlterXML(XmlNode node)
        {
            return null;
        }

        public static DegreeType parseDegreeTypeXML(XmlNode node)
        {
            return null;
        }

        public static DegreeValue parseDegreeValueXML(XmlNode node)
        {
            return null;
        }

        public static Direction parseDirectionXML(XmlNode node)
        {
            Console.WriteLine("parsing direction node");            
            return null;
        }

        public static Directiontype parseDirectionTypeXML(XmlNode node)
        {
            return null;
        }

        public static Distance parseDistanceXML(XmlNode node)
        {
            return null;
        }

        public static Dynamics parseDynamicsXML(XmlNode node)
        {
            return null;
        }

        public static Elision parseElisionXML(XmlNode node)
        {
            return null;
        }

        public static Empty parseEmptyXML(XmlNode node)
        {
            return null;
        }

        public static EmptyFont parseEmptyFontXML(XmlNode node)
        {
            return null;
        }

        public static EmptyLine parseEmptyLineXML(XmlNode node)
        {
            return null;
        }

        public static EmptyPlacementSmufl parseEmptyPlacementSmuflXML(XmlNode node)
        {
            return null;
        }

        public static EmptyPlacement parseEmptyPlacementXML(XmlNode node)
        {
            return null;
        }

        public static EmptyPrintObjectStyleAlign parseEmptyPrintObjectStyleAlignXML(XmlNode node)
        {
            return null;
        }

        public static EmptyPrintStyleAlignId parseEmptyPrintStyleAlignIdXML(XmlNode node)
        {
            return null;
        }

        public static EmptyTrillSound parseEmptyTrillSoundXML(XmlNode node)
        {
            return null;
        }

        public static Transonic.Score.Symbols.Encoding parseEncodingXML(XmlNode node)
        {
            return null;
        }

        public static Ending parseEndingXML(XmlNode node)
        {
            return null;
        }

        public static Extend parseExtendXML(XmlNode node)
        {
            return null;
        }

        public static Feature parseFeatureXML(XmlNode node)
        {
            return null;
        }

        public static Fermata parseFermataXML(XmlNode node)
        {
            return null;
        }

        public static Figure parseFigureXML(XmlNode node)
        {
            return null;
        }

        public static FiguredBass parseFiguredBassXML(XmlNode node)
        {
            return null;
        }

        public static Fingering parseFingeringXML(XmlNode node)
        {
            return null;
        }

        public static FirstFret parseFirstFretXML(XmlNode node)
        {
            return null;
        }

        public static FormattedSymbolId parseFormattedSymbolIdXML(XmlNode node)
        {
            return null;
        }

        public static FormattedTextId parseFormattedTextIdXML(XmlNode node)
        {
            return null;
        }

        public static FormattedText parseFormattedTextXML(XmlNode node)
        {
            return null;
        }

        public static Forward parseForwardXML(XmlNode node)
        {
            Console.WriteLine("parsing forward node");            
            return null;
        }

        public static FrameNote parseFrameNoteXML(XmlNode node)
        {
            return null;
        }

        public static Frame parseFrameXML(XmlNode node)
        {
            return null;
        }

        public static Fret parseFretXML(XmlNode node)
        {
            return null;
        }

        public static Glass parseGlassXML(XmlNode node)
        {
            return null;
        }

        public static Glissando parseGlissandoXML(XmlNode node)
        {
            return null;
        }

        public static Glyph parseGlyphXML(XmlNode node)
        {
            return null;
        }

        public static Grace parseGraceXML(XmlNode node)
        {
            return null;
        }

        //public static void parseGraceXML(int num, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static GroupBarline parseGroupBarlineXML(XmlNode node)
        {
            return null;
        }

        public static GroupName parseGroupNameXML(XmlNode node)
        {
            return null;
        }

        public static GroupSymbol parseGroupSymbolXML(XmlNode node)
        {
            return null;
        }

        public static Grouping parseGroupingXML(XmlNode node)
        {
            return null;
        }

        public static HammerOnPullOff parseHammerOnPullOffXML(XmlNode node)
        {
            return null;
        }

        public static Handbell parseHandbellXML(XmlNode node)
        {
            return null;
        }

        public static HarmonClosed parseHarmonClosedXML(XmlNode node)
        {
            return null;
        }

        public static HarmonMute parseHarmonMuteXML(XmlNode node)
        {
            return null;
        }

        public static Harmonic parseHarmonicXML(XmlNode node)
        {
            return null;
        }

        public static Harmony parseHarmonyXML(XmlNode node)
        {
            return null;
        }

        public static HarpPedals parseHarpPedalsXML(XmlNode node)
        {
            return null;
        }

        public static HeelToe parseHeelToeXML(XmlNode node)
        {
            return null;
        }

        public static Hole parseHoleXML(XmlNode node)
        {
            return null;
        }

        public static HoleClosed parseHoleClosedXML(XmlNode node)
        {
            return null;
        }

        public static HorizontalTurn parseHorizontalTurnXML(XmlNode node)
        {
            return null;
        }

        public static Identification parseIdentificationXML(XmlNode node)
        {
            return null;
        }

        public static Image parseImageXML(XmlNode node)
        {
            return null;
        }

        public static Instrument parseInstrumentXML(XmlNode node)
        {
            return null;
        }

        //public static void parseInstrumentXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static Interchangeable parseInterchangeableXML(XmlNode node)
        {
            return null;
        }

        public static Inversion parseInversionXML(XmlNode node)
        {
            return null;
        }

        public static Key parseKeyXML(XmlNode node)
        {
            return null;
        }

        public static KeyAccidental parseKeyAccidentalXML(XmlNode node)
        {
            return null;
        }

        public static KeyOctave parseKeyOctaveXML(XmlNode node)
        {
            return null;
        }

        public static Kind parseKindXML(XmlNode node)
        {
            return null;
        }

        public static Level parseLevelXML(XmlNode node)
        {
            return null;
        }

        public static LineWidth parseLineWidthXML(XmlNode node)
        {
            return null;
        }

        public static Link parseLinkXML(XmlNode node)
        {
            return null;
        }

        public static Lyric parseLyricXML(XmlNode node)
        {
            return null;
        }

        //public static void parseLyricXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static LyricFont parseLyricFontXML(XmlNode node)
        {
            return null;
        }

        public static LyricLanguage parseLyricLanguageXML(XmlNode node)
        {
            return null;
        }

        public static MeasureLayout parseMeasureLayoutXML(XmlNode node)
        {
            return null;
        }

        public static MeasureNumbering parseMeasureNumberingXML(XmlNode node)
        {
            return null;
        }

        public static MeasureRepeat parseMeasureRepeatXML(XmlNode node)
        {
            return null;
        }

        public static MeasureStyle parseMeasureStyleXML(XmlNode node)
        {
            return null;
        }

        public static Metronome parseMetronomeXML(XmlNode node)
        {
            return null;
        }

        public static MetronomeBeam parseMetronomeBeamXML(XmlNode node)
        {
            return null;
        }

        public static MetronomeNote parseMetronomeNoteXML(XmlNode node)
        {
            return null;
        }

        public static MetronomeTied parseMetronomeTiedXML(XmlNode node)
        {
            return null;
        }

        public static MetronomeTuplet parseMetronomeTupletXML(XmlNode node)
        {
            return null;
        }

        public static MidiDevice parseMidiDeviceXML(XmlNode node)
        {
            return null;
        }

        public static MidiInstrument parseMidiInstrumentXML(XmlNode node)
        {
            return null;
        }

        public static Miscellaneous parseMiscellaneousXML(XmlNode node)
        {
            return null;
        }

        public static MiscellaneousField parseMiscellaneousFieldXML(XmlNode node)
        {
            return null;
        }

        public static Mordent parseMordentXML(XmlNode node)
        {
            return null;
        }

        public static MultipleRest parseMultipleRestXML(XmlNode node)
        {
            return null;
        }

        public static NameDisplay parseNameDisplayXML(XmlNode node)
        {
            return null;
        }

        public static NonArpeggiate parseNonArpeggiateXML(XmlNode node)
        {
            return null;
        }

        public static Notations parseNotationsXML(XmlNode node)
        {
            return null;
        }

        //public static void parseNotationsXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    //throw new NotImplementedException();
        //}
        
        public static Note parseNoteXML(XmlNode node)
        {
            Note note = new Note();

            XmlNodeList childnodes = node.ChildNodes;
            int count = childnodes.Count;
            int num = 0;

            //choice
            if (childnodes[num].Name.Equals("grace"))
            {
                note.grace = parseGraceXML(childnodes[num++]);
                if (childnodes[num].Name.Equals("cue"))
                {
                    note.cue = true;
                    num++;
                    note.fullnote = parseFullNoteXML(ref num, childnodes);
                }
                else
                {
                    note.fullnote = parseFullNoteXML(ref num, childnodes);
                    for (int i = 0; i < 2; i++)
                    {
                        if (childnodes[num].Name.Equals("tie"))
                        {
                            note.tie[i] = parseTieXML(childnodes[num++]);
                        }
                    }
                }
            }
            else if (childnodes[num].Name.Equals("cue"))
            {
                note.cue = true;
                num++;
                note.fullnote = parseFullNoteXML(ref num, childnodes);
                note.duration = parseDurationXML(ref num, childnodes);
            }
            else
            {
                note.fullnote = parseFullNoteXML(ref num, childnodes);
                note.duration = parseDurationXML(ref num, childnodes);
                for (int i = 0; i < 2; i++)
                {
                    if (childnodes[num].Name.Equals("tie"))
                    {
                        note.tie[i] = parseTieXML(childnodes[num++]);
                    }
                }
            }

            if (childnodes[num].Name.Equals("instrument"))
            {
                note.instrument = parseInstrumentXML(childnodes[num++]);
            }
            note.editorialVoice = parseEditorialVoiceXML(ref num, childnodes);             //required
            if ((num < count) && childnodes[num].Name.Equals("type"))
            {
                note.notetype = parseNoteTypeXML(childnodes[num++]);
            };
            while ((num < count) && childnodes[num].Name.Equals("dot"))
            {
                note.dot = parseEmptyPlacementXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("accidental"))
            {
                note.accidental = parseAccidentalXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("time-modification"))
            {
                note.timeModification = parseTimeModificationXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("stem"))
            {
                note.stem = parseStemXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("notehead"))
            {
                note.notehead = parseNoteheadXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("notehead-text"))
            {
                note.noteheadText = parseNoteheadTextXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("staff"))
            {
                note.staff = parseStaffXML(ref num, childnodes);
            };
            for (int i = 0; i < 8; i++)
            {
                if ((num < count) && childnodes[num].Name.Equals("beam"))
                {
                    note.beam = parseBeamXML(childnodes[num++]);
                };
            }
            while ((num < count) && childnodes[num].Name.Equals("notations"))
            {
                note.notations = parseNotationsXML(childnodes[num++]);
            };
            while ((num < count) && childnodes[num].Name.Equals("lyric"))
            {
                note.lyric = parseLyricXML(childnodes[num++]);
            };
            if ((num < count) && childnodes[num].Name.Equals("play"))
            {
                note.play = parsePlayXML(childnodes[num++]);
            };

            return note;
        }
        
        public static NoteSize parseNoteSizeXML(XmlNode node)
        {
            return null;
        }

        public static NoteType parseNoteTypeXML(XmlNode node)
        {
            return null;
        }

        //public static void parseNoteTypeXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    note.notetype = childnodes[p].Value;
        //}

        public static Notehead parseNoteheadXML(XmlNode node)
        {
            return null;
        }

        //public static void parseNoteheadXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static NoteheadText parseNoteheadTextXML(XmlNode node)
        {
            return null;
        }

        //public static void parseNoteheadTextXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static OctaveShift parseOctaveShiftXML(XmlNode node)
        {
            return null;
        }

        public static Offset parseOffsetXML(XmlNode node)
        {
            return null;
        }

        public static Opus parseOpusXML(XmlNode node)
        {
            return null;
        }

        public static Ornaments parseOrnamentsXML(XmlNode node)
        {
            return null;
        }

        public static OtherAppearance parseOtherAppearanceXML(XmlNode node)
        {
            return null;
        }

        public static OtherDirection parseOtherDirectionXML(XmlNode node)
        {
            return null;
        }

        public static OtherNotation parseOtherNotationXML(XmlNode node)
        {
            return null;
        }

        public static OtherPlacementText parseOtherPlacementTextXML(XmlNode node)
        {
            return null;
        }

        public static OtherPlay parseOtherPlayXML(XmlNode node)
        {
            return null;
        }

        public static OtherText parseOtherTextXML(XmlNode node)
        {
            return null;
        }

        public static PageLayout parsePageLayoutXML(XmlNode node)
        {
            return null;
        }

        public static PageMargins parsePageMarginsXML(XmlNode node)
        {
            return null;
        }

        public static PartGroup parsePartGroupXML(XmlNode node)
        {
            return null;
        }

        public static PartList parsePartListXML(XmlNode node)
        {
            return null;
        }

        public static PartName parsePartNameXML(XmlNode node)
        {
            return null;
        }

        public static PartSymbol parsPartSymbolXML(XmlNode node)
        {
            return null;
        }

        public static Pedal parsePedalXML(XmlNode node)
        {
            return null;
        }

        public static PedalTuning parsePedalTuningXML(XmlNode node)
        {
            return null;
        }

        public static PerMinute parsePerMinuteXML(XmlNode node)
        {
            return null;
        }

        public static Percussion parsePercussionXML(XmlNode node)
        {
            return null;
        }

        public static Pitch parsePitchXML(XmlNode node)
        {
            return null;
        }

        //private static void parsePitchXML(XmlNode pitchNode, Note note)
        //{
        //    int num = 0;
        //    XmlNodeList childnodes = pitchNode.ChildNodes;
        //    string stepstr = childnodes[num++].InnerText.ToUpper();
        //    note.step = stepstr[0] - 'A';
        //    if (childnodes[num].Name.Equals("alter"))
        //    {
        //        note.alter = Convert.ToDouble(childnodes[num++].InnerText);
        //    }
        //    note.octave = Convert.ToInt32(childnodes[num].InnerText);
        //}
        
        public static Pitched parsePitchedXML(XmlNode node)
        {
            return null;
        }

        public static PlacementText parsePlacementTextXML(XmlNode node)
        {
            return null;
        }

        public static Play parsePlayXML(XmlNode node)
        {
            return null;
        }

        //public static void parsePlayXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static PrincipalVoice parsePrincipalVoiceXML(XmlNode node)
        {
            return null;
        }

        public static Print parsePrintXML(XmlNode node)
        {
            Console.WriteLine("parsing print node");
            return null;
        }

        public static Repeat parseRepeatXML(XmlNode node)
        {
            return null;
        }

        public static Rest parseRestXML(XmlNode node)
        {
            return null;
        }

        //private static void parseRestXML(XmlNode restNode, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static Root parseRootXML(XmlNode node)
        {
            return null;
        }

        public static RootAlter parseRootAlterXML(XmlNode node)
        {
            return null;
        }

        public static RootStep parseRootStepXML(XmlNode node)
        {
            return null;
        }

        public static Scaling parseScalingXML(XmlNode node)
        {
            return null;
        }

        public static Scordatura parseScordaturaXML(XmlNode node)
        {
            return null;
        }

        public static ScoreInstrument parseScoreInstrumentXML(XmlNode node)
        {
            return null;
        }

        public static ScorePart parseScorePartXML(XmlNode node)
        {
            return null;
        }

        public static Segno parseSegnoXML(XmlNode node)
        {
            return null;
        }

        public static Slash parseSlashXML(XmlNode node)
        {
            return null;
        }

        public static Slide parseSlideXML(XmlNode node)
        {
            return null;
        }

        public static Slur parseSlurXML(XmlNode node)
        {
            return null;
        }

        public static Sound parseSoundXML(XmlNode node)
        {
            return null;
        }

        public static StaffDetails parseStaffDetailsXML(XmlNode node)
        {
            return null;
        }

        public static StaffDivide parseStaffDivideXML(XmlNode node)
        {
            return null;
        }

        public static StaffLayout parseStaffLayoutXML(XmlNode node)
        {
            return null;
        }

        public static Staff parseStafftuningXML(XmlNode node)
        {
            return null;
        }

        public static Stem parseStemXML(XmlNode node)
        {
            return null;
        }

        //public static void parseStemXML(int p, XmlNodeList childnodes, Note note)
        //{
        //    //throw new NotImplementedException();
        //}

        public static Stick parseStickXML(XmlNode node)
        {
            return null;
        }

        public static StringSym parseStringXML(XmlNode node)
        {
            return null;
        }

        public static StringMute parseStringMuteXML(XmlNode node)
        {
            return null;
        }

        public static StrongAccent parseStrongAccentXML(XmlNode node)
        {
            return null;
        }

        public static StyleText parseStyleTextXML(XmlNode node)
        {
            return null;
        }

        public static Supports parseSupportsXML(XmlNode node)
        {
            return null;
        }

        public static SystemDividers parseSystemDividersXML(XmlNode node)
        {
            return null;
        }

        public static SystemLayout parseSystemLayoutXML(XmlNode node)
        {
            return null;
        }

        public static SystemMargins parseSystemMarginsXML(XmlNode node)
        {
            return null;
        }

        public static Tap parseTapXML(XmlNode node)
        {
            return null;
        }

        public static Technical parseTechnicalXML(XmlNode node)
        {
            return null;
        }

        public static TextElementData parseTextElementDataXML(XmlNode node)
        {
            return null;
        }

        public static Tie parseTieXML(XmlNode node)
        {
            return null;
        }

        //public static void parseTieXML(int num, XmlNodeList childnodes)
        //{            
        //    throw new NotImplementedException();
        //}

        public static Tied parseTiedXML(XmlNode node)
        {
            return null;
        }

        public static Time parseTimeXML(XmlNode node)
        {
            return null;
        }

        public static TimeModification parseTimeModificationXML(XmlNode node)
        {
            return null;
        }

        //public static void parseTimeModificationXML(int p, XmlNodeList childnodes)
        //{
        //    throw new NotImplementedException();
        //}

        public static Transpose parseTransposeXML(XmlNode node)
        {
            return null;
        }

        public static Tremolo parseTremoloXML(XmlNode node)
        {
            return null;
        }

        public static Tuplet parseTupletXML(XmlNode node)
        {
            return null;
        }

        public static TupletDot parseTupletDotXML(XmlNode node)
        {
            return null;
        }

        public static TupletNumber parseTupletNumberXML(XmlNode node)
        {
            return null;
        }

        public static TupletPortion parseTupletPortionXML(XmlNode node)
        {
            return null;
        }

        public static TupletType parseTupletTypeXML(XmlNode node)
        {
            return null;
        }

        public static TypedText parseTypedTextXML(XmlNode node)
        {
            return null;
        }

        public static Unpitched parseUnpitchedXML(XmlNode node)
        {
            return null;
        }

        //private static void parseUnpitchedXML(XmlNode unpitchedNode, Note note)
        //{
        //    throw new NotImplementedException();
        //}

        public static VirtualInstrument parseVirtualInstrumentXML(XmlNode node)
        {
            return null;
        }

        public static WavyLine parseWavyLineXML(XmlNode node)
        {
            return null;
        }

        public static Wedge parseWedgeXML(XmlNode node)
        {
            return null;
        }

        public static Work parseWorkXML(XmlNode node)
        {
            return null;
        }

//- element groups -------------------------------------------------------------

        public static AllMargins parseAllMarginsXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }
        
        public static BeatUnit parseBeatUnitXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }


        public static DisplayStepOctave parseDisplayStepOctaveXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static Duration parseDurationXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        //public static int parseDurationXML(int num, XmlNodeList childnodes, Note note)
        //{
        //    note.duration = Convert.ToDouble(childnodes[0].Value);
        //    return 1;
        //}

        public static EditorialVoiceDirection parseEditorialVoiceDirectionXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static EditorialVoice parseEditorialVoiceXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        //public static EditorialVoice parseEditorialVoice(ref int num, XmlNodeList childnodes)
        //{
        //    //if (childnodes[num].Name.Equals("footnote"))
        //    //{
        //    //    num = parseFootnoteXML(num, childnodes, note);
        //    //}
        //    //if (childnodes[num].Name.Equals("level"))
        //    //{
        //    //    num = parseLevelXML(num, childnodes, note);
        //    //}
        //    //if (childnodes[num].Name.Equals("voice"))
        //    //{
        //    //    num = parseVoiceXML(num, childnodes, note);
        //    //}
        //    //return num;
        //    return null;
        //}

        public static Footnote parseFootnoteXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static FullNote parseFullNoteXML(ref int num, XmlNodeList childnodes)
        {
            //int count = childnodes.Count;
            //if ((num < count) && childnodes[num].Name.Equals("chord"))
            //{
            //    note.chord = true;
            //    num++;
            //};
            //if (childnodes[num].Name.Equals("pitch"))
            //{
            //    parsePitchXML(childnodes[num++], note);
            //}
            //else if (childnodes[num].Name.Equals("unpitched"))
            //{
            //    parseUnpitchedXML(childnodes[num++], note);
            //}
            //else
            //{
            //    parseRestXML(childnodes[num++], note);
            //}
            //return num;
            return null;
        }

        public static HarmonyChord parseHarmonyChordXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static Layout parseLayoutXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static LeftRightMargins parseLeftRightMarginsXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static LevelGroup parseLevelXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static MusicData parseMusicDataXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static NonTraditionalKey parseNonTraditionalKeyXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static PartGroup parsePartGroupXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static void parseScoreHeaderXML(ref int num, XmlNodeList childnodes, ScoreDoc doc)
        {
            int count = (childnodes != null) ? childnodes.Count : 0;

            if ((num < count) && (childnodes[num].Name.Equals("work")))
            {
                doc.work = parseWorkXML(childnodes[num++]);
            };
            if ((num < count) && (childnodes[num].Name.Equals("identification")))
            {
                doc.identification = parseIdentificationXML(childnodes[num++]);
            };
            if ((num < count) && (childnodes[num].Name.Equals("defaults")))
            {
                doc.defaults = parseDefaultsXML(childnodes[num++]);
            };
            while ((num < count) && (childnodes[num].Name.Equals("credit")))
            {
                doc.credits.Add(parseCreditXML(childnodes[num++]));
            };
            if ((num < count) && (childnodes[num].Name.Equals("part-list")))
            {
                doc.partList = parsePartListXML(childnodes[num++]);
            }
            else
            {
                throw new MusicXMLReadException("MusicMXL error - missing part-list from score-header group");
            }
        }

        public static ScorePart parseScorePartXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static Slash parseSlashXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static StaffX parseStaffXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        //public static int parseStaffXML(int num, XmlNodeList childnodes, Note note)
        //{
        //    //throw new NotImplementedException();
        //    return 1;
        //}
        
        public static TimeSignature parseTimeSignatureXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static TraditionalKey parseTraditionalKeyXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static Tuning parseTuningXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        public static Voice parseVoiceXML(ref int num, XmlNodeList childnodes)
        {
            return null;
        }

        //private static int parseVoiceXML(int num, XmlNodeList childnodes, Note note)
        //{
        //    note.voice = childnodes[0].Value;
        //    return 1;
        //}
    }

//-----------------------------------------------------------------------------

    public class MusicXMLReadException : Exception
    {
        public MusicXMLReadException(String msg) : base(msg) { }
    }
}
