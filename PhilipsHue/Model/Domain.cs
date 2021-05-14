using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Domain
    {
        [JsonProperty("lights")]
        public Lights Lights { get; set; }

        [JsonProperty("groups")]
        public Groups Groups { get; set; }

        [JsonProperty("schedules")]
        public Schedules Schedules { get;set; }

        [JsonProperty("scenes")]
        public Scenes Scenes { get; set; }

        [JsonProperty("resourcelinks")]
        public ResourceLinks ResourceLinks { get; set; }

        [JsonProperty("sensors")]
        public Sensors Sensors { get; set; }

        [JsonProperty("rules")]
        public Rules Rules { get; set; }
    }

    [JsonDictionary(Description = "Liste de Light")]
    public class Lights : Dictionary<string, Light> { }

    [JsonDictionary(Description = "Liste de Group")]
    public class Groups : Dictionary<string, Group> { }

    [JsonDictionary(Description = "Liste de Schedule")]
    public class Schedules : Dictionary<string, Schedule> { }

    [JsonDictionary(Description = "Liste de Scene")]
    public class Scenes : Dictionary<string, Scene> { }

    [JsonDictionary(Description = "Liste de ResourceLink")]
    public class ResourceLinks : Dictionary<string, ResourceLink> { }

    [JsonDictionary(Description = "Liste de Sensors")]
    public class Sensors : Dictionary<string, Sensor> { }

    [JsonDictionary(Description = "Liste de Rule")]
    public class Rules : Dictionary<string, Rule> { }
}
