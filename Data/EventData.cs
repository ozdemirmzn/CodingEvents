﻿using CodingEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Data
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();
        // add event
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }
        // retreive event
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }
        //retreive a single event
        public static Event GetById(int id)
        {
            return Events[id];
        }
        // remove event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}
