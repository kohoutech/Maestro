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
        enum AccidentalValue {SHARP, NATURAL, FLAT, DOUBLESHARP, SHARPSHARP, FLATFLAT, NATURALSHARP, NATURALFLAT,
                QUARTERFLAT, QUARTERSHARP, THREEQUARTERSFLAT, THREEQUARTERSSHARP, SHARPDOWN, SHARPUP,
                NATURALDOWN, NATURALUP, FLATDOWN, FLATUP, DOUBLESHARPDOWN, DOUBLESHARPUP, FLATFLATDOWN, FLATFLATUP,
                ARROWDOWN, ARROWUP, TRIPLESHARP, TRIPLEFLAT, SLASHQUARTERSHARP, SLASHSHARP, SLASHFLAT, DOUBLESLASHFLAT,
                SHARP1, SHARP2, SHARP3, SHARP5, FLAT1, FLAT2, FLAT3, FLAT4, SORI, KORON, OTHER }

enum ArrowDirection {LEFT, UP, RIGHT, DOWN, NORTHWEST, NORTHEAST, SOUTHEAST, SOUTHWEST,
                     LEFTRIGHT, UPDOWN, NORTHWESTSOUTHEAST, NORTHEASTSOUTHWEST, OTHER}

enum ArrowStyle {
SINGLE,
DOUBLE,
FILLED,
HOLLOW,
PAIRED,
COMBINED,
OTHER}

//backward-forward	- enum
//bar-style		- enum

        enum beam-value {
BEGIN,
CONTINUE,
END,
FORWARD HOOK,
BACKWARD HOOK}

//beater-value		- enum

enum breath-mark-value {
NONE,
COMMA,
TICK,
UPBOW,
SALZEDO}

    enum caesura-value {
NORMAL,
THICK,
SHORT,
CURVED,
SINGLE,
NONE}
//cancel-location		- enum

        enum circular-arrow {
CLOCKWISE,
ANTICLOCKWISE}
//clef-sign		- enum
//css-font-size		- enum
//degree-symbol-value	- enum
//degree-type-value	- enum
//effect			- enum
//enclosure-shape		- enum

            
            enum fan {
ACCEL,
RIT,
NONE}
//fermata-shape		- enum
//font-size		- double/enum
//font-style		- enum
//font-weight		- enum
//glass-value		- enum
//group-barline-value	- enum
//group-symbol-value	- enum

                enum handbell-value {
BELLTREE,
DAMP,
ECHO,
GYRO,
HAND MARTELLATO,
MALLET LIFT,
MALLET TABLE,
MARTELLATO,
MARTELLATO LIFT,
MUTED MARTELLATO,
PLUCK LIFT,
SWING}

                    enum harmon-closed-location {
RIGHT,
BOTTOM,
LEFT,
TOP}

                        enum harmon-closed-value {
YES,
NO,
HALF}
//harmony-type		- enum
enum hole-closed-location {
RIGHT,
BOTTOM,
LEFT,
TOP}

    enum hole-closed-value {
YES,
NO,
HALF}
//kind-value		- enum
//left-center-right	- enum
//left-right		- enum
//line-end		- enum
//line-length		- enum
//line-shape		- enum
//line-type		- enum
//margin-type		- enum
//measure-numbering-value	- enum
//membrane		- enum
//metal			- enum
//mute			- enum
//note-size-type		- enum

        enum note-type-value {
1024TH,
512TH,
256TH,
128TH,
64TH,
32ND,
16TH,
EIGHTH,
QUARTER,
HALF,
WHOLE,
BREVE,
LONG,
MAXIMA}

        enum notehead-value {
SLASH,
TRIANGLE,
DIAMOND,
SQUARE,
CROSS,
X,
CIRCLE-X,
INVERTED TRIANGLE,
ARROW DOWN,
ARROW UP,
CIRCLED,
SLASHED,
BACK SLASHED,
NORMAL,
CLUSTER,
CIRCLE DOT,
LEFT TRIANGLE,
RECTANGLE,
NONE,
DO,
RE,
MI,
FA,
FA UP,
SO,
LA,
TI,
OTHER}
//number-or-normal	- double/enum
//over-under		- enum
//pedal-type		- enum
//pitched-value		- enum
//principal-voice-symbol		- enum
//right-left-middle		- enum
//semi-pitched			- enum
//show-frets			- enum

enum show-tuplet {
ACTUAL,
BOTH,
NONE}
//staff-divide-symbol		- enum
//staff-type			- enum
//start-note			- enum
//start-stop			- enum
//start-stop-change-continue	- enum
//start-stop-continue		- enum
//start-stop-discontinue		- enum
//start-stop-single		- enum

    enum stem-value {
DOWN,
UP,
DOUBLE,
NONE}

        enum step {
A,
B,
C,
D,
E,
F,
G}
//stick-location			- enum
//stick-material			- enum
//stick-type			- enum

            enum syllabic {
SINGLE,
BEGIN,
END,
MIDDLE}
//symbol-size			- enum

                enum tap-hand {
LEFT,
RIGHT}
//text-direction			- enum
//tied-type			- enum
//time-relation			- enum
//time-separator			- enum
//time-symbol			- enum
//tip-direction			- enum
//top-bottom			- enum
//tremolo-type			- enum
//trill-step			- enum
//two-note-turn			- enum
//up-down-stop-continue		- enum
//up-down				- enum
//upright-inverted		- enum
//valign				- enum
//valign-image			- enum
//wedge-type			- enum
//winged				- enum
//wood				- enum


    }
}
