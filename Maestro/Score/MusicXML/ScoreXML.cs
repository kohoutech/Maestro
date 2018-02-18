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

using System.Xml.Serialization;

//classes for reading/writing to MusicXML files
//generated using MS xsd.exe from MUSICXML's musicxml.xsd (https://github.com/w3c/musicxml)

namespace Transonic.Score.MusicXML
{

//- score part-wise -----------------------------------------------------------

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("score-partwise", Namespace = "", IsNullable = false)]
    public class scorepartwise
    {
        public work work;

        [System.Xml.Serialization.XmlElementAttribute("movement-number")]
        public string movementnumber;

        [System.Xml.Serialization.XmlElementAttribute("movement-title")]
        public string movementtitle;

        public identification identification;

        public defaults defaults;

        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public credit[] credit;

        [System.Xml.Serialization.XmlElementAttribute("part-list")]
        public partlist partlist;

        [System.Xml.Serialization.XmlElementAttribute("part")]
        public scorepartwisePart[] part;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1.0")]
        public string version;

        public scorepartwise()
        {
            this.version = "1.0";
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scorepartwisePart
    {

        [System.Xml.Serialization.XmlElementAttribute("measure")]
        public scorepartwisePartMeasure[] measure;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scorepartwisePartMeasure
    {

        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributesXML))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backupXML))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barlineXML))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forwardXML))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(printXML))]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(sound))]
        public object[] Items;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno @implicit;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool implicitSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("non-controlling")]
        public yesno noncontrolling;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noncontrollingSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified;
    }

