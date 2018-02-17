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

using System.Xml.Serialization;

//generated using MS xsd.exe from MUSICXML's musicxml.xsd (https://github.com/w3c/musicxml)

namespace Transonic.Score.MusicXML
{

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("score-partwise", Namespace = "", IsNullable = false)]
    public class ScorePartwise
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

        public ScorePartwise()
        {
            this.version = "1.0";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class work
    {

        [System.Xml.Serialization.XmlElementAttribute("work-number")]
        public string worknumber;

        [System.Xml.Serialization.XmlElementAttribute("work-title")]
        public string worktitle;

        public opus opus;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusType
    {

        simple,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusShow
    {

        @new,

        replace,

        embed,

        other,

        none,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum opusActuate
    {

        onRequest,

        onLoad,

        other,

        none,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class feature
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-single")]
    public enum startstopsingle
    {

        start,

        stop,

        single,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "backward-forward")]
    public enum backwardforward
    {

        backward,

        forward,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-discontinue")]
    public enum startstopdiscontinue
    {
        start,
        stop,
        discontinue,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "yes-no")]
    public enum yesno
    {

        yes,

        no,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bar-style-color")]
    public class barstylecolor
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        [System.Xml.Serialization.XmlTextAttribute()]
        public barstyle Value;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class barline
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

        public barline()
        {
            this.location = rightleftmiddle.right;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop-continue")]
    public enum startstopcontinue
    {   start,
        stop,
        @continue,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "above-below")]
    public enum abovebelow
    {

        above,

        below,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-note")]
    public enum startnote
    {

        upper,

        main,

        below,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "trill-step")]
    public enum trillstep
    {

        whole,

        half,

        unison,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "two-note-turn")]
    public enum twonoteturn
    {

        whole,

        half,

        none,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class segno
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class coda
    {

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "upright-inverted")]
    public enum uprightinverted
    {

        upright,

        inverted,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "right-left-middle")]
    public enum rightleftmiddle
    {

        right,

        left,

        middle,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-numbering")]
    public class measurenumbering
    {

        [System.Xml.Serialization.XmlTextAttribute()]
        public measurenumberingvalue Value;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-numbering-value")]
    public enum measurenumberingvalue
    {

        none,

        measure,

        system,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-layout")]
    public class measurelayout
    {

        [System.Xml.Serialization.XmlElementAttribute("measure-distance")]
        public decimal measuredistance;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measuredistanceSpecified;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class print
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("page-number", DataType = "token")]
        public string pagenumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-layout")]
    public class pagelayout
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-height")]
        public decimal pageheight;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-width")]
        public decimal pagewidth;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-margins")]
        public pagemargins[] pagemargins;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-margins")]
    public class pagemargins
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("top-margin")]
        public decimal topmargin;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bottom-margin")]
        public decimal bottommargin;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public margintype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "margin-type")]
    public enum margintype
    {

        /// <remarks/>
        odd,

        /// <remarks/>
        even,

        /// <remarks/>
        both,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-layout")]
    public class systemlayout
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-margins")]
        public systemmargins systemmargins;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-distance")]
        public decimal systemdistance;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool systemdistanceSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("top-system-distance")]
        public decimal topsystemdistance;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topsystemdistanceSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-dividers")]
        public systemdividers systemdividers;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-margins")]
    public class systemmargins
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-dividers")]
    public class systemdividers
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-divider")]
        public emptyprintobjectstylealign leftdivider;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-divider")]
        public emptyprintobjectstylealign rightdivider;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-print-object-style-align")]
    public class emptyprintobjectstylealign
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-layout")]
    public class stafflayout
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-distance")]
        public decimal staffdistance;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffdistanceSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "name-display")]
    public class namedisplay
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accidental-text", typeof(accidentaltext))]
        [System.Xml.Serialization.XmlElementAttribute("display-text", typeof(formattedtext))]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-text")]
    public class accidentaltext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-value")]
    public enum accidentalvalue
    {

        /// <remarks/>
        sharp,

        /// <remarks/>
        natural,

        /// <remarks/>
        flat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-sharp")]
        doublesharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-sharp")]
        sharpsharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-flat")]
        flatflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-sharp")]
        naturalsharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-flat")]
        naturalflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("quarter-flat")]
        quarterflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("quarter-sharp")]
        quartersharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-flat")]
        threequartersflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-sharp")]
        threequarterssharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-down")]
        sharpdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-up")]
        sharpup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-down")]
        naturaldown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-up")]
        naturalup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-down")]
        flatdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-up")]
        flatup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-sharp-down")]
        doublesharpdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-sharp-up")]
        doublesharpup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-flat-down")]
        flatflatdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-flat-up")]
        flatflatup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("arrow-down")]
        arrowdown,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("arrow-up")]
        arrowup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("triple-sharp")]
        triplesharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("triple-flat")]
        tripleflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slash-quarter-sharp")]
        slashquartersharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slash-sharp")]
        slashsharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("slash-flat")]
        slashflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-slash-flat")]
        doubleslashflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-1")]
        sharp1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-2")]
        sharp2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-3")]
        sharp3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-5")]
        sharp5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-1")]
        flat1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-2")]
        flat2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-3")]
        flat3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-4")]
        flat4,

        /// <remarks/>
        sori,

        /// <remarks/>
        koron,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class figure
    {

        /// <remarks/>
        public styletext prefix;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("figure-number")]
        public styletext figurenumber;

        /// <remarks/>
        public styletext suffix;

        /// <remarks/>
        public extend extend;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "style-text")]
    public class styletext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class extend
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "figured-bass")]
    public class figuredbass
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("figure")]
        public figure[] figure;

        /// <remarks/>
        public decimal duration;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public yesno printdot;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printdotSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public yesno printlyric;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlyricSpecified;

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class barre
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "start-stop")]
    public enum startstop
    {

        /// <remarks/>
        start,

        /// <remarks/>
        stop,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "frame-note")]
    public class framenote
    {

        /// <remarks/>
        public @string @string;

        /// <remarks/>
        public fret fret;

        /// <remarks/>
        public fingering fingering;

        /// <remarks/>
        public barre barre;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class @string
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class fret
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "font-style")]
    public enum fontstyle
    {

        /// <remarks/>
        normal,

        /// <remarks/>
        italic,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "font-weight")]
    public enum fontweight
    {

        /// <remarks/>
        normal,

        /// <remarks/>
        bold,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class fingering
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno substitution;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool substitutionSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno alternate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alternateSpecified;

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "first-fret")]
    public class firstfret
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftright location;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "left-right")]
    public enum leftright
    {

        /// <remarks/>
        left,

        /// <remarks/>
        right,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class frame
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-strings", DataType = "positiveInteger")]
        public string framestrings;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-frets", DataType = "positiveInteger")]
        public string framefrets;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("first-fret")]
        public firstfret firstfret;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-note")]
        public framenote[] framenote;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright halign;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool halignSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public valignimage valign;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valignSpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string unplayed;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "left-center-right")]
    public enum leftcenterright
    {

        /// <remarks/>
        left,

        /// <remarks/>
        center,

        /// <remarks/>
        right,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "valign-image")]
    public enum valignimage
    {

        /// <remarks/>
        top,

        /// <remarks/>
        middle,

        /// <remarks/>
        bottom,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-type")]
    public class degreetype
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public degreetypevalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-type-value")]
    public enum degreetypevalue
    {

        /// <remarks/>
        add,

        /// <remarks/>
        alter,

        /// <remarks/>
        subtract,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-alter")]
    public class degreealter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("plus-minus")]
        public yesno plusminus;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plusminusSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-value")]
    public class degreevalue
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public degreesymbolvalue symbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-symbol-value")]
    public enum degreesymbolvalue
    {

        /// <remarks/>
        major,

        /// <remarks/>
        minor,

        /// <remarks/>
        augmented,

        /// <remarks/>
        diminished,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("half-diminished")]
        halfdiminished,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class degree
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-value")]
        public degreevalue degreevalue;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-alter")]
        public degreealter degreealter;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-type")]
        public degreetype degreetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bass-alter")]
    public class bassalter
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "bass-step")]
    public class bassstep
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public step Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    public enum step
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        G,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class bass
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass-step")]
        public bassstep bassstep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass-alter")]
        public bassalter bassalter;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class inversion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class kind
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public yesno usesymbols;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usesymbolsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("stack-degrees")]
        public yesno stackdegrees;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stackdegreesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("parentheses-degrees")]
        public yesno parenthesesdegrees;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesdegreesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bracket-degrees")]
        public yesno bracketdegrees;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketdegreesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright halign;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool halignSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public valign valign;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valignSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public kindvalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    public enum valign
    {

        /// <remarks/>
        top,

        /// <remarks/>
        middle,

        /// <remarks/>
        bottom,

        /// <remarks/>
        baseline,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "kind-value")]
    public enum kindvalue
    {

        /// <remarks/>
        major,

        /// <remarks/>
        minor,

        /// <remarks/>
        augmented,

        /// <remarks/>
        diminished,

        /// <remarks/>
        dominant,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("major-seventh")]
        majorseventh,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("minor-seventh")]
        minorseventh,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("diminished-seventh")]
        diminishedseventh,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("augmented-seventh")]
        augmentedseventh,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("half-diminished")]
        halfdiminished,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("major-minor")]
        majorminor,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("major-sixth")]
        majorsixth,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("minor-sixth")]
        minorsixth,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("dominant-ninth")]
        dominantninth,

        /// <remarks/>
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class slash
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-type")]
        public notetypevalue slashtype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
        public empty[] slashdot;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("except-voice")]
        public string[] exceptvoice;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
        public yesno usedots;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedotsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-stems")]
        public yesno usestems;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usestemsSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-type-value")]
    public enum notetypevalue
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1024th")]
        Item1024th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("512th")]
        Item512th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("256th")]
        Item256th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("128th")]
        Item128th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64th")]
        Item64th,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32nd")]
        Item32nd,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16th")]
        Item16th,

        /// <remarks/>
        eighth,

        /// <remarks/>
        quarter,

        /// <remarks/>
        half,

        /// <remarks/>
        whole,

        /// <remarks/>
        breve,

        /// <remarks/>
        @long,

        /// <remarks/>
        maxima,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class empty
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beat-repeat")]
    public class beatrepeat
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-type")]
        public notetypevalue slashtype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
        public empty[] slashdot;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("except-voice")]
        public string[] exceptvoice;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string slashes;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
        public yesno usedots;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedotsSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-repeat")]
    public class measurerepeat
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string slashes;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "multiple-rest")]
    public class multiplerest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public yesno usesymbols;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usesymbolsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-style")]
    public class measurestyle
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-repeat", typeof(beatrepeat))]
        [System.Xml.Serialization.XmlElementAttribute("measure-repeat", typeof(measurerepeat))]
        [System.Xml.Serialization.XmlElementAttribute("multiple-rest", typeof(multiplerest))]
        [System.Xml.Serialization.XmlElementAttribute("slash", typeof(slash))]
        public object Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class transpose
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string diatonic;

        /// <remarks/>
        public decimal chromatic;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("octave-change", DataType = "integer")]
        public string octavechange;

        /// <remarks/>
        public empty @double;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-tuning")]
    public class stafftuning
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string line;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-details")]
    public class staffdetails
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-type")]
        public stafftype stafftype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stafftypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-lines", DataType = "nonNegativeInteger")]
        public string stafflines;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-tuning")]
        public stafftuning[] stafftuning;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string capo;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-size")]
        public decimal staffsize;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffsizeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show-frets")]
        public showfrets showfrets;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showfretsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-spacing")]
        public yesno printspacing;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printspacingSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-type")]
    public enum stafftype
    {

        /// <remarks/>
        ossia,

        /// <remarks/>
        cue,

        /// <remarks/>
        editorial,

        /// <remarks/>
        regular,

        /// <remarks/>
        alternate,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class attributes
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-direction")]
    public class otherdirection
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-divide")]
    public class staffdivide
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public staffdividesymbol type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-divide-symbol")]
    public enum staffdividesymbol
    {

        /// <remarks/>
        down,

        /// <remarks/>
        up,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("up-down")]
        updown,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accordion-registration")]
    public class accordionregistration
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-high")]
        public empty accordionhigh;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-middle", DataType = "positiveInteger")]
        public string accordionmiddle;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-low")]
        public empty accordionlow;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class stick
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stick-type")]
        public sticktype sticktype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stick-material")]
        public stickmaterial stickmaterial;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public tipdirection tip;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dashed-circle")]
        public yesno dashedcircle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashedcircleSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stick-type")]
    public enum sticktype
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("bass drum")]
        bassdrum,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double bass drum")]
        doublebassdrum,

        /// <remarks/>
        glockenspiel,

        /// <remarks/>
        gum,

        /// <remarks/>
        hammer,

        /// <remarks/>
        superball,

        /// <remarks/>
        timpani,

        /// <remarks/>
        wound,

        /// <remarks/>
        xylophone,

        /// <remarks/>
        yarn,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "stick-material")]
    public enum stickmaterial
    {

        /// <remarks/>
        soft,

        /// <remarks/>
        medium,

        /// <remarks/>
        hard,

        /// <remarks/>
        shaded,

        /// <remarks/>
        x,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-print-style-align-id")]
    public class emptyprintstylealignid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-tied")]
    public class metronometied
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class direction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("direction-type")]
        public directiontype[] directiontype;

        /// <remarks/>
        public offset offset;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        public string voice;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;

        /// <remarks/>
        public sound sound;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno directive;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directiveSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class forward
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class backup
    {

        /// <remarks/>
        public decimal duration;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class elision
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "text-element-data")]
    public class textelementdata
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
        public decimal rotation;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rotationSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("letter-spacing")]
        public string letterspacing;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public textdirection dir;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dirSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "text-direction")]
    public enum textdirection
    {

        /// <remarks/>
        ltr,

        /// <remarks/>
        rtl,

        /// <remarks/>
        lro,

        /// <remarks/>
        rlo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class lyric
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("elision", typeof(elision))]
        [System.Xml.Serialization.XmlElementAttribute("extend", typeof(extend))]
        [System.Xml.Serialization.XmlElementAttribute("humming", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("laughing", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("syllabic", typeof(syllabic))]
        [System.Xml.Serialization.XmlElementAttribute("text", typeof(textelementdata))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType6[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-line")]
        public empty endline;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-paragraph")]
        public empty endparagraph;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright justify;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool justifySpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    public enum syllabic
    {

        /// <remarks/>
        single,

        /// <remarks/>
        begin,

        /// <remarks/>
        end,

        /// <remarks/>
        middle,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType6
    {

        /// <remarks/>
        elision,

        /// <remarks/>
        extend,

        /// <remarks/>
        humming,

        /// <remarks/>
        laughing,

        /// <remarks/>
        syllabic,

        /// <remarks/>
        text,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-notation")]
    public class othernotation
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopsingle type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public othernotation()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "non-arpeggiate")]
    public class nonarpeggiate
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public topbottom type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "top-bottom")]
    public enum topbottom
    {

        /// <remarks/>
        top,

        /// <remarks/>
        bottom,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class arpeggiate
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public updown direction;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "up-down")]
    public enum updown
    {

        /// <remarks/>
        up,

        /// <remarks/>
        down,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class caesura
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public caesuravalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "caesura-value")]
    public enum caesuravalue
    {

        /// <remarks/>
        normal,

        /// <remarks/>
        thick,

        /// <remarks/>
        @short,

        /// <remarks/>
        curved,

        /// <remarks/>
        single,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "breath-mark")]
    public class breathmark
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public breathmarkvalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "breath-mark-value")]
    public enum breathmarkvalue
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,

        /// <remarks/>
        comma,

        /// <remarks/>
        tick,

        /// <remarks/>
        upbow,

        /// <remarks/>
        salzedo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-line")]
    public class emptyline
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
        public lineshape lineshape;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineshapeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-length")]
        public linelength linelength;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linelengthSpecified;

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
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-shape")]
    public enum lineshape
    {

        /// <remarks/>
        straight,

        /// <remarks/>
        curved,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-length")]
    public enum linelength
    {

        /// <remarks/>
        @short,

        /// <remarks/>
        medium,

        /// <remarks/>
        @long,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class articulations
    {

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(strongaccent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(heeltoe))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-placement")]
    public class emptyplacement
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "strong-accent")]
    public class strongaccent : emptyplacement
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(updown.up)]
        public updown type;

        public strongaccent()
        {
            this.type = updown.up;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "heel-toe")]
    public class heeltoe : emptyplacement
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno substitution;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool substitutionSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-placement-text")]
    public class otherplacementtext
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        /// <remarks/>
        accent,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("breath-mark")]
        breathmark,

        /// <remarks/>
        caesura,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("detached-legato")]
        detachedlegato,

        /// <remarks/>
        doit,

        /// <remarks/>
        falloff,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("other-articulation")]
        otherarticulation,

        /// <remarks/>
        plop,

        /// <remarks/>
        scoop,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("soft-accent")]
        softaccent,

        /// <remarks/>
        spiccato,

        /// <remarks/>
        staccatissimo,

        /// <remarks/>
        staccato,

        /// <remarks/>
        stress,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("strong-accent")]
        strongaccent,

        /// <remarks/>
        tenuto,

        /// <remarks/>
        unstress,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "notehead-text")]
    public class noteheadtext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accidental-text", typeof(accidentaltext))]
        [System.Xml.Serialization.XmlElementAttribute("display-text", typeof(formattedtext))]
        public object[] Items;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class instrument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class tie
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class rest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-step")]
        public step displaystep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
        public string displayoctave;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno measure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class unpitched
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-step")]
        public step displaystep;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
        public string displayoctave;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class pitch
    {

        /// <remarks/>
        public step step;

        /// <remarks/>
        public decimal alter;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alterSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string octave;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class grace
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-previous")]
        public decimal stealtimeprevious;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimepreviousSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-following")]
        public decimal stealtimefollowing;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimefollowingSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("make-time")]
        public decimal maketime;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maketimeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno slash;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slashSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class note
    {

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName;

        /// <remarks/>
        public instrument instrument;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        public string voice;

        /// <remarks/>
        public notetype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dot")]
        public emptyplacement[] dot;

        /// <remarks/>
        public accidental accidental;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-modification")]
        public timemodification timemodification;

        /// <remarks/>
        public stem stem;

        /// <remarks/>
        public notehead notehead;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notehead-text")]
        public noteheadtext noteheadtext;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beam")]
        public beam[] beam;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notations")]
        public notations[] notations;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lyric")]
        public lyric[] lyric;

        /// <remarks/>
        public play play;

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
        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public yesno printdot;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printdotSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public yesno printlyric;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlyricSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-leger")]
        public yesno printleger;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlegerSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dynamics;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dynamicsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("end-dynamics")]
        public decimal enddynamics;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enddynamicsSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attack;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attackSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal release;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseSpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        chord,

        /// <remarks/>
        cue,

        /// <remarks/>
        duration,

        /// <remarks/>
        grace,

        /// <remarks/>
        pitch,

        /// <remarks/>
        rest,

        /// <remarks/>
        tie,

        /// <remarks/>
        unpitched,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "virtual-instrument")]
    public class virtualinstrument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("virtual-library")]
        public string virtuallibrary;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("virtual-name")]
        public string virtualname;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-instrument")]
    public class scoreinstrument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-name")]
        public string instrumentname;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-abbreviation")]
        public string instrumentabbreviation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-sound")]
        public string instrumentsound;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ensemble", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("solo", typeof(empty))]
        public object Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("virtual-instrument")]
        public virtualinstrument virtualinstrument;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-name")]
    public class partname
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-part")]
    public class scorepart
    {

        /// <remarks/>
        public identification identification;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-name")]
        public partname partname;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
        public namedisplay partnamedisplay;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation")]
        public partname partabbreviation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
        public namedisplay partabbreviationdisplay;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group")]
        public string[] group;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("score-instrument")]
        public scoreinstrument[] scoreinstrument;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-device")]
        public mididevice[] mididevice;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-instrument")]
        public midiinstrument[] midiinstrument;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class identification
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creator")]
        public typedtext[] creator;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rights")]
        public typedtext[] rights;

        /// <remarks/>
        public encoding encoding;

        /// <remarks/>
        public string source;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relation")]
        public typedtext[] relation;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public miscellaneousfield[] miscellaneous;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "typed-text")]
    public class typedtext
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class encoding
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("encoder", typeof(typedtext))]
        [System.Xml.Serialization.XmlElementAttribute("encoding-date", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("encoding-description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("software", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("supports", typeof(supports))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class supports
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string element;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string attribute;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        encoder,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("encoding-date")]
        encodingdate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("encoding-description")]
        encodingdescription,

        /// <remarks/>
        software,

        /// <remarks/>
        supports,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "miscellaneous-field")]
    public class miscellaneousfield
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-barline")]
    public class groupbarline
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public groupbarlinevalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-barline-value")]
    public enum groupbarlinevalue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,

        /// <remarks/>
        Mensurstrich,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-symbol")]
    public class groupsymbol
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
        public groupsymbolvalue Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-name")]
    public class groupname
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-group")]
    public class partgroup
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-name")]
        public groupname groupname;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-name-display")]
        public namedisplay groupnamedisplay;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation")]
        public groupname groupabbreviation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation-display")]
        public namedisplay groupabbreviationdisplay;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-symbol")]
        public groupsymbol groupsymbol;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-barline")]
        public groupbarline groupbarline;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group-time")]
        public empty grouptime;

        /// <remarks/>
        public formattedtext footnote;

        /// <remarks/>
        public level level;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string number;

        public partgroup()
        {
            this.number = "1";
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-list")]
    public class partlist
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-group", Order = 0)]
        public partgroup[] partgroup;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("score-part", Order = 1)]
        public scorepart scorepart;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-group", typeof(partgroup), Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("score-part", typeof(scorepart), Order = 2)]
        public object[] Items;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class credit
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit-type", Order = 0)]
        public string[] credittype;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link", Order = 1)]
        public link[] link;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bookmark", Order = 2)]
        public bookmark[] bookmark;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-image", typeof(image), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-symbol", typeof(formattedsymbolid), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-words", typeof(formattedtextid), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link), Order = 3)]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string page;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "lyric-language")]
    public class lyriclanguage
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "lyric-font")]
    public class lyricfont
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-font")]
    public class emptyfont
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-appearance")]
    public class otherappearance
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class glyph
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "NMTOKEN")]
        public string Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class distance
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-size")]
    public class notesize
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public notesizetype type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "note-size-type")]
    public enum notesizetype
    {

        /// <remarks/>
        cue,

        /// <remarks/>
        grace,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("grace-cue")]
        gracecue,

        /// <remarks/>
        large,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "line-width")]
    public class linewidth
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class appearance
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("line-width")]
        public linewidth[] linewidth;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("note-size")]
        public notesize[] notesize;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("distance")]
        public distance[] distance;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("glyph")]
        public glyph[] glyph;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other-appearance")]
        public otherappearance[] otherappearance;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class scaling
    {

        /// <remarks/>
        public decimal millimeters;

        /// <remarks/>
        public decimal tenths;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class defaults
    {

        /// <remarks/>
        public scaling scaling;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-layout")]
        public pagelayout pagelayout;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-layout")]
        public systemlayout systemlayout;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-layout")]
        public stafflayout[] stafflayout;

        /// <remarks/>
        public appearance appearance;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("music-font")]
        public emptyfont musicfont;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("word-font")]
        public emptyfont wordfont;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lyric-font")]
        public lyricfont[] lyricfont;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lyric-language")]
        public lyriclanguage[] lyriclanguage;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scorepartwisePart
    {

        [System.Xml.Serialization.XmlElementAttribute("measure")]
        public scorepartwisePartMeasure[] measure;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scorepartwisePartMeasure
    {

        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributes))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backup))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barline))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forward))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(print))]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class scoretimewiseMeasurePart
    {

        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributes))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backup))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barline))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forward))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(print))]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(sound))]
        public object[] Items;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string id;
    }
}