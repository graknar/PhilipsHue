using System;
using System.Collections.Generic;
using System.Text;

namespace PhilipsHue
{
    public class Domain
    {
        public Lights Lights { get; set; }

        public Groups Groups { get; set; }

        public Schedules Schedules { get;set; }
    }

    public class Lights : Dictionary<string, Light> { }

    public class Groups : Dictionary<string, Group> { }

    public class Schedules : Dictionary<string, Schedule> { }
}
