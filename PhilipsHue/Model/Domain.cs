using System.Collections.Generic;

namespace PhilipsHue
{
    public class Domain
    {
        public Lights Lights { get; set; }

        public Groups Groups { get; set; }

        public Schedules Schedules { get;set; }

        public Scenes Scenes { get; set; }
    }

    public class Lights : Dictionary<string, Light> { }

    public class Groups : Dictionary<string, Group> { }

    public class Schedules : Dictionary<string, Schedule> { }

    public class Scenes : Dictionary<string, Scene> { }
}
