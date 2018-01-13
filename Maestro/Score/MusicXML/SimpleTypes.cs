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

namespace Transonic.Score.MusicXML
{
    class SimpleTypes
    {
        enum AboveBelow { ABOVE, BELOW };
        enum AccidentalValue
        {
            SHARP, NATURAL, FLAT, DOUBLESHARP, SHARPSHARP, FLATFLAT, NATURALSHARP, NATURALFLAT,
            QUARTERFLAT, QUARTERSHARP, THREEQUARTERSFLAT, THREEQUARTERSSHARP, SHARPDOWN, SHARPUP,
            NATURALDOWN, NATURALUP, FLATDOWN, FLATUP, DOUBLESHARPDOWN, DOUBLESHARPUP, FLATFLATDOWN, FLATFLATUP,
            ARROWDOWN, ARROWUP, TRIPLESHARP, TRIPLEFLAT, SLASHQUARTERSHARP, SLASHSHARP, SLASHFLAT, DOUBLESLASHFLAT,
            SHARP1, SHARP2, SHARP3, SHARP5, FLAT1, FLAT2, FLAT3, FLAT4, SORI, KORON, OTHER
        };
        enum ArrowDirection
        {
            LEFT, UP, RIGHT, DOWN, NORTHWEST, NORTHEAST, SOUTHEAST, SOUTHWEST,
            LEFTRIGHT, UPDOWN, NORTHWESTSOUTHEAST, NORTHEASTSOUTHWEST, OTHER
        };
        enum ArrowStyle { SINGLE, DOUBLE, FILLED, HOLLOW, PAIRED, COMBINED, OTHER };
        enum BackwardForward { BACKWARD, FORWARD };
        enum BarStyle { REGULAR, DOTTED, DASHED, HEAVY, LIGHTLIGHT, LIGHTHEAVY, HEAVYLIGHT, HEAVYHEAVY, TICK, SHORT, NONE };
        enum BeamValue { BEGIN, CONTINUE, END, FORWARDHOOK, BACKWARDHOOK };

        //beater-value		- enum

        enum BreathMarkValue { NONE, COMMA, TICK, UPBOW, SALZEDO };
        enum CaesuraValue { NORMAL, THICK, SHORT, CURVED, SINGLE, NONE };
        enum CancelLocation { LEFT, RIGHT, BEFOREBARLINE };
        enum CircularArrow { CLOCKWISE, ANTICLOCKWISE };
        enum ClefSign { G, F, C, PERCUSSION, TAB, JIANPU, NONE };
        enum CssFontSize { XXSMALL, XSMALL, SMALL, MEDIUM, LARGE, XLARGE, XXLARGE };

        //degree-symbol-value	- enum
        //degree-type-value	- enum
        //effect			- enum
        enum EnclosureShape
        {
            RECTANGLE, SQUARE, OVAL, CIRCLE, BRACKET, TRIANGLE, DIAMOND, PENTAGON, HEXAGON, HEPTAGON,
            OCTAGON, NONAGON, DECAGON, NONE
        };
        enum Fan { ACCEL, RIT, NONE };
        enum FermataShape { NORMAL, ANGLED, SQUARE, DOUBLEANGLED, DOUBLESQUARE, DOUBLEDOT, HALFCURVE, CURLEW, NONE };

        //font-size		- double/enum
        enum FontStyle { NORMAL, ITALIC };
        enum FontWeight { NORMAL, BOLD };
        //glass-value		- enum
        enum GroupBarlineValue { YES, NO, MENSURSTRICH };
        enum GroupSymbolValue { NONE, BRACE, LINE, BRACKET, SQUARE };
        enum HandbellValue
        {
            BELLTREE, DAMP, ECHO, GYRO, HANDMARTELLATO,
            MALLETLIFT, MALLETTABLE, MARTELLATO, MARTELLATOLIFT, MUTEDMARTELLATO, PLUCKLIFT, SWING
        };
        enum HarmonClosedLocation { RIGHT, BOTTOM, LEFT, TOP };
        enum HarmonClosedValue { YES, NO, HALF };
        //harmony-type		- enum
        enum HoleClosedLocation { RIGHT, BOTTOM, LEFT, TOP };
        enum HoleClosedValue { YES, NO, HALF };
        //kind-value		- enum
        enum LeftCenterRight { LEFT, CENTER, RIGHT };
        enum LeftRight { LEFT, RIGHT };
        //line-end		- enum
        enum LineLength { SHORT, MEDIUM, LONG };
        enum LineShape { STRAIGHT, CURVED };
        enum LineType { SOLID, DASHED, DOTTED, WAVY };
        //margin-type		- enum
        //measure-numbering-value	- enum
        //membrane		- enum
        //metal			- enum
        enum Mute
        {
            ON, OFF, STRAIGHT, CUP, HARMONNOSTEM, HARMONSTEM, BUCKET, PLUNGER, HAT,
            SOLOTONE, PRACTICE, STOPMUTE, STOPHAND, ECHO, PALM
        };
        //note-size-type		- enum

        enum NoteTypeValue
        {
            x1024TH, x512TH, x256TH, x128TH, x64TH, x32ND, x16TH,
            EIGHTH, QUARTER, HALF, WHOLE, BREVE, LONG, MAXIMA
        };
        enum NoteheadValue
        {
            SLASH, TRIANGLE, DIAMOND, SQUARE, CROSS, X, CIRCLEX, INVERTEDTRIANGLE,
            ARROWDOWN, ARROWUP, CIRCLED, SLASHED, BACKSLASHED, NORMAL, CLUSTER, CIRCLEDOT, LEFTTRIANGLE, RECTANGLE,
            NONE, DO, RE, MI, FA, FAUP, SO, LA, TI, OTHER
        };

        //number-or-normal	- double/enum
        enum OverUnder { OVER, UNDER };
        //pedal-type		- enum
        //pitched-value		- enum
        //principal-voice-symbol		- enum
        enum RightLeftMiddle { RIGHT, LEFT, MIDDLE };
        enum SemiPitched { HIGH, MEDIUMHIGH, MEDIUM, MEDIUMLOW, LOW, VERYLOW };
        enum ShowFrets { NUMBERS, LETTERS };
        enum ShowTuplet { ACTUAL, BOTH, NONE };
        //staff-divide-symbol		- enum
        enum StaffType { OSSIA, CUE, EDITORIAL, REGULAR, ALTERNATE };
        enum StartNote { UPPER, MAIN, BELOW };
        enum StartStop { START, STOP };
        //start-stop-change-continue	- enum
        enum StartStopContinue { START, STOP, CONTINUE };
        enum StartStopDiscontinue { START, STOP, DISCONTINUE };
        enum StartStopSingle { START, STOP, SINGLE };
        enum StemValue { DOWN, UP, DOUBLE, NONE };
        enum Step { A, B, C, D, E, F, G };

        //stick-location			- enum
        //stick-material			- enum
        //stick-type			- enum

        enum Syllabic { SINGLE, BEGIN, END, MIDDLE };
        enum SymbolSize { FULL, F, GRACECUE, LARGE };
        enum TapHand { LEFT, RIGHT };
        enum TextDirection { LTR, RTL, LRO, RLO };
        enum TiedType { START, STOP, CONTINUE, LETRING };
        enum TimeRelation { PARENTHESES, BRACKET, EQUALS, SLASH, SPACE, HYPHEN };
        enum TimeSeparator { NONE, HORIZONTAL, DIAGONAL, VERTICAL, ADJACENT };
        enum TimeSymbol { COMMON, CUT, SINGLENUMBER, NOTE, DOTTEDNOTE, NORMAL };
        //tip-direction			- enum
        enum TopBottom { TOP, BOTTOM };
        enum TremoloType { START, STOP, SINGLE, UNMEASURED };
        enum TrillStep { WHOLE, HALF, UNISON };
        enum TwoNoteTurn { WHOLE, HALF, NONE };
        //up-down-stop-continue		- enum
        enum UpDown { UP, DOWN };
        enum UprightInverted { UPRIGHT, INVERTED };
        enum VAlign { TOP, MIDDLE, BOTTOM, BASELINE };
        enum VAlignImage { TOP, MIDDLE, BOTTOM };
        //wedge-type			- enum
        enum Winged { NONE, STRAIGHT, CURVED, DOUBLESTRAIGHT, DOUBLECURVED };
        //wood				- enum
    }
}
