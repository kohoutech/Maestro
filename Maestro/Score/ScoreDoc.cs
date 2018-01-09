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
    public class ScoreDoc
    {
        public ScoreSheet sheet;
        public List<Part> parts;
        public Part curPart;

        public String filename;

//- loading -------------------------------------------------------------------

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
            while (num < xmlNodeList.Count) {
                if (xmlNodeList[num].Name.Equals("part"))             //only child type we have for now, there may be more
                {
                    Part.parsePartXML(xmlNodeList[num], doc);
                    num++;
                }
            }
        }

        private static void parseScoreTimewise(XmlNodeList xmlNodeList, ScoreDoc doc)
        {
            throw new NotImplementedException();
        }

//- cons ----------------------------------------------------------------------

        public ScoreDoc(ScoreSheet _sheet)
        {
            sheet = _sheet;
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
