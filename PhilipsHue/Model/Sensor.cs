using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Sensor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("modelid")]
        public string ModelId { get; set; }

        [JsonProperty("manufacturername")]
        public string ManufacturerName { get;set;}

        [JsonProperty("swversion")]
        public string SoftwareVersion { get; set; }

        [JsonProperty("productname")]
        public string ProductName { get; set; }

        [JsonProperty("diversityid")]
        public string DiversityId { get; set; }

        [JsonProperty("uniqueid")]
        public string UniqueId { get; set; }

        [JsonProperty("recycle")]
        public Nullable<bool> Recycle { get; set; }

        [JsonProperty("state")]
        public SensorState State { get; set; }

        [JsonProperty("config")]
        public SensorConfig Config { get; set; }

        [JsonProperty("capabilities")]
        public SensorCapabilites Capabilities { get; set; }

        [JsonProperty("swupdate")]
        public SensorSoftwareUpdate SoftwareUpdate { get; set; }
    }
    public class SensorCapabilites
    {
        [JsonProperty("certified")]
        public bool Certified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inputs")]
        public List<SensorInput> Inputs { get; set; }
    }

    public class SensorInput 
    {
        [JsonProperty("repeatintervals")]
        public List<int> RepeatIntervals { get; set; }

        [JsonProperty("events")]
        public List<SensorInputEvent> Events { get; set; }
    }
    public class SensorInputEvent 
    {
        [JsonProperty("buttonevent")]
        public int ButtonEvent { get; set; }

        [JsonProperty("eventtype")]
        public string EventType { get; set; }
    }

    public class SensorSoftwareUpdate 
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("lastinstall")]
        public DateTime LastInstall { get; set; }
    }

    public class SensorState 
    {
        [JsonProperty("daylight")]
        public string DayLight { get; set; }

        [JsonProperty("lastupdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("buttonevent")]
        public Nullable<int> ButtonEvent { get; set; }
    }

    public class SensorConfig
    {
        [JsonProperty("on")]
        public bool IsOn { get; set; }

        [JsonProperty("configured")]
        public Nullable<bool> Configured { get; set; }

        [JsonProperty("sunriseoffset")]
        public Nullable<int> SunriseOffset { get; set; }

        [JsonProperty("sunsetoffset")]
        public Nullable<int> SunsetOffset { get; set; }

        [JsonProperty("battery")]
        public Nullable<int> Battery { get; set; }

        [JsonProperty("reachable")]
        public Nullable<bool> Reachable { get; set; }

        [JsonProperty("pending")]
        public List<string> Pending { get; set; }
    }
}