//- score header classes ------------------------------------------------------

    [System.SerializableAttribute()]
    public class work
    {

        [System.Xml.Serialization.XmlElementAttribute("work-number")]
        public string worknumber;

        [System.Xml.Serialization.XmlElementAttribute("work-title")]
        public string worktitle;

        public opus opus;
    }

    [System.SerializableAttribute()]
    public class opus
    {

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public opusType type;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string role;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string title;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [System.ComponentModel.DefaultValueAttribute(opusShow.replace)]
        public opusShow show;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [System.ComponentModel.DefaultValueAttribute(opusActuate.onRequest)]
        public opusActuate actuate;

        public opus()
        {
            this.type = opusType.simple;
            this.show = opusShow.replace;
            this.actuate = opusActuate.onRequest;
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusType
    {
        simple,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusShow
    {
        @new,
        replace,
        embed,
        other,
        none
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusActuate
    {
        onRequest,
        onLoad,
        other,
        none
    }

    [System.SerializableAttribute()]
    public class identification
    {
        [System.Xml.Serialization.XmlElementAttribute("creator")]
        public typedtext[] creator;

        [System.Xml.Serialization.XmlElementAttribute("rights")]
        public typedtext[] rights;

        public encoding encoding;

        public string source;

        [System.Xml.Serialization.XmlElementAttribute("relation")]
        public typedtext[] relation;

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public miscellaneousfield[] miscellaneous;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "typed-text")]
    public class typedtext
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class encoding
    {
        [System.Xml.Serialization.XmlElementAttribute("encoder", typeof(typedtext))]
        [System.Xml.Serialization.XmlElementAttribute("encoding-date", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("encoding-description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("software", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("supports", typeof(supports))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
    }

    [System.SerializableAttribute()]
    public class supports
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string element;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string attribute;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        encoder,
        [System.Xml.Serialization.XmlEnumAttribute("encoding-date")]
        encodingdate,
        [System.Xml.Serialization.XmlEnumAttribute("encoding-description")]
        encodingdescription,
        software,
        supports,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "miscellaneous-field")]
    public class miscellaneousfield
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "lyric-language")]
    public class lyriclanguage
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "lyric-font")]
    public class lyricfont
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-font")]
    public class emptyfont
    {
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-appearance")]
    public class otherappearance
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class glyph
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute(DataType = "NMTOKEN")]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class distance
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-size")]
    public class notesize
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public notesizetype type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-size-type")]
    public enum notesizetype
    {
        cue,
        grace,
        [System.Xml.Serialization.XmlEnumAttribute("grace-cue")] 
        gracecue,
        large
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-width")]
    public class linewidth
    {
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    [System.SerializableAttribute()]
    public class appearance
    {

        [System.Xml.Serialization.XmlElementAttribute("line-width")]
        public linewidth[] linewidth;

        [System.Xml.Serialization.XmlElementAttribute("note-size")]
        public notesize[] notesize;

        [System.Xml.Serialization.XmlElementAttribute("distance")]
        public distance[] distance;

        [System.Xml.Serialization.XmlElementAttribute("glyph")]
        public glyph[] glyph;

        [System.Xml.Serialization.XmlElementAttribute("other-appearance")]
        public otherappearance[] otherappearance;
    }

    [System.SerializableAttribute()]
    public class scaling
    {
        public decimal millimeters;
        public decimal tenths;
    }

    [System.SerializableAttribute()]
    public class defaults
    {

        public scaling scaling;

        [System.Xml.Serialization.XmlElementAttribute("page-layout")]
        public pagelayout pagelayout;

        [System.Xml.Serialization.XmlElementAttribute("system-layout")]
        public systemlayout systemlayout;

        [System.Xml.Serialization.XmlElementAttribute("staff-layout")]
        public stafflayout[] stafflayout;

        public appearance appearance;

        [System.Xml.Serialization.XmlElementAttribute("music-font")]
        public emptyfont musicfont;

        [System.Xml.Serialization.XmlElementAttribute("word-font")]
        public emptyfont wordfont;

        [System.Xml.Serialization.XmlElementAttribute("lyric-font")]
        public lyricfont[] lyricfont;

        [System.Xml.Serialization.XmlElementAttribute("lyric-language")]
        public lyriclanguage[] lyriclanguage;
    }

    [System.SerializableAttribute()]
    public class credit
    {
        [System.Xml.Serialization.XmlElementAttribute("credit-type", Order = 0)]
        public string[] credittype;

        [System.Xml.Serialization.XmlElementAttribute("link", Order = 1)]
        public link[] link;

        [System.Xml.Serialization.XmlElementAttribute("bookmark", Order = 2)]
        public bookmark[] bookmark;

        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-image", typeof(image), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-symbol", typeof(formattedsymbolid), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-words", typeof(formattedtextid), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link), Order = 3)]
        public object[] Items;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string page;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "virtual-instrument")]
    public class virtualinstrument
    {
        [System.Xml.Serialization.XmlElementAttribute("virtual-library")]
        public string virtuallibrary;

        [System.Xml.Serialization.XmlElementAttribute("virtual-name")]
        public string virtualname;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-instrument")]
    public class scoreinstrument
    {
        [System.Xml.Serialization.XmlElementAttribute("instrument-name")]
        public string instrumentname;

        [System.Xml.Serialization.XmlElementAttribute("instrument-abbreviation")]
        public string instrumentabbreviation;

        [System.Xml.Serialization.XmlElementAttribute("instrument-sound")]
        public string instrumentsound;

        [System.Xml.Serialization.XmlElementAttribute("ensemble", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("solo", typeof(empty))]
        public object Item;

        [System.Xml.Serialization.XmlElementAttribute("virtual-instrument")]
        public virtualinstrument virtualinstrument;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-name")]
    public class partname
    {

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-part")]
    public class scorepart
    {

        public identification identification;

        [System.Xml.Serialization.XmlElementAttribute("part-name")]
        public partname partname;

        [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
        public namedisplay partnamedisplay;

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation")]
        public partname partabbreviation;

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
        public namedisplay partabbreviationdisplay;

        [System.Xml.Serialization.XmlElementAttribute("group")]
        public string[] group;

        [System.Xml.Serialization.XmlElementAttribute("score-instrument")]
        public scoreinstrument[] scoreinstrument;

        [System.Xml.Serialization.XmlElementAttribute("midi-device")]
        public mididevice[] mididevice;

        [System.Xml.Serialization.XmlElementAttribute("midi-instrument")]
        public midiinstrument[] midiinstrument;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-barline")]
    public class groupbarline
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlTextAttribute()]
        public groupbarlinevalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-barline-value")]
    public enum groupbarlinevalue
    {
        yes,
        no,
        Mensurstrich,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-symbol")]
    public class groupsymbol
    {

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlTextAttribute()]
        public groupsymbolvalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-name")]
    public class groupname
    {

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-group")]
    public class partgroup
    {

        [System.Xml.Serialization.XmlElementAttribute("group-name")]
        public groupname groupname;

        [System.Xml.Serialization.XmlElementAttribute("group-name-display")]
        public namedisplay groupnamedisplay;

        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation")]
        public groupname groupabbreviation;

        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation-display")]
        public namedisplay groupabbreviationdisplay;

        [System.Xml.Serialization.XmlElementAttribute("group-symbol")]
        public groupsymbol groupsymbol;

        [System.Xml.Serialization.XmlElementAttribute("group-barline")]
        public groupbarline groupbarline;

        [System.Xml.Serialization.XmlElementAttribute("group-time")]
        public empty grouptime;

        public formattedtext footnote;

        public level level;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        public partgroup()
        {
            this.number = "1";
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-list")]
    public class partlist
    {

        [System.Xml.Serialization.XmlElementAttribute("part-group", Order = 0)]
        public partgroup[] partgroup;

        [System.Xml.Serialization.XmlElementAttribute("score-part", Order = 1)]
        public scorepart scorepart;

        [System.Xml.Serialization.XmlElementAttribute("part-group", typeof(partgroup), Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("score-part", typeof(scorepart), Order = 2)]
        public object[] Items;
    }

//- note classes --------------------------------------------------------------

    [System.SerializableAttribute()]
    public class note
    {
        [System.Xml.Serialization.XmlElementAttribute("chord", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("cue", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("duration", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("grace", typeof(grace))]
        [System.Xml.Serialization.XmlElementAttribute("pitch", typeof(pitch))]
        [System.Xml.Serialization.XmlElementAttribute("rest", typeof(rest))]
        [System.Xml.Serialization.XmlElementAttribute("tie", typeof(tie))]
        [System.Xml.Serialization.XmlElementAttribute("unpitched", typeof(unpitched))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName;

        public instrument instrument;

        public formattedtext footnote;

        public level level;

        public string voice;

        public notetype type;

        [System.Xml.Serialization.XmlElementAttribute("dot")]
        public emptyplacement[] dot;

        public accidental accidental;

        [System.Xml.Serialization.XmlElementAttribute("time-modification")]
        public timemodification timemodification;

        public stem stem;

        public notehead notehead;

        [System.Xml.Serialization.XmlElementAttribute("notehead-text")]
        public noteheadtext noteheadtext;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;

        [System.Xml.Serialization.XmlElementAttribute("beam")]
        public beam[] beam;

        [System.Xml.Serialization.XmlElementAttribute("notations")]
        public notations[] notations;

        [System.Xml.Serialization.XmlElementAttribute("lyric")]
        public lyric[] lyric;

        public play play;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public yesno printdot;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printdotSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public yesno printlyric;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlyricSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("print-leger")]
        public yesno printleger;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlegerSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dynamics;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dynamicsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("end-dynamics")]
        public decimal enddynamics;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enddynamicsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attack;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attackSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal release;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno pizzicato;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pizzicatoSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        chord,
        cue,
        duration,
        grace,
        pitch,
        rest,
        tie,
        unpitched
    }

    [System.SerializableAttribute()]
    public class rest
    {

        [System.Xml.Serialization.XmlElementAttribute("display-step")]
        public step displaystep;

        [System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
        public string displayoctave;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno measure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified;
    }

    [System.SerializableAttribute()]
    public class unpitched
    {

        [System.Xml.Serialization.XmlElementAttribute("display-step")]
        public step displaystep;

        [System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
        public string displayoctave;
    }

    [System.SerializableAttribute()]
    public class pitch
    {

        public step step;

        public decimal alter;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alterSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string octave;
    }

    [System.SerializableAttribute()]
    public class grace
    {

        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-previous")]
        public decimal stealtimeprevious;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimepreviousSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-following")]
        public decimal stealtimefollowing;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimefollowingSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("make-time")]
        public decimal maketime;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maketimeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno slash;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slashSpecified;
    }

    [System.SerializableAttribute()]
    public class elision
    {

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "text-element-data")]
    public class textelementdata
    {

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string underline;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string overline;

        [System.Xml.Serialization.XmlAttributeAttribute("line-through", DataType = "nonNegativeInteger")]
        public string linethrough;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal rotation;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rotationSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("letter-spacing")]
        public string letterspacing;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public textdirection dir;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dirSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "text-direction")]
    public enum textdirection
    {
        ltr,
        rtl,
        lro,
        rlo,
    }

    [System.SerializableAttribute()]
    public class lyric
    {

        [System.Xml.Serialization.XmlElementAttribute("elision", typeof(elision))]
        [System.Xml.Serialization.XmlElementAttribute("extend", typeof(extend))]
        [System.Xml.Serialization.XmlElementAttribute("humming", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("laughing", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("syllabic", typeof(syllabic))]
        [System.Xml.Serialization.XmlElementAttribute("text", typeof(textelementdata))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType6[] ItemsElementName;

        [System.Xml.Serialization.XmlElementAttribute("end-line")]
        public empty endline;

        [System.Xml.Serialization.XmlElementAttribute("end-paragraph")]
        public empty endparagraph;

        public formattedtext footnote;

        public level level;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright justify;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool justifySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    public enum syllabic
    {
        single,
        begin,
        end,
        middle
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType6
    {
        elision,
        extend,
        humming,
        laughing,
        syllabic,
        text
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-notation")]
    public class othernotation
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopsingle type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public othernotation()
        {
            this.number = "1";
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "non-arpeggiate")]
    public class nonarpeggiate
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public topbottom type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "top-bottom")]
    public enum topbottom
    {
        top,
        bottom,
    }

    [System.SerializableAttribute()]
    public class arpeggiate
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public updown direction;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "up-down")]
    public enum updown
    {
        up,
        down
    }

    [System.SerializableAttribute()]
    public class caesura
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public caesuravalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "caesura-value")]
    public enum caesuravalue
    {
        normal,
        thick,
        @short,
        curved,
        single,
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "breath-mark")]
    public class breathmark
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public breathmarkvalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "breath-mark-value")]
    public enum breathmarkvalue
    {
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        comma,
        tick,
        upbow,
        salzedo
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-line")]
    public class emptyline
    {

        [System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
        public lineshape lineshape;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineshapeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("line-length")]
        public linelength linelength;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linelengthSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-shape")]
    public enum lineshape
    {
        straight,
        curved,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-length")]
    public enum linelength
    {
        @short,
        medium,
        @long,
    }

    [System.SerializableAttribute()]
    public class articulations
    {

        [System.Xml.Serialization.XmlElementAttribute("accent", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("breath-mark", typeof(breathmark))]
        [System.Xml.Serialization.XmlElementAttribute("caesura", typeof(caesura))]
        [System.Xml.Serialization.XmlElementAttribute("detached-legato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("doit", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("falloff", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("other-articulation", typeof(otherplacementtext))]
        [System.Xml.Serialization.XmlElementAttribute("plop", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("scoop", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("soft-accent", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("spiccato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("staccatissimo", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("staccato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("stress", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("strong-accent", typeof(strongaccent))]
        [System.Xml.Serialization.XmlElementAttribute("tenuto", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("unstress", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(strongaccent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(heeltoe))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-placement")]
    public class emptyplacement
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "strong-accent")]
    public class strongaccent : emptyplacement
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(updown.up)]
        public updown type;

        public strongaccent()
        {
            this.type = updown.up;
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "heel-toe")]
    public class heeltoe : emptyplacement
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno substitution;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool substitutionSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-placement-text")]
    public class otherplacementtext
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        accent,

        [System.Xml.Serialization.XmlEnumAttribute("breath-mark")]
        breathmark,

        caesura,

        [System.Xml.Serialization.XmlEnumAttribute("detached-legato")]
        detachedlegato,

        doit,

        falloff,

        [System.Xml.Serialization.XmlEnumAttribute("other-articulation")]
        otherarticulation,

        plop,

        scoop,

        [System.Xml.Serialization.XmlEnumAttribute("soft-accent")]
        softaccent,

        spiccato,

        staccatissimo,

        staccato,

        stress,

        [System.Xml.Serialization.XmlEnumAttribute("strong-accent")]
        strongaccent,

        tenuto,

        unstress,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmon-closed")]
    public class harmonclosed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public harmonclosedlocation location;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public harmonclosedvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmon-closed-location")]
    public enum harmonclosedlocation
    {

        /// <remarks/>
        right,

        /// <remarks/>
        bottom,

        /// <remarks/>
        left,

        /// <remarks/>
        top,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmon-closed-value")]
    public enum harmonclosedvalue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,

        /// <remarks/>
        half,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmon-mute")]
    public class harmonmute
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("harmon-closed")]
        public harmonclosed harmonclosed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class handbell
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public handbellvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "handbell-value")]
    public enum handbellvalue
    {

        /// <remarks/>
        belltree,

        /// <remarks/>
        damp,

        /// <remarks/>
        echo,

        /// <remarks/>
        gyro,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("hand martellato")]
        handmartellato,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("mallet lift")]
        malletlift,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("mallet table")]
        mallettable,

        /// <remarks/>
        martellato,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("martellato lift")]
        martellatolift,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("muted martellato")]
        mutedmartellato,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pluck lift")]
        plucklift,

        /// <remarks/>
        swing,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class arrow
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arrow-direction", typeof(arrowdirection))]
        [System.Xml.Serialization.XmlElementAttribute("arrow-style", typeof(arrowstyle))]
        [System.Xml.Serialization.XmlElementAttribute("arrowhead", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("circular-arrow", typeof(circulararrow))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "arrow-direction")]
    public enum arrowdirection
    {

        /// <remarks/>
        left,

        /// <remarks/>
        up,

        /// <remarks/>
        right,

        /// <remarks/>
        down,

        /// <remarks/>
        northwest,

        /// <remarks/>
        northeast,

        /// <remarks/>
        southeast,

        /// <remarks/>
        southwest,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("left right")]
        leftright,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("up down")]
        updown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("northwest southeast")]
        northwestsoutheast,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("northeast southwest")]
        northeastsouthwest,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "arrow-style")]
    public enum arrowstyle
    {

        /// <remarks/>
        single,

        /// <remarks/>
        @double,

        /// <remarks/>
        filled,

        /// <remarks/>
        hollow,

        /// <remarks/>
        paired,

        /// <remarks/>
        combined,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "circular-arrow")]
    public enum circulararrow
    {

        /// <remarks/>
        clockwise,

        /// <remarks/>
        anticlockwise,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "hole-closed")]
    public class holeclosed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public holeclosedlocation location;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public holeclosedvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "hole-closed-location")]
    public enum holeclosedlocation
    {

        /// <remarks/>
        right,

        /// <remarks/>
        bottom,

        /// <remarks/>
        left,

        /// <remarks/>
        top,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "hole-closed-value")]
    public enum holeclosedvalue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,

        /// <remarks/>
        half,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class hole
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-type")]
        public string holetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-closed")]
        public holeclosed holeclosed;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-shape")]
        public string holeshape;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class tap
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public taphand hand;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tap-hand")]
    public enum taphand
    {

        /// <remarks/>
        left,

        /// <remarks/>
        right,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class bend
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bend-alter")]
        public decimal bendalter;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pre-bend", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("release", typeof(empty))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public empty Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("with-bar")]
        public placementtext withbar;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("first-beat")]
        public decimal firstbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pre-bend")]
        prebend,

        /// <remarks/>
        release,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "placement-text")]
    public class placementtext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "hammer-on-pull-off")]
    public class hammeronpulloff
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public hammeronpulloff()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-placement-smufl")]
    public class emptyplacementsmufl
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class harmonic
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artificial", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("natural", typeof(empty))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public empty Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("base-pitch", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sounding-pitch", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("touching-pitch", typeof(empty))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public empty Item1;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        artificial,

        /// <remarks/>
        natural,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("base-pitch")]
        basepitch,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sounding-pitch")]
        soundingpitch,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("touching-pitch")]
        touchingpitch,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class technical
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arrow", typeof(arrow))]
        [System.Xml.Serialization.XmlElementAttribute("bend", typeof(bend))]
        [System.Xml.Serialization.XmlElementAttribute("brass-bend", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("double-tongue", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("down-bow", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("fingering", typeof(fingering))]
        [System.Xml.Serialization.XmlElementAttribute("fingernails", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("flip", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("fret", typeof(fret))]
        [System.Xml.Serialization.XmlElementAttribute("golpe", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("half-muted", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("hammer-on", typeof(hammeronpulloff))]
        [System.Xml.Serialization.XmlElementAttribute("handbell", typeof(handbell))]
        [System.Xml.Serialization.XmlElementAttribute("harmon-mute", typeof(harmonmute))]
        [System.Xml.Serialization.XmlElementAttribute("harmonic", typeof(harmonic))]
        [System.Xml.Serialization.XmlElementAttribute("heel", typeof(heeltoe))]
        [System.Xml.Serialization.XmlElementAttribute("hole", typeof(hole))]
        [System.Xml.Serialization.XmlElementAttribute("open", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("open-string", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("other-technical", typeof(otherplacementtext))]
        [System.Xml.Serialization.XmlElementAttribute("pluck", typeof(placementtext))]
        [System.Xml.Serialization.XmlElementAttribute("pull-off", typeof(hammeronpulloff))]
        [System.Xml.Serialization.XmlElementAttribute("smear", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("snap-pizzicato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("stopped", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("string", typeof(@string))]
        [System.Xml.Serialization.XmlElementAttribute("tap", typeof(tap))]
        [System.Xml.Serialization.XmlElementAttribute("thumb-position", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("toe", typeof(heeltoe))]
        [System.Xml.Serialization.XmlElementAttribute("triple-tongue", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("up-bow", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        arrow,

        /// <remarks/>
        bend,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("brass-bend")]
        brassbend,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-tongue")]
        doubletongue,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("down-bow")]
        downbow,

        /// <remarks/>
        fingering,

        /// <remarks/>
        fingernails,

        /// <remarks/>
        flip,

        /// <remarks/>
        fret,

        /// <remarks/>
        golpe,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("half-muted")]
        halfmuted,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("hammer-on")]
        hammeron,

        /// <remarks/>
        handbell,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("harmon-mute")]
        harmonmute,

        /// <remarks/>
        harmonic,

        /// <remarks/>
        heel,

        /// <remarks/>
        hole,

        /// <remarks/>
        open,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("open-string")]
        openstring,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("other-technical")]
        othertechnical,

        /// <remarks/>
        pluck,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pull-off")]
        pulloff,

        /// <remarks/>
        smear,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("snap-pizzicato")]
        snappizzicato,

        /// <remarks/>
        stopped,

        /// <remarks/>
        @string,

        /// <remarks/>
        tap,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("thumb-position")]
        thumbposition,

        /// <remarks/>
        toe,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("triple-tongue")]
        tripletongue,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("up-bow")]
        upbow,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-mark")]
    public class accidentalmark
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class tremolo
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(tremolotype.single)]
        public tremolotype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value;

        public tremolo()
        {
            this.type = tremolotype.single;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tremolo-type")]
    public enum tremolotype
    {

        /// <remarks/>
        start,

        /// <remarks/>
        stop,

        /// <remarks/>
        single,

        /// <remarks/>
        unmeasured,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "horizontal-turn")]
    public class horizontalturn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("start-note")]
        public startnote startnote;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startnoteSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("trill-step")]
        public trillstep trillstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trillstepSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("two-note-turn")]
        public twonoteturn twonoteturn;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool twonoteturnSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("second-beat")]
        public decimal secondbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno slash;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slashSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(mordent))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-trill-sound")]
    public class emptytrillsound
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("start-note")]
        public startnote startnote;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startnoteSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("trill-step")]
        public trillstep trillstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trillstepSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("two-note-turn")]
        public twonoteturn twonoteturn;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool twonoteturnSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("second-beat")]
        public decimal secondbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class mordent : emptytrillsound
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno @long;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow approach;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approachSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow departure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool departureSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class ornaments
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delayed-inverted-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("delayed-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("haydn", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("inverted-mordent", typeof(mordent))]
        [System.Xml.Serialization.XmlElementAttribute("inverted-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("inverted-vertical-turn", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("mordent", typeof(mordent))]
        [System.Xml.Serialization.XmlElementAttribute("other-ornament", typeof(otherplacementtext))]
        [System.Xml.Serialization.XmlElementAttribute("schleifer", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("shake", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("tremolo", typeof(tremolo))]
        [System.Xml.Serialization.XmlElementAttribute("trill-mark", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("vertical-turn", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("wavy-line", typeof(wavyline))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accidental-mark")]
        public accidentalmark[] accidentalmark;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("delayed-inverted-turn")]
        delayedinvertedturn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("delayed-turn")]
        delayedturn,

        /// <remarks/>
        haydn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("inverted-mordent")]
        invertedmordent,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("inverted-turn")]
        invertedturn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("inverted-vertical-turn")]
        invertedverticalturn,

        /// <remarks/>
        mordent,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("other-ornament")]
        otherornament,

        /// <remarks/>
        schleifer,

        /// <remarks/>
        shake,

        /// <remarks/>
        tremolo,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("trill-mark")]
        trillmark,

        /// <remarks/>
        turn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("vertical-turn")]
        verticalturn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wavy-line")]
        wavyline,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class slide
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("first-beat")]
        public decimal firstbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public slide()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class glissando
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public glissando()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-dot")]
    public class tupletdot
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-type")]
    public class tuplettype
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public notetypevalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-number")]
    public class tupletnumber
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-portion")]
    public class tupletportion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-number")]
        public tupletnumber tupletnumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-type")]
        public tuplettype tuplettype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-dot")]
        public tupletdot[] tupletdot;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class tuplet
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-actual")]
        public tupletportion tupletactual;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-normal")]
        public tupletportion tupletnormal;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show-number")]
        public showtuplet shownumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shownumberSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show-type")]
        public showtuplet showtype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showtypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
        public lineshape lineshape;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineshapeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class slur
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public overunder orientation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orientationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x")]
        public decimal bezierx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y")]
        public decimal beziery;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x2")]
        public decimal bezierx2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierx2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y2")]
        public decimal beziery2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beziery2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset")]
        public decimal bezieroffset;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffsetSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset2")]
        public decimal bezieroffset2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffset2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        public slur()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "over-under")]
    public enum overunder
    {

        /// <remarks/>
        over,

        /// <remarks/>
        under,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class tied
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public tiedtype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public overunder orientation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orientationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x")]
        public decimal bezierx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y")]
        public decimal beziery;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x2")]
        public decimal bezierx2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierx2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y2")]
        public decimal beziery2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beziery2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset")]
        public decimal bezieroffset;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffsetSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset2")]
        public decimal bezieroffset2;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffset2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tied-type")]
    public enum tiedtype
    {

        /// <remarks/>
        start,

        /// <remarks/>
        stop,

        /// <remarks/>
        @continue,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("let-ring")]
        letring,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class notations
    {

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accidental-mark", typeof(accidentalmark))]
        [System.Xml.Serialization.XmlElementAttribute("arpeggiate", typeof(arpeggiate))]
        [System.Xml.Serialization.XmlElementAttribute("articulations", typeof(articulations))]
        [System.Xml.Serialization.XmlElementAttribute("dynamics", typeof(dynamics))]
        [System.Xml.Serialization.XmlElementAttribute("fermata", typeof(fermata))]
        [System.Xml.Serialization.XmlElementAttribute("glissando", typeof(glissando))]
        [System.Xml.Serialization.XmlElementAttribute("non-arpeggiate", typeof(nonarpeggiate))]
        [System.Xml.Serialization.XmlElementAttribute("ornaments", typeof(ornaments))]
        [System.Xml.Serialization.XmlElementAttribute("other-notation", typeof(othernotation))]
        [System.Xml.Serialization.XmlElementAttribute("slide", typeof(slide))]
        [System.Xml.Serialization.XmlElementAttribute("slur", typeof(slur))]
        [System.Xml.Serialization.XmlElementAttribute("technical", typeof(technical))]
        [System.Xml.Serialization.XmlElementAttribute("tied", typeof(tied))]
        [System.Xml.Serialization.XmlElementAttribute("tuplet", typeof(tuplet))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class beam
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno repeater;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool repeaterSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public fan fan;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fanSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public beamvalue Value;

        public beam()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum fan
    {

        /// <remarks/>
        accel,

        /// <remarks/>
        rit,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "notehead-text")]
    public class noteheadtext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accidental-text", typeof(accidentaltext))]
        [System.Xml.Serialization.XmlElementAttribute("display-text", typeof(formattedtext))]
        public object[] Items;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class notehead
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno filled;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filledSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public noteheadvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "notehead-value")]
    public enum noteheadvalue
    {

        /// <remarks/>
        slash,

        /// <remarks/>
        triangle,

        /// <remarks/>
        diamond,

        /// <remarks/>
        square,

        /// <remarks/>
        cross,

        /// <remarks/>
        x,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("circle-x")]
        circlex,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("inverted triangle")]
        invertedtriangle,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("arrow down")]
        arrowdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("arrow up")]
        arrowup,

        /// <remarks/>
        circled,

        /// <remarks/>
        slashed,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("back slashed")]
        backslashed,

        /// <remarks/>
        normal,

        /// <remarks/>
        cluster,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("circle dot")]
        circledot,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("left triangle")]
        lefttriangle,

        /// <remarks/>
        rectangle,

        /// <remarks/>
        none,

        /// <remarks/>
        @do,

        /// <remarks/>
        re,

        /// <remarks/>
        mi,

        /// <remarks/>
        fa,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("fa up")]
        faup,

        /// <remarks/>
        so,

        /// <remarks/>
        la,

        /// <remarks/>
        ti,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class stem
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public stemvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stem-value")]
    public enum stemvalue
    {

        /// <remarks/>
        down,

        /// <remarks/>
        up,

        /// <remarks/>
        @double,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class accidental
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno cautionary;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cautionarySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno editorial;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool editorialSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-type")]
    public class notetype
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public notetypevalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class instrument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class tie
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;
    }

