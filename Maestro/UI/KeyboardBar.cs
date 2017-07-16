/* ----------------------------------------------------------------------------
Maestro : a music notation editor
Copyright (C) 1996-2017  George E Greaney

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
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using Maestro;

namespace Maestro.UI
{
    public class KeyboardBar : UserControl
    {
        public enum Range {TWENTYFIVE = 0, THIRTYSEVEN, FORTYNINE, SIXTYONE, SEVENTYSIX, EIGHTYEIGHT, FULL }
        public enum KeySize { SMALL = 0, FULL };
        
        MaestroWindow maestroWindow;

        Key[] keys;
        Key[] whitekeys;
        Key[] blackkeys;
        Rectangle keyframe;
        
        int keytop;
        int keyleft;
        int keyright;
        int keybottom;

        int whitekeycount;
        int whitekeywidth;
        int whitekeyheight;

        int blackkeycount;
        int blackkeywidth;
        int blackkeyheight;

        int octavecount;
        int octavewidth;
        int keywidth;
        int barwidth;
        int barheight;
        int keycount;
        Range range;
        KeySize size;

        public KeyboardBar(MaestroWindow _maestroWindow, Range range, KeySize size)
        {
            maestroWindow = _maestroWindow;
            InitDimensions(range, size);
            InitializeComponent();
            initKeyboard();            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KeyboardBar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.DoubleBuffered = true;
            this.Name = "KeyboardBar";
            this.Size = new System.Drawing.Size(650, 200);
            this.ResumeLayout(false);

        }


//- layout --------------------------------------------------------------------

        int[] whiteKeyCounts = { 15, 22, 29, 36, 45, 52, 75 };
        int[] whiteKeyWidths = {12,16};
        int[] whiteKeyHeights = {66,88};

        int[] blackKeyCounts = {10,15,20,25,31,36,53};
        int[] blackKeyWidths = {8,10};
        int[] blackKeyHeights = {41,55};
        int[,] blackKeyOffsets = new int[,] { { 8, 8, 8, 8, 19, 9}, { 10, 10, 10, 10, 25, 13 } };
        int[,] blackKeySpacings = new int[,] { { 13, 22, 13, 13, 23 }, { 18, 29, 18, 18, 29 } };

        int[] octaveCounts = { 2, 3, 4, 5, 5, 7, 10 };
        int[] midiBases = { 48, 48, 36, 36, 28, 21, 0 };
        int midibase;
        int midimax;
        
        private void InitDimensions(Range _range, KeySize _size)
        {
            range = _range;
            size = _size;

            keytop = 20;                //keyboard margins in widget
            keyleft = 15;
            keyright = 15;
            keybottom = 10;

            whitekeycount = whiteKeyCounts[(int)range];         
            whitekeywidth = whiteKeyWidths[(int)size];
            whitekeyheight = whiteKeyHeights[(int)size];
            
            blackkeycount = blackKeyCounts[(int)range];
            blackkeywidth = blackKeyWidths[(int)size];
            blackkeyheight = blackKeyHeights[(int)size];

            octavecount = octaveCounts[(int)range];
            octavewidth = (whitekeywidth * 7);
            keywidth = whitekeycount * whitekeywidth;
            barwidth = keyleft + keywidth + keyright;
            barheight = keytop + whitekeyheight + keybottom;
            keycount = whitekeycount + blackkeycount;
        }

        void initKeyboard()
        {
            this.ClientSize = new System.Drawing.Size(10 + 576 + 10, 113);
            keyframe = new Rectangle(keyleft, keytop, keywidth, whitekeyheight);

            //midi keys
            keys = new Key[keycount];
            midibase = midiBases[(int)range];
            midimax = midibase + keycount - 1;
            int midinum = midibase;
            for (int key = 0; key < keycount; key++)
            {
                keys[key] = new Key(midinum++);
            }

            //key colors
            whitekeys = new Key[whitekeycount];
            blackkeys = new Key[blackkeycount];

            int keynum = 0;
            int whitekeynum = 0;
            int blackkeynum = 0;

            //sort out white and black keys
            //special cases for 76 and 88 keys
            if (range == Range.SEVENTYSIX)
            {
                whitekeys[whitekeynum++] = keys[keynum++];          //low E
                whitekeys[whitekeynum++] = keys[keynum++];          //low F
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];          //low G
                blackkeys[blackkeynum++] = keys[keynum++];
            }

            if (range == Range.SEVENTYSIX || range == Range.EIGHTYEIGHT)
            {
                whitekeys[whitekeynum++] = keys[keynum++];          //low A
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];          //low B
            }

            for (int oct = 0; oct < octavecount; oct++)
            {
                whitekeys[whitekeynum++] = keys[keynum++];      //C
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];      //D
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];      //E
                whitekeys[whitekeynum++] = keys[keynum++];      //F
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];      //G
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];      //A
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];      //B
            };
            whitekeys[whitekeynum++] = keys[keynum++];      //high C

            //special cases for 76 and 128 keys
            if (range == Range.SEVENTYSIX || range == Range.FULL)
            {
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];          //high D
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];          //high E
                whitekeys[whitekeynum++] = keys[keynum++];          //high F
                blackkeys[blackkeynum++] = keys[keynum++];
                whitekeys[whitekeynum++] = keys[keynum++];          //high G
            }

            //white keys
            Rectangle whitekeyrect = new Rectangle(keyleft, keytop, whitekeywidth, whitekeyheight);
            for (int wk = 0; wk < whitekeycount; wk++)
            {
                whitekeys[wk].setShape(Key.KeyColor.WHITE, whitekeyrect);
                whitekeyrect.Offset(whitekeywidth, 0);
            }

            //black keys
            blackkeynum = 0;
            Rectangle blackkeyrect = new Rectangle(keyleft + blackKeyOffsets[(int)size,(int)range], keytop, blackkeywidth, blackkeyheight);

            //special cases for 76 and 88 keys
            if (range == Range.SEVENTYSIX)
            {
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 2], 0);
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 3], 0);
            }

            if (range == Range.SEVENTYSIX || range == Range.EIGHTYEIGHT)
            {
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 4], 0);
            }

            for (int oct = 0; oct < octavecount; oct++)
            {
                for (int i = 0; i < 5; i++)
                {
                    blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                    blackkeyrect.Offset(blackKeySpacings[(int)size, i], 0);
                }
            }

            //special cases for 76 and 128 keys
            if (range == Range.SEVENTYSIX || range == Range.FULL)
            {
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 0], 0);
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 1], 0);
                blackkeys[blackkeynum++].setShape(Key.KeyColor.BLACK, blackkeyrect);
                blackkeyrect.Offset(blackKeySpacings[(int)size, 2], 0);
            }
        }

//- i/o -----------------------------------------------------------------------

        public void setKeyDown(int midiNum)
        {
            if (midiNum >= midibase && midiNum <= midimax)
            {
                keys[midiNum - midibase].pressed = true;
                Invalidate();
            }
        }

        public void setKeyUp(int midiNum)
        {
            if (midiNum >= midibase && midiNum <= midimax)
            {
                keys[midiNum - midibase].pressed = false;
                Invalidate();
            }
        }

        public void allKeysUp()
        {
            for (int i = 0; i < keycount; i++)
            {
                keys[i].pressed = false;
            }
            Invalidate();
        }

        //- painting ------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawRectangle(Pens.Black, keyframe); //keyboard outline
            for (int i = 0; i < whitekeycount; i++)
            {
                g.DrawRectangle(Pens.Black, whitekeys[i].shape);
                g.FillRectangle(whitekeys[i].pressed ? Brushes.Red : Brushes.White, whitekeys[i].interior);
                
            }
            for (int i = 0; i < blackkeycount; i++)
            {
                g.FillRectangle(Brushes.Black, blackkeys[i].shape);
                g.FillRectangle(blackkeys[i].pressed ? Brushes.Red : Brushes.Black, blackkeys[i].interior);
            }
        }
    }

//-----------------------------------------------------------------------------

    public class Key
    {
        public enum KeyColor
        {
            WHITE,
            BLACK
        }

        public int midinum;
        public bool pressed;
        public bool sustain;
        public Rectangle shape;
        public Rectangle interior;
        public KeyColor color;

        public Key(int _midinum)
        {
            midinum = _midinum;
            pressed = false;
            sustain = false;
        }

        public void setShape(KeyColor _color, Rectangle _shape) 
        {
            color = _color;
            shape = _shape;
            interior = new Rectangle(shape.X + 1, shape.Y + 1, shape.Width - 2, shape.Height - 2);
        }
    }
}
