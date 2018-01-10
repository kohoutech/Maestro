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

namespace Transonic.Score
{
    public class Part
    {
        public ScoreDoc score;
        public List<Staff> staves;
        public List<Measure> measures;

        public String id;

        public Part(ScoreDoc _score, String _id)
        {
            score = _score;
            id = _id;
            staves = new List<Staff>();
            measures = new List<Measure>();
        }


//- painting ------------------------------------------------------------------

        public void paint(Graphics g)
        {
            foreach (Staff staff in staves)
            {
                staff.paint(g);
            }
            foreach (Measure measure in measures)
            {
                measure.paint(g);
            }
        }


//- reading/writing -----------------------------------------------------------

        public static void parsePartXML(System.Xml.XmlNode partNode, ScoreDoc score)
        {
            XmlAttributeCollection attrs = partNode.Attributes;
            String idstr = attrs["id"].Value;                       //required attr


            Part part = new Part(score, idstr);
            score.parts.Add(part);

            foreach(XmlNode node in partNode.ChildNodes)
            {
                Measure.parseMeasureXML(node, part);                
            }
        }
    }
}

//Console.WriteLine("there's no sun in the shadow of the wizard");