//- direction classes ---------------------------------------------------------

    [System.SerializableAttribute()]
    public class direction
    {
        [System.Xml.Serialization.XmlElementAttribute("direction-type")]
        public directiontype[] directiontype;
        public offset offset;
        public formattedtext footnote;
        public level level;
        public string voice;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;
        public sound sound;
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno directive;
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directiveSpecified;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-direction")]
    public class otherdirection
    {
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-divide")]
    public class staffdivide
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public staffdividesymbol type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-divide-symbol")]
    public enum staffdividesymbol
    {

        down,

        up,

        [System.Xml.Serialization.XmlEnumAttribute("up-down")]
        updown,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accordion-registration")]
    public class accordionregistration
    {

        [System.Xml.Serialization.XmlElementAttribute("accordion-high")]
        public empty accordionhigh;

        [System.Xml.Serialization.XmlElementAttribute("accordion-middle", DataType = "positiveInteger")]
        public string accordionmiddle;

        [System.Xml.Serialization.XmlElementAttribute("accordion-low")]
        public empty accordionlow;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    public class stick
    {

        [System.Xml.Serialization.XmlElementAttribute("stick-type")]
        public sticktype sticktype;

        [System.Xml.Serialization.XmlElementAttribute("stick-material")]
        public stickmaterial stickmaterial;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public tipdirection tip;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("dashed-circle")]
        public yesno dashedcircle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashedcircleSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stick-type")]
    public enum sticktype
    {
        [System.Xml.Serialization.XmlEnumAttribute("bass drum")]
        bassdrum,
        [System.Xml.Serialization.XmlEnumAttribute("double bass drum")]
        doublebassdrum,
        glockenspiel,
        gum,
        hammer,
        superball,
        timpani,
        wound,
        xylophone,
        yarn
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stick-material")]
    public enum stickmaterial
    {
        soft,
        medium,
        hard,
        shaded,
        x
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tip-direction")]
    public enum tipdirection
    {

        /// <remarks/>
        up,

        /// <remarks/>
        down,

        /// <remarks/>
        left,

        /// <remarks/>
        right,

        /// <remarks/>
        northwest,

        /// <remarks/>
        northeast,

        /// <remarks/>
        southeast,

        /// <remarks/>
        southwest,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class beater
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public tipdirection tip;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public beatervalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beater-value")]
    public enum beatervalue
    {

        /// <remarks/>
        bow,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("chime hammer")]
        chimehammer,

        /// <remarks/>
        coin,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drum stick")]
        drumstick,

        /// <remarks/>
        finger,

        /// <remarks/>
        fingernail,

        /// <remarks/>
        fist,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("guiro scraper")]
        guiroscraper,

        /// <remarks/>
        hammer,

        /// <remarks/>
        hand,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("jazz stick")]
        jazzstick,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("knitting needle")]
        knittingneedle,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("metal hammer")]
        metalhammer,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slide brush on gong")]
        slidebrushongong,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("snare stick")]
        snarestick,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("spoon mallet")]
        spoonmallet,

        /// <remarks/>
        superball,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("triangle beater")]
        trianglebeater,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("triangle beater plain")]
        trianglebeaterplain,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wire brush")]
        wirebrush,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class pitched
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public pitchedvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "pitched-value")]
    public enum pitchedvalue
    {

        /// <remarks/>
        celesta,

        /// <remarks/>
        chimes,

        /// <remarks/>
        glockenspiel,

        /// <remarks/>
        lithophone,

        /// <remarks/>
        mallet,

        /// <remarks/>
        marimba,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("steel drums")]
        steeldrums,

        /// <remarks/>
        tubaphone,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("tubular chimes")]
        tubularchimes,

        /// <remarks/>
        vibraphone,

        /// <remarks/>
        xylophone,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class glass
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public glassvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "glass-value")]
    public enum glassvalue
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("glass harmonica")]
        glassharmonica,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("glass harp")]
        glassharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wind chimes")]
        windchimes,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class percussion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beater", typeof(beater))]
        [System.Xml.Serialization.XmlElementAttribute("effect", typeof(effect))]
        [System.Xml.Serialization.XmlElementAttribute("glass", typeof(glass))]
        [System.Xml.Serialization.XmlElementAttribute("membrane", typeof(membrane))]
        [System.Xml.Serialization.XmlElementAttribute("metal", typeof(metal))]
        [System.Xml.Serialization.XmlElementAttribute("other-percussion", typeof(othertext))]
        [System.Xml.Serialization.XmlElementAttribute("pitched", typeof(pitched))]
        [System.Xml.Serialization.XmlElementAttribute("stick", typeof(stick))]
        [System.Xml.Serialization.XmlElementAttribute("stick-location", typeof(sticklocation))]
        [System.Xml.Serialization.XmlElementAttribute("timpani", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("wood", typeof(wood))]
        public object Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public enclosureshape enclosure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enclosureSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum effect
    {

        /// <remarks/>
        anvil,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("auto horn")]
        autohorn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bird whistle")]
        birdwhistle,

        /// <remarks/>
        cannon,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("duck call")]
        duckcall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("gun shot")]
        gunshot,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("klaxon horn")]
        klaxonhorn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lions roar")]
        lionsroar,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lotus flute")]
        lotusflute,

        /// <remarks/>
        megaphone,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("police whistle")]
        policewhistle,

        /// <remarks/>
        siren,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slide whistle")]
        slidewhistle,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("thunder sheet")]
        thundersheet,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wind machine")]
        windmachine,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wind whistle")]
        windwhistle,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum membrane
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bass drum")]
        bassdrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bass drum on side")]
        bassdrumonside,

        /// <remarks/>
        bongos,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chinese tomtom")]
        Chinesetomtom,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("conga drum")]
        congadrum,

        /// <remarks/>
        cuica,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("goblet drum")]
        gobletdrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Indo-American tomtom")]
        IndoAmericantomtom,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Japanese tomtom")]
        Japanesetomtom,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("military drum")]
        militarydrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("snare drum")]
        snaredrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("snare drum snares off")]
        snaredrumsnaresoff,

        /// <remarks/>
        tabla,

        /// <remarks/>
        tambourine,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("tenor drum")]
        tenordrum,

        /// <remarks/>
        timbales,

        /// <remarks/>
        tomtom,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum metal
    {

        /// <remarks/>
        agogo,

        /// <remarks/>
        almglocken,

        /// <remarks/>
        bell,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bell plate")]
        bellplate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bell tree")]
        belltree,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("brake drum")]
        brakedrum,

        /// <remarks/>
        cencerro,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("chain rattle")]
        chainrattle,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chinese cymbal")]
        Chinesecymbal,

        /// <remarks/>
        cowbell,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("crash cymbals")]
        crashcymbals,

        /// <remarks/>
        crotale,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cymbal tongs")]
        cymbaltongs,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("domed gong")]
        domedgong,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("finger cymbals")]
        fingercymbals,

        /// <remarks/>
        flexatone,

        /// <remarks/>
        gong,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("hi-hat")]
        hihat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("high-hat cymbals")]
        highhatcymbals,

        /// <remarks/>
        handbell,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("jaw harp")]
        jawharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("jingle bells")]
        jinglebells,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("musical saw")]
        musicalsaw,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("shell bells")]
        shellbells,

        /// <remarks/>
        sistrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sizzle cymbal")]
        sizzlecymbal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sleigh bells")]
        sleighbells,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("suspended cymbal")]
        suspendedcymbal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("tam tam")]
        tamtam,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("tam tam with beater")]
        tamtamwithbeater,

        /// <remarks/>
        triangle,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Vietnamese hat")]
        Vietnamesehat,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-text")]
    public class othertext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stick-location")]
    public enum sticklocation
    {

        /// <remarks/>
        center,

        /// <remarks/>
        rim,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cymbal bell")]
        cymbalbell,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cymbal edge")]
        cymbaledge,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum wood
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bamboo scraper")]
        bambooscraper,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("board clapper")]
        boardclapper,

        /// <remarks/>
        cabasa,

        /// <remarks/>
        castanets,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("castanets with handle")]
        castanetswithhandle,

        /// <remarks/>
        claves,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("football rattle")]
        footballrattle,

        /// <remarks/>
        guiro,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("log drum")]
        logdrum,

        /// <remarks/>
        maraca,

        /// <remarks/>
        maracas,

        /// <remarks/>
        quijada,

        /// <remarks/>
        rainstick,

        /// <remarks/>
        ratchet,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("reco-reco")]
        recoreco,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sandpaper blocks")]
        sandpaperblocks,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slit drum")]
        slitdrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("temple block")]
        templeblock,

        /// <remarks/>
        vibraslap,

        /// <remarks/>
        whip,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("wood block")]
        woodblock,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "enclosure-shape")]
    public enum enclosureshape
    {

        /// <remarks/>
        rectangle,

        /// <remarks/>
        square,

        /// <remarks/>
        oval,

        /// <remarks/>
        circle,

        /// <remarks/>
        bracket,

        /// <remarks/>
        triangle,

        /// <remarks/>
        diamond,

        /// <remarks/>
        pentagon,

        /// <remarks/>
        hexagon,

        /// <remarks/>
        heptagon,

        /// <remarks/>
        octagon,

        /// <remarks/>
        nonagon,

        /// <remarks/>
        decagon,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "principal-voice")]
    public class principalvoice
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public principalvoicesymbol symbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "principal-voice-symbol")]
    public enum principalvoicesymbol
    {

        /// <remarks/>
        Hauptstimme,

        /// <remarks/>
        Nebenstimme,

        /// <remarks/>
        plain,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class accord
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuning-step")]
        public step tuningstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuning-alter")]
        public decimal tuningalter;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tuningalterSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuning-octave", DataType = "integer")]
        public string tuningoctave;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string @string;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class scordatura
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accord")]
        public accord[] accord;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "string-mute")]
    public class stringmute
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public onoff type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "on-off")]
    public enum onoff
    {

        /// <remarks/>
        on,

        /// <remarks/>
        off,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-print-style-align-id")]
    public class emptyprintstylealignid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "pedal-tuning")]
    public class pedaltuning
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-step")]
        public step pedalstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-alter")]
        public decimal pedalalter;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harp-pedals")]
    public class harppedals
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-tuning")]
        public pedaltuning[] pedaltuning;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "octave-shift")]
    public class octaveshift
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public updownstopcontinue type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("8")]
        public string size;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        public octaveshift()
        {
            this.size = "8";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "up-down-stop-continue")]
    public enum updownstopcontinue
    {

        /// <remarks/>
        up,

        /// <remarks/>
        down,

        /// <remarks/>
        stop,

        /// <remarks/>
        @continue,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-tied")]
    public class metronometied
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-beam")]
    public class metronomebeam
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public beamvalue Value;

        public metronomebeam()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beam-value")]
    public enum beamvalue
    {

        /// <remarks/>
        begin,

        /// <remarks/>
        @continue,

        /// <remarks/>
        end,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("forward hook")]
        forwardhook,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("backward hook")]
        backwardhook,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-note")]
    public class metronomenote
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-type")]
        public notetypevalue metronometype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-dot")]
        public empty[] metronomedot;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-beam")]
        public metronomebeam[] metronomebeam;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-tied")]
        public metronometied metronometied;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-tuplet")]
        public metronometuplet metronometuplet;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-tuplet")]
    public class metronometuplet : timemodification
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show-number")]
        public showtuplet shownumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shownumberSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "show-tuplet")]
    public enum showtuplet
    {

        /// <remarks/>
        actual,

        /// <remarks/>
        both,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(metronometuplet))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "time-modification")]
    public class timemodification
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actual-notes", DataType = "nonNegativeInteger")]
        public string actualnotes;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-notes", DataType = "nonNegativeInteger")]
        public string normalnotes;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-type")]
        public notetypevalue normaltype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-dot")]
        public empty[] normaldot;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "per-minute")]
    public class perminute
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beat-unit-tied")]
    public class beatunittied
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-unit")]
        public notetypevalue beatunit;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-unit-dot")]
        public empty[] beatunitdot;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class metronome
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-unit", typeof(notetypevalue))]
        [System.Xml.Serialization.XmlElementAttribute("beat-unit-dot", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("beat-unit-tied", typeof(beatunittied))]
        [System.Xml.Serialization.XmlElementAttribute("metronome-arrows", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("metronome-note", typeof(metronomenote))]
        [System.Xml.Serialization.XmlElementAttribute("metronome-relation", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("per-minute", typeof(perminute))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType7[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright justify;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool justifySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType7
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("beat-unit")]
        beatunit,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("beat-unit-dot")]
        beatunitdot,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("beat-unit-tied")]
        beatunittied,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("metronome-arrows")]
        metronomearrows,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("metronome-note")]
        metronomenote,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("metronome-relation")]
        metronomerelation,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("per-minute")]
        perminute,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class pedal
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public pedaltype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno line;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno sign;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool signSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno abbreviated;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abbreviatedSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "pedal-type")]
    public enum pedaltype
    {

        /// <remarks/>
        start,

        /// <remarks/>
        stop,

        /// <remarks/>
        sostenuto,

        /// <remarks/>
        change,

        /// <remarks/>
        @continue,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class bracket
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-end")]
        public lineend lineend;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("end-length")]
        public decimal endlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-end")]
    public enum lineend
    {

        /// <remarks/>
        up,

        /// <remarks/>
        down,

        /// <remarks/>
        both,

        /// <remarks/>
        arrow,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-type")]
    public enum linetype
    {

        /// <remarks/>
        solid,

        /// <remarks/>
        dashed,

        /// <remarks/>
        dotted,

        /// <remarks/>
        wavy,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class dashes
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class wedge
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public wedgetype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal spread;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spreadSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno niente;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nienteSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "wedge-type")]
    public enum wedgetype
    {

        /// <remarks/>
        crescendo,

        /// <remarks/>
        diminuendo,

        /// <remarks/>
        stop,

        /// <remarks/>
        @continue,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "direction-type")]
    public class directiontype
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-registration", typeof(accordionregistration))]
        [System.Xml.Serialization.XmlElementAttribute("bracket", typeof(bracket))]
        [System.Xml.Serialization.XmlElementAttribute("coda", typeof(coda))]
        [System.Xml.Serialization.XmlElementAttribute("damp", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("damp-all", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("dashes", typeof(dashes))]
        [System.Xml.Serialization.XmlElementAttribute("dynamics", typeof(dynamics))]
        [System.Xml.Serialization.XmlElementAttribute("eyeglasses", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("harp-pedals", typeof(harppedals))]
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(image))]
        [System.Xml.Serialization.XmlElementAttribute("metronome", typeof(metronome))]
        [System.Xml.Serialization.XmlElementAttribute("octave-shift", typeof(octaveshift))]
        [System.Xml.Serialization.XmlElementAttribute("other-direction", typeof(otherdirection))]
        [System.Xml.Serialization.XmlElementAttribute("pedal", typeof(pedal))]
        [System.Xml.Serialization.XmlElementAttribute("percussion", typeof(percussion))]
        [System.Xml.Serialization.XmlElementAttribute("principal-voice", typeof(principalvoice))]
        [System.Xml.Serialization.XmlElementAttribute("rehearsal", typeof(formattedtextid))]
        [System.Xml.Serialization.XmlElementAttribute("scordatura", typeof(scordatura))]
        [System.Xml.Serialization.XmlElementAttribute("segno", typeof(segno))]
        [System.Xml.Serialization.XmlElementAttribute("staff-divide", typeof(staffdivide))]
        [System.Xml.Serialization.XmlElementAttribute("string-mute", typeof(stringmute))]
        [System.Xml.Serialization.XmlElementAttribute("symbol", typeof(formattedsymbolid))]
        [System.Xml.Serialization.XmlElementAttribute("wedge", typeof(wedge))]
        [System.Xml.Serialization.XmlElementAttribute("words", typeof(formattedtextid))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType8[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class dynamics
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("f", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("ff", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("fff", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("ffff", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("fffff", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("ffffff", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("fp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("fz", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("mf", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("mp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("n", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("other-dynamics", typeof(othertext))]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("pf", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("pp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("ppp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("pppp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("ppppp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("pppppp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("rf", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("rfz", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sf", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sffz", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sfp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sfpp", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sfz", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("sfzp", typeof(empty))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string underline;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string overline;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-through", DataType = "nonNegativeInteger")]
        public string linethrough;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public enclosureshape enclosure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enclosureSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {

        /// <remarks/>
        f,

        /// <remarks/>
        ff,

        /// <remarks/>
        fff,

        /// <remarks/>
        ffff,

        /// <remarks/>
        fffff,

        /// <remarks/>
        ffffff,

        /// <remarks/>
        fp,

        /// <remarks/>
        fz,

        /// <remarks/>
        mf,

        /// <remarks/>
        mp,

        /// <remarks/>
        n,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("other-dynamics")]
        otherdynamics,

        /// <remarks/>
        p,

        /// <remarks/>
        pf,

        /// <remarks/>
        pp,

        /// <remarks/>
        ppp,

        /// <remarks/>
        pppp,

        /// <remarks/>
        ppppp,

        /// <remarks/>
        pppppp,

        /// <remarks/>
        rf,

        /// <remarks/>
        rfz,

        /// <remarks/>
        sf,

        /// <remarks/>
        sffz,

        /// <remarks/>
        sfp,

        /// <remarks/>
        sfpp,

        /// <remarks/>
        sfz,

        /// <remarks/>
        sfzp,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class image
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string source;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "formatted-text-id")]
    public class formattedtextid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "formatted-symbol-id")]
    public class formattedsymbolid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "NMTOKEN")]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType8
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("accordion-registration")]
        accordionregistration,

        /// <remarks/>
        bracket,

        /// <remarks/>
        coda,

        /// <remarks/>
        damp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("damp-all")]
        dampall,

        /// <remarks/>
        dashes,

        /// <remarks/>
        dynamics,

        /// <remarks/>
        eyeglasses,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("harp-pedals")]
        harppedals,

        /// <remarks/>
        image,

        /// <remarks/>
        metronome,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("octave-shift")]
        octaveshift,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("other-direction")]
        otherdirection,

        /// <remarks/>
        pedal,

        /// <remarks/>
        percussion,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("principal-voice")]
        principalvoice,

        /// <remarks/>
        rehearsal,

        /// <remarks/>
        scordatura,

        /// <remarks/>
        segno,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("staff-divide")]
        staffdivide,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("string-mute")]
        stringmute,

        /// <remarks/>
        symbol,

        /// <remarks/>
        wedge,

        /// <remarks/>
        words,
    }

