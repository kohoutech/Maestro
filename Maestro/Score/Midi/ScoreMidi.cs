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

using Transonic.MIDI;
using Transonic.Score.Symbols;

namespace Transonic.Score.Midi
{
    class ScoreMidi
    {
        public static Sequence ConvertScoreToMidi (ScoreDoc doc) 
        {
            Sequence seq = new Sequence(120);
            for (int i = 0; i < doc.parts.Count; i++)
            {
                Track track = getTrackFromPart(doc.parts[i]);
                seq.addTrack(track);
            }
            return seq;
        }

        public static Track getTrackFromPart(Part part)
        {
            Track track = new Track();
            track.name = part.id;
            for (int i = 0; i < part.staves.Count; i++)
            {
                Staff staff = part.staves[i];
                for (int j = 0; j < staff.measures.Count; j++)
                {
                    getEventsFromMeasure(track, staff.measures[j]);
                }
            }
            return track;

        }

        private static void getEventsFromMeasure(Track track, Measure measure)
        {
            for (int i = 0; i < measure.beats.Count; i++)
            {
                getEventsFromBeat(track, measure.beats[i]);
            }
        }

        private static void getEventsFromBeat(Track track, Beat beat)
        {
            foreach (Symbol sym in beat.symbols) {
                if (sym is Note)
                {
                    Message msg = new Message();
                    Event evt = new Event(0, msg);
                }
            }
        }
    }
}
