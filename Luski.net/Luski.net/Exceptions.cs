﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luski.net
{
    public class Exceptions
    {

        [Serializable]
        public class MissingEventException : Exception
        {
            public string EventName;
            public MissingEventException(string Event) : base(Event) 
            {
                EventName = Event;
            }
        }
    }
}
