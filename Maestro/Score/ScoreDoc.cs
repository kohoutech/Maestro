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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

using Transonic.Score.MusicXML;
using Transonic.Score.Symbols;

namespace Transonic.Score
{
    public class ScoreDoc
    {
        public ScoreSheet sheet;
        public List<Part> parts;
        public Part curPart;

        public String filename;

        //scoreheader
        public Work work;
        public String movementNumber;
        public String movementTitle;
        public Identification identification;
        public Defaults defaults;
        public List<Credit> credits;
        public PartList partList;


//- cons ----------------------------------------------------------------------

        public ScoreDoc(ScoreSheet _sheet)
        {
            sheet = _sheet;

            //scoreheader
            work = null;
            movementNumber = null;
            movementTitle = null;
            identification = null;
            defaults = null;
            credits = new List<Credit>();
            partList = null;

            parts = new List<Part>();
            curPart = null;
        }


//- painting ------------------------------------------------------------------

        public void paint(Graphics g)
        {
            if (curPart != null)
            {
                curPart.paint(g);
            }
        }
    }    
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
