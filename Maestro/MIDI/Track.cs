/* ----------------------------------------------------------------------------
Transonic MIDI Library
Copyright (C) 1997-2017  George E Greaney

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

namespace Transonic.MIDI
{
    public class Track
    {
        public int number;
        public String name;
        public List<Event> events;

        public bool mute;
        public int OutputDevice;
        public int OutputChannel;
        
        public int keyOfs;
        public int VelOfs;
        public int TimeOfs;

        public int bankNum;
        public int patchNum;
        public int volume;
        public int pan;

        public int duration;

        public Track(int _num)
        {
            number = _num;
            name = "Track " + number.ToString();
            events = new List<Event>();
            mute = false;
        }

        public void addEvent(Event evt)
        {
            events.Add(evt);
        }

        public void finalizeLoad() 
        {
            duration = (int)events[events.Count - 1].time;
            setTrackName();
        }

        //scan track for name meta event, use the first one we find (should be only one)
        public void setTrackName() 
        {

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].msg is TrackNameMessage)
                {
                    TrackNameMessage nameMsg = (TrackNameMessage)events[i].msg;
                    name = nameMsg.trackName;
                    break;
                }
            }
        }

        public void dump()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].dump();
            }
        }
    }
}