//- attribute classes ---------------------------------------------------------

    [System.SerializableAttribute()]
    public class slash
    {

        [System.Xml.Serialization.XmlElementAttribute("slash-type")]
        public notetypevalue slashtype;

        [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
        public empty[] slashdot;

        [System.Xml.Serialization.XmlElementAttribute("except-voice")]
        public string[] exceptvoice;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
        public yesno usedots;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedotsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("use-stems")]
        public yesno usestems;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usestemsSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-type-value")]
    public enum notetypevalue
    {
        [System.Xml.Serialization.XmlEnumAttribute("1024th")]
        Item1024th,
        [System.Xml.Serialization.XmlEnumAttribute("512th")]
        Item512th,
        [System.Xml.Serialization.XmlEnumAttribute("256th")]
        Item256th,
        [System.Xml.Serialization.XmlEnumAttribute("128th")]
        Item128th,
        [System.Xml.Serialization.XmlEnumAttribute("64th")]
        Item64th,
        [System.Xml.Serialization.XmlEnumAttribute("32nd")]
        Item32nd,
        [System.Xml.Serialization.XmlEnumAttribute("16th")]
        Item16th,
        eighth,
        quarter,
        half,
        whole,
        breve,
        @long,
        maxima,
    }

    [System.SerializableAttribute()]
    public class empty
    {
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beat-repeat")]
    public class beatrepeat
    {

        [System.Xml.Serialization.XmlElementAttribute("slash-type")]
        public notetypevalue slashtype;

        [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
        public empty[] slashdot;

        [System.Xml.Serialization.XmlElementAttribute("except-voice")]
        public string[] exceptvoice;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string slashes;

        [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
        public yesno usedots;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedotsSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-repeat")]
    public class measurerepeat
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string slashes;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "multiple-rest")]
    public class multiplerest
    {

        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public yesno usesymbols;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usesymbolsSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-style")]
    public class measurestyle
    {

        [System.Xml.Serialization.XmlElementAttribute("beat-repeat", typeof(beatrepeat))]
        [System.Xml.Serialization.XmlElementAttribute("measure-repeat", typeof(measurerepeat))]
        [System.Xml.Serialization.XmlElementAttribute("multiple-rest", typeof(multiplerest))]
        [System.Xml.Serialization.XmlElementAttribute("slash", typeof(slash))]
        public object Item;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    public class transpose
    {

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string diatonic;

        public decimal chromatic;

        [System.Xml.Serialization.XmlElementAttribute("octave-change", DataType = "integer")]
        public string octavechange;

        public empty @double;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-tuning")]
    public class stafftuning
    {

        [System.Xml.Serialization.XmlElementAttribute("tuning-step")]
        public step tuningstep;

        [System.Xml.Serialization.XmlElementAttribute("tuning-alter")]
        public decimal tuningalter;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tuningalterSpecified;

        [System.Xml.Serialization.XmlElementAttribute("tuning-octave", DataType = "integer")]
        public string tuningoctave;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string line;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-details")]
    public class staffdetails
    {

        [System.Xml.Serialization.XmlElementAttribute("staff-type")]
        public stafftype stafftype;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stafftypeSpecified;

        [System.Xml.Serialization.XmlElementAttribute("staff-lines", DataType = "nonNegativeInteger")]
        public string stafflines;

        [System.Xml.Serialization.XmlElementAttribute("staff-tuning")]
        public stafftuning[] stafftuning;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string capo;

        [System.Xml.Serialization.XmlElementAttribute("staff-size")]
        public decimal staffsize;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffsizeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("show-frets")]
        public showfrets showfrets;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showfretsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("print-spacing")]
        public yesno printspacing;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printspacingSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-type")]
    public enum stafftype
    {
        ossia,
        cue,
        editorial,
        regular,
        alternate
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "show-frets")]
    public enum showfrets
    {

        /// <remarks/>
        numbers,

        /// <remarks/>
        letters,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class clef
    {

        /// <remarks/>
        public clefsign sign;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string line;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clef-octave-change", DataType = "integer")]
        public string clefoctavechange;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno additional;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool additionalSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("after-barline")]
        public yesno afterbarline;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool afterbarlineSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "clef-sign")]
    public enum clefsign
    {

        /// <remarks/>
        G,

        /// <remarks/>
        F,

        /// <remarks/>
        C,

        /// <remarks/>
        percussion,

        /// <remarks/>
        TAB,

        /// <remarks/>
        jianpu,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-symbol")]
    public class partsymbol
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("top-staff", DataType = "positiveInteger")]
        public string topstaff;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bottom-staff", DataType = "positiveInteger")]
        public string bottomstaff;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public groupsymbolvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-symbol-value")]
    public enum groupsymbolvalue
    {

        /// <remarks/>
        none,

        /// <remarks/>
        brace,

        /// <remarks/>
        line,

        /// <remarks/>
        bracket,

        /// <remarks/>
        square,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class interchangeable
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-relation")]
        public timerelation timerelation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timerelationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beats")]
        public string[] beats;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-type")]
        public string[] beattype;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public timesymbol symbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public timeseparator separator;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool separatorSpecified;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "time-relation")]
    public enum timerelation
    {

        /// <remarks/>
        parentheses,

        /// <remarks/>
        bracket,

        /// <remarks/>
        equals,

        /// <remarks/>
        slash,

        /// <remarks/>
        space,

        /// <remarks/>
        hyphen,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "time-symbol")]
    public enum timesymbol
    {

        /// <remarks/>
        common,

        /// <remarks/>
        cut,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("single-number")]
        singlenumber,

        /// <remarks/>
        note,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("dotted-note")]
        dottednote,

        /// <remarks/>
        normal,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "time-separator")]
    public enum timeseparator
    {

        /// <remarks/>
        none,

        /// <remarks/>
        horizontal,

        /// <remarks/>
        diagonal,

        /// <remarks/>
        vertical,

        /// <remarks/>
        adjacent,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class time
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-type", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("beats", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("interchangeable", typeof(interchangeable))]
        [System.Xml.Serialization.XmlElementAttribute("senza-misura", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType10[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public timesymbol symbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public timeseparator separator;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool separatorSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType10
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("beat-type")]
        beattype,

        /// <remarks/>
        beats,

        /// <remarks/>
        interchangeable,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("senza-misura")]
        senzamisura,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "key-octave")]
    public class keyoctave
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno cancel;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cancelSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "key-accidental")]
    public class keyaccidental
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class cancel
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cancellocation location;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "cancel-location")]
    public enum cancellocation
    {

        /// <remarks/>
        left,

        /// <remarks/>
        right,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("before-barline")]
        beforebarline,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class key
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cancel", typeof(cancel))]
        [System.Xml.Serialization.XmlElementAttribute("fifths", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("key-accidental", typeof(keyaccidental))]
        [System.Xml.Serialization.XmlElementAttribute("key-alter", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("key-step", typeof(step))]
        [System.Xml.Serialization.XmlElementAttribute("mode", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType9[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("key-octave")]
        public keyoctave[] keyoctave;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType9
    {

        /// <remarks/>
        cancel,

        /// <remarks/>
        fifths,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("key-accidental")]
        keyaccidental,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("key-alter")]
        keyalter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("key-step")]
        keystep,

        /// <remarks/>
        mode,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class attributesXML
    {

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        public decimal divisions;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool divisionsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("key")]
        public key[] key;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public time[] time;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string staves;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-symbol")]
        public partsymbol partsymbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string instruments;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clef")]
        public clef[] clef;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-details")]
        public staffdetails[] staffdetails;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transpose")]
        public transpose[] transpose;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directive")]
        public attributesDirective[] directive;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measure-style")]
        public measurestyle[] measurestyle;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class attributesDirective
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

//-----------------------------------------------------------------------------
    [System.SerializableAttribute()]
    public class feature
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class grouping
    {

        [System.Xml.Serialization.XmlElementAttribute("feature")]
        public feature[] feature;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopsingle type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("member-of", DataType = "token")]
        public string memberof;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        public grouping()
        {
            this.number = "1";
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-single")]
    public enum startstopsingle
    {
        start,
        stop,
        single,
    }

    [System.SerializableAttribute()]
    public class repeat
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public backwardforward direction;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string times;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public winged winged;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wingedSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "backward-forward")]
    public enum backwardforward
    {
        backward,
        forward,
    }

    [System.SerializableAttribute()]
    public enum winged
    {
        none,
        straight,
        curved,

        [System.Xml.Serialization.XmlEnumAttribute("double-straight")]
        doublestraight,

        [System.Xml.Serialization.XmlEnumAttribute("double-curved")]
        doublecurved,
    }

    [System.SerializableAttribute()]
    public class ending
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopdiscontinue type;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("end-length")]
        public decimal endlength;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endlengthSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("text-x")]
        public decimal textx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("text-y")]
        public decimal texty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textySpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-discontinue")]
    public enum startstopdiscontinue
    {
        start,
        stop,
        discontinue,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "yes-no")]
    public enum yesno
    {
        yes,
        no,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bar-style-color")]
    public class barstylecolor
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlTextAttribute()]
        public barstyle Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bar-style")]
    public enum barstyle
    {
        regular,
        dotted,
        dashed,
        heavy,

        [System.Xml.Serialization.XmlEnumAttribute("light-light")]
        lightlight,

        [System.Xml.Serialization.XmlEnumAttribute("light-heavy")]
        lightheavy,

        [System.Xml.Serialization.XmlEnumAttribute("heavy-light")]
        heavylight,

        [System.Xml.Serialization.XmlEnumAttribute("heavy-heavy")]
        heavyheavy,

        tick,
        @short,
        none,
    }

    [System.SerializableAttribute()]
    public class barlineXML
    {

        [System.Xml.Serialization.XmlElementAttribute("bar-style")]
        public barstylecolor barstyle;

        public formattedtext footnote;

        public level level;

        [System.Xml.Serialization.XmlElementAttribute("wavy-line")]
        public wavyline wavyline;

        public segno segno;

        public coda coda;

        [System.Xml.Serialization.XmlElementAttribute("fermata")]
        public fermata[] fermata;

        public ending ending;

        public repeat repeat;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(rightleftmiddle.right)]
        public rightleftmiddle location;

        [System.Xml.Serialization.XmlAttributeAttribute("segno", DataType = "token")]
        public string segno1;

        [System.Xml.Serialization.XmlAttributeAttribute("coda", DataType = "token")]
        public string coda1;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal divisions;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool divisionsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        public barlineXML()
        {
            this.location = rightleftmiddle.right;
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "formatted-text")]
    public class formattedtext
    {

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class level
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno reference;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "symbol-size")]
    public enum symbolsize
    {
        full,
        cue,

        [System.Xml.Serialization.XmlEnumAttribute("grace-cue")]
        gracecue,
        large,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "wavy-line")]
    public class wavyline
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute("start-note")]
        public startnote startnote;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startnoteSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("trill-step")]
        public trillstep trillstep;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trillstepSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("two-note-turn")]
        public twonoteturn twonoteturn;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool twonoteturnSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("second-beat")]
        public decimal secondbeat;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondbeatSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-continue")]
    public enum startstopcontinue
    {   start,
        stop,
        @continue,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "above-below")]
    public enum abovebelow
    {
        above,
        below,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-note")]
    public enum startnote
    {
        upper,
        main,
        below,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "trill-step")]
    public enum trillstep
    {
        whole,
        half,
        unison,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "two-note-turn")]
    public enum twonoteturn
    {
        whole,
        half,
        none,
    }

    [System.SerializableAttribute()]
    public class segno
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    [System.SerializableAttribute()]
    public class coda
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    [System.SerializableAttribute()]
    public class fermata
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uprightinverted type;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlTextAttribute()]
        public fermatashape Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "upright-inverted")]
    public enum uprightinverted
    {
        upright,
        inverted,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "fermata-shape")]
    public enum fermatashape
    {
        normal,
        angled,
        square,

        [System.Xml.Serialization.XmlEnumAttribute("double-angled")]
        doubleangled,

        [System.Xml.Serialization.XmlEnumAttribute("double-square")]
        doublesquare,

        [System.Xml.Serialization.XmlEnumAttribute("double-dot")]
        doubledot,

        [System.Xml.Serialization.XmlEnumAttribute("half-curve")]
        halfcurve,

        curlew,

        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "right-left-middle")]
    public enum rightleftmiddle
    {
        right,
        left,
        middle
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-numbering")]
    public class measurenumbering
    {

        [System.Xml.Serialization.XmlTextAttribute()]
        public measurenumberingvalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-numbering-value")]
    public enum measurenumberingvalue
    {
        none,
        measure,
        system
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-layout")]
    public class measurelayout
    {

        [System.Xml.Serialization.XmlElementAttribute("measure-distance")]
        public decimal measuredistance;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measuredistanceSpecified;
    }

    [System.SerializableAttribute()]
    public class printXML
    {

        [System.Xml.Serialization.XmlElementAttribute("page-layout")]
        public pagelayout pagelayout;

        [System.Xml.Serialization.XmlElementAttribute("system-layout")]
        public systemlayout systemlayout;

        [System.Xml.Serialization.XmlElementAttribute("staff-layout")]
        public stafflayout[] stafflayout;

        [System.Xml.Serialization.XmlElementAttribute("measure-layout")]
        public measurelayout measurelayout;

        [System.Xml.Serialization.XmlElementAttribute("measure-numbering")]
        public measurenumbering measurenumbering;

        [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
        public namedisplay partnamedisplay;

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
        public namedisplay partabbreviationdisplay;

        [System.Xml.Serialization.XmlAttributeAttribute("staff-spacing")]
        public decimal staffspacing;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffspacingSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("new-system")]
        public yesno newsystem;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newsystemSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("new-page")]
        public yesno newpage;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newpageSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("blank-page", DataType = "positiveInteger")]
        public string blankpage;

        [System.Xml.Serialization.XmlAttributeAttribute("page-number", DataType = "token")]
        public string pagenumber;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-layout")]
    public class pagelayout
    {

        [System.Xml.Serialization.XmlElementAttribute("page-height")]
        public decimal pageheight;

        [System.Xml.Serialization.XmlElementAttribute("page-width")]
        public decimal pagewidth;

        [System.Xml.Serialization.XmlElementAttribute("page-margins")]
        public pagemargins[] pagemargins;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-margins")]
    public class pagemargins
    {
        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin;

        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin;

        [System.Xml.Serialization.XmlElementAttribute("top-margin")]
        public decimal topmargin;

        [System.Xml.Serialization.XmlElementAttribute("bottom-margin")]
        public decimal bottommargin;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public margintype type;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "margin-type")]
    public enum margintype
    {
        odd,
        even,
        both
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-layout")]
    public class systemlayout
    {
        [System.Xml.Serialization.XmlElementAttribute("system-margins")]
        public systemmargins systemmargins;

        [System.Xml.Serialization.XmlElementAttribute("system-distance")]
        public decimal systemdistance;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool systemdistanceSpecified;

        [System.Xml.Serialization.XmlElementAttribute("top-system-distance")]
        public decimal topsystemdistance;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topsystemdistanceSpecified;

        [System.Xml.Serialization.XmlElementAttribute("system-dividers")]
        public systemdividers systemdividers;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-margins")]
    public class systemmargins
    {

        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin;

        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-dividers")]
    public class systemdividers
    {

        [System.Xml.Serialization.XmlElementAttribute("left-divider")]
        public emptyprintobjectstylealign leftdivider;

        [System.Xml.Serialization.XmlElementAttribute("right-divider")]
        public emptyprintobjectstylealign rightdivider;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-print-object-style-align")]
    public class emptyprintobjectstylealign
    {

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-layout")]
    public class stafflayout
    {

        [System.Xml.Serialization.XmlElementAttribute("staff-distance")]
        public decimal staffdistance;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffdistanceSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "name-display")]
    public class namedisplay
    {

        [System.Xml.Serialization.XmlElementAttribute("accidental-text", typeof(accidentaltext))]
        [System.Xml.Serialization.XmlElementAttribute("display-text", typeof(formattedtext))]
        public object[] Items;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-text")]
    public class accidentaltext
    {

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-value")]
    public enum accidentalvalue
    {

        sharp,

        natural,

        flat,

        [System.Xml.Serialization.XmlEnumAttribute("double-sharp")]
        doublesharp,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-sharp")]
        sharpsharp,

        [System.Xml.Serialization.XmlEnumAttribute("flat-flat")]
        flatflat,

        [System.Xml.Serialization.XmlEnumAttribute("natural-sharp")]
        naturalsharp,

        [System.Xml.Serialization.XmlEnumAttribute("natural-flat")]
        naturalflat,

        [System.Xml.Serialization.XmlEnumAttribute("quarter-flat")]
        quarterflat,

        [System.Xml.Serialization.XmlEnumAttribute("quarter-sharp")]
        quartersharp,

        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-flat")]
        threequartersflat,

        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-sharp")]
        threequarterssharp,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-down")]
        sharpdown,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-up")]
        sharpup,

        [System.Xml.Serialization.XmlEnumAttribute("natural-down")]
        naturaldown,

        [System.Xml.Serialization.XmlEnumAttribute("natural-up")]
        naturalup,

        [System.Xml.Serialization.XmlEnumAttribute("flat-down")]
        flatdown,

        [System.Xml.Serialization.XmlEnumAttribute("flat-up")]
        flatup,

        [System.Xml.Serialization.XmlEnumAttribute("double-sharp-down")]
        doublesharpdown,

        [System.Xml.Serialization.XmlEnumAttribute("double-sharp-up")]
        doublesharpup,

        [System.Xml.Serialization.XmlEnumAttribute("flat-flat-down")]
        flatflatdown,

        [System.Xml.Serialization.XmlEnumAttribute("flat-flat-up")]
        flatflatup,

        [System.Xml.Serialization.XmlEnumAttribute("arrow-down")]
        arrowdown,

        [System.Xml.Serialization.XmlEnumAttribute("arrow-up")]
        arrowup,

        [System.Xml.Serialization.XmlEnumAttribute("triple-sharp")]
        triplesharp,

        [System.Xml.Serialization.XmlEnumAttribute("triple-flat")]
        tripleflat,

        [System.Xml.Serialization.XmlEnumAttribute("slash-quarter-sharp")]
        slashquartersharp,

        [System.Xml.Serialization.XmlEnumAttribute("slash-sharp")]
        slashsharp,

        [System.Xml.Serialization.XmlEnumAttribute("slash-flat")]
        slashflat,

        [System.Xml.Serialization.XmlEnumAttribute("double-slash-flat")]
        doubleslashflat,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-1")]
        sharp1,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-2")]
        sharp2,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-3")]
        sharp3,

        [System.Xml.Serialization.XmlEnumAttribute("sharp-5")]
        sharp5,

        [System.Xml.Serialization.XmlEnumAttribute("flat-1")]
        flat1,

        [System.Xml.Serialization.XmlEnumAttribute("flat-2")]
        flat2,

        [System.Xml.Serialization.XmlEnumAttribute("flat-3")]
        flat3,

        [System.Xml.Serialization.XmlEnumAttribute("flat-4")]
        flat4,

        sori,

        koron,

        other,
    }

    [System.SerializableAttribute()]
    public class figure
    {

        public styletext prefix;

        [System.Xml.Serialization.XmlElementAttribute("figure-number")]
        public styletext figurenumber;

        public styletext suffix;

        public extend extend;

        public formattedtext footnote;

        public level level;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "style-text")]
    public class styletext
    {

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class extend
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "figured-bass")]
    public class figuredbass
    {

        [System.Xml.Serialization.XmlElementAttribute("figure")]
        public figure[] figure;

        public decimal duration;

        public formattedtext footnote;

        public level level;

        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public yesno printdot;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printdotSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public yesno printlyric;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlyricSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    public class barre
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop")]
    public enum startstop
    {

        start,

        stop,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "frame-note")]
    public class framenote
    {
        public @string @string;
        public fret fret;
        public fingering fingering;
        public barre barre;
    }

    [System.SerializableAttribute()]
    public class @string
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class fret
    {

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily;

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize;

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "font-style")]
    public enum fontstyle
    {
        normal,
        italic,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "font-weight")]
    public enum fontweight
    {
        normal,
        bold,
    }

    [System.SerializableAttribute()]
    public class fingering
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno substitution;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool substitutionSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno alternate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alternateSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "first-fret")]
    public class firstfret
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftright location;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "left-right")]
    public enum leftright
    {
        left,
        right,
    }

    [System.SerializableAttribute()]
    public class frame
    {

        [System.Xml.Serialization.XmlElementAttribute("frame-strings", DataType = "positiveInteger")]
        public string framestrings;

        [System.Xml.Serialization.XmlElementAttribute("frame-frets", DataType = "positiveInteger")]
        public string framefrets;

        [System.Xml.Serialization.XmlElementAttribute("first-fret")]
        public firstfret firstfret;

        [System.Xml.Serialization.XmlElementAttribute("frame-note")]
        public framenote[] framenote;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright halign;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool halignSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public valignimage valign;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valignSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string unplayed;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "left-center-right")]
    public enum leftcenterright
    {
        left,
        center,
        right,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "valign-image")]
    public enum valignimage
    {
        top,
        middle,
        bottom,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-type")]
    public class degreetype
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlTextAttribute()]
        public degreetypevalue Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-type-value")]
    public enum degreetypevalue
    {
        add,
        alter,
        subtract,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-alter")]
    public class degreealter
    {

        [System.Xml.Serialization.XmlAttributeAttribute("plus-minus")]
        public yesno plusminus;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plusminusSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-value")]
    public class degreevalue
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public degreesymbolvalue symbol;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-symbol-value")]
    public enum degreesymbolvalue
    {
        major,
        minor,
        augmented,
        diminished,

        [System.Xml.Serialization.XmlEnumAttribute("half-diminished")]
        halfdiminished,
    }

    [System.SerializableAttribute()]
    public class degree
    {

        [System.Xml.Serialization.XmlElementAttribute("degree-value")]
        public degreevalue degreevalue;

        [System.Xml.Serialization.XmlElementAttribute("degree-alter")]
        public degreealter degreealter;

        [System.Xml.Serialization.XmlElementAttribute("degree-type")]
        public degreetype degreetype;

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bass-alter")]
    public class bassalter
    {

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftright location;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bass-step")]
    public class bassstep
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlTextAttribute()]
        public step Value;
    }

    [System.SerializableAttribute()]
    public enum step
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
    }

    [System.SerializableAttribute()]
    public class bass
    {

        [System.Xml.Serialization.XmlElementAttribute("bass-step")]
        public bassstep bassstep;

        [System.Xml.Serialization.XmlElementAttribute("bass-alter")]
        public bassalter bassalter;
    }

    [System.SerializableAttribute()]
    public class inversion
    {
        [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
        public string Value;
    }

    [System.SerializableAttribute()]
    public class kind
    {

        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public yesno usesymbols;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usesymbolsSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        [System.Xml.Serialization.XmlAttributeAttribute("stack-degrees")]
        public yesno stackdegrees;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stackdegreesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("parentheses-degrees")]
        public yesno parenthesesdegrees;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesdegreesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute("bracket-degrees")]
        public yesno bracketdegrees;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketdegreesSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright halign;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool halignSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public valign valign;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valignSpecified;

        [System.Xml.Serialization.XmlTextAttribute()]
        public kindvalue Value;
    }

    [System.SerializableAttribute()]
    public enum valign
    {
        top,
        middle,
        bottom,
        baseline,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "kind-value")]
    public enum kindvalue
    {

        major,

        minor,

        augmented,

        diminished,

        dominant,

        [System.Xml.Serialization.XmlEnumAttribute("major-seventh")]
        majorseventh,

        [System.Xml.Serialization.XmlEnumAttribute("minor-seventh")]
        minorseventh,

        [System.Xml.Serialization.XmlEnumAttribute("diminished-seventh")]
        diminishedseventh,

        [System.Xml.Serialization.XmlEnumAttribute("augmented-seventh")]
        augmentedseventh,

        [System.Xml.Serialization.XmlEnumAttribute("half-diminished")]
        halfdiminished,

        [System.Xml.Serialization.XmlEnumAttribute("major-minor")]
        majorminor,

        [System.Xml.Serialization.XmlEnumAttribute("major-sixth")]
        majorsixth,

        [System.Xml.Serialization.XmlEnumAttribute("minor-sixth")]
        minorsixth,

        [System.Xml.Serialization.XmlEnumAttribute("dominant-ninth")]
        dominantninth,

        [System.Xml.Serialization.XmlEnumAttribute("major-ninth")]
        majorninth,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("minor-ninth")]
        minorninth,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("dominant-11th")]
        dominant11th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("major-11th")]
        major11th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("minor-11th")]
        minor11th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("dominant-13th")]
        dominant13th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("major-13th")]
        major13th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("minor-13th")]
        minor13th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("suspended-second")]
        suspendedsecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("suspended-fourth")]
        suspendedfourth,

        /// <remarks/>
        Neapolitan,

        /// <remarks/>
        Italian,

        /// <remarks/>
        French,

        /// <remarks/>
        German,

        /// <remarks/>
        pedal,

        /// <remarks/>
        power,

        /// <remarks/>
        Tristan,

        /// <remarks/>
        other,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "root-alter")]
    public class rootalter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftright location;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "root-step")]
    public class rootstep
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public step Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class root
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("root-step")]
        public rootstep rootstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("root-alter")]
        public rootalter rootalter;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class harmony
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("function", typeof(styletext))]
        [System.Xml.Serialization.XmlElementAttribute("root", typeof(root))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("kind")]
        public kind[] kind;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inversion")]
        public inversion[] inversion;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass")]
        public bass[] bass;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree")]
        public degree[] degree;

        /// <remarks/>
        public frame frame;

        /// <remarks/>
        public offset offset;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public harmonytype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-frame")]
        public yesno printframe;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printframeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class offset
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno sound;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool soundSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmony-type")]
    public enum harmonytype
    {

        /// <remarks/>
        @explicit,

        /// <remarks/>
        implied,

        /// <remarks/>
        alternate,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class sound
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-device")]
        public mididevice[] mididevice;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-instrument")]
        public midiinstrument[] midiinstrument;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("play")]
        public play[] play;

        /// <remarks/>
        public offset offset;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tempo;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tempoSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dynamics;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dynamicsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno dacapo;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dacapoSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string segno;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string dalsegno;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string coda;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string tocoda;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal divisions;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool divisionsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("forward-repeat")]
        public yesno forwardrepeat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forwardrepeatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string fine;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno pizzicato;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pizzicatoSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal pan;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool panSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal elevation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elevationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("damper-pedal")]
        public string damperpedal;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("soft-pedal")]
        public string softpedal;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("sostenuto-pedal")]
        public string sostenutopedal;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "midi-device")]
    public class mididevice
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string port;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "midi-instrument")]
    public class midiinstrument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-channel", DataType = "positiveInteger")]
        public string midichannel;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-name")]
        public string midiname;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-bank", DataType = "positiveInteger")]
        public string midibank;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-program", DataType = "positiveInteger")]
        public string midiprogram;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-unpitched", DataType = "positiveInteger")]
        public string midiunpitched;

        /// <remarks/>
        public decimal volume;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volumeSpecified;

        /// <remarks/>
        public decimal pan;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool panSpecified;

        /// <remarks/>
        public decimal elevation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elevationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class play
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ipa", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("mute", typeof(mute))]
        [System.Xml.Serialization.XmlElementAttribute("other-play", typeof(otherplay))]
        [System.Xml.Serialization.XmlElementAttribute("semi-pitched", typeof(semipitched))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public enum mute
    {

        /// <remarks/>
        on,

        /// <remarks/>
        off,

        /// <remarks/>
        straight,

        /// <remarks/>
        cup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("harmon-no-stem")]
        harmonnostem,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("harmon-stem")]
        harmonstem,

        /// <remarks/>
        bucket,

        /// <remarks/>
        plunger,

        /// <remarks/>
        hat,

        /// <remarks/>
        solotone,

        /// <remarks/>
        practice,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("stop-mute")]
        stopmute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("stop-hand")]
        stophand,

        /// <remarks/>
        echo,

        /// <remarks/>
        palm,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-play")]
    public class otherplay
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "semi-pitched")]
    public enum semipitched
    {

        /// <remarks/>
        high,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("medium-high")]
        mediumhigh,

        /// <remarks/>
        medium,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("medium-low")]
        mediumlow,

        /// <remarks/>
        low,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("very-low")]
        verylow,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class forwardXML
    {

        /// <remarks/>
        public decimal duration;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        public string voice;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class backupXML
    {

        /// <remarks/>
        public decimal duration;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class bookmark
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string element;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string position;
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public class link
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public opusType type;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string role;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string title;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [System.ComponentModel.DefaultValueAttribute(opusShow.replace)]
        public opusShow show;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [System.ComponentModel.DefaultValueAttribute(opusActuate.onRequest)]
        public opusActuate actuate;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string element;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string position;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified;

        public link()
        {
            this.type = opusType.simple;
            this.show = opusShow.replace;
            this.actuate = opusActuate.onRequest;
        }
    }

//- score time-wise -----------------------------------------------------------

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("score-timewise", Namespace = "", IsNullable = false)]
    public class ScoreTimewise
    {
        public work work;
            [System.Xml.Serialization.XmlElementAttribute("movement-number")]
        public string movementnumber;
            [System.Xml.Serialization.XmlElementAttribute("movement-title")]
        public string movementtitle;
        public identification identification;
        public defaults defaults;
            [System.Xml.Serialization.XmlElementAttribute("credit")]
        public credit[] credit;
            [System.Xml.Serialization.XmlElementAttribute("part-list")]
        public partlist partlist;
            [System.Xml.Serialization.XmlElementAttribute("measure")]
        public scoretimewiseMeasure[] measure;
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            [System.ComponentModel.DefaultValueAttribute("1.0")]
        public string version;

        public ScoreTimewise()
        {
            this.version = "1.0";
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scoretimewiseMeasure
    {
            [System.Xml.Serialization.XmlElementAttribute("part")]
        public scoretimewiseMeasurePart[] part;
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string number;
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;
            [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno @implicit;
            [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool implicitSpecified;
            [System.Xml.Serialization.XmlAttributeAttribute("non-controlling")]
        public yesno noncontrolling;
            [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noncontrollingSpecified;
            [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width;
            [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scoretimewiseMeasurePart
    {
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributesXML))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backupXML))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barlineXML))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forwardXML))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(printXML))]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(sound))]
        public object[] Items;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }
}