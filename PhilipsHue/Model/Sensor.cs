using System;
using System.Collections.Generic;
using System.Text;

namespace PhilipsHue
{
    public class Sensor
    {
        public string name { get; set; }
        public string type { get; set; }
        public string modelid { get; set; }
        public string manufacturername { get;set;}
        public string swversion { get; set; }
        public string productname { get; set; }
        public string diversityid { get; set; }
        public string uniqueid { get; set; }
        public Nullable<bool> recycle { get; set; }
        public SensorState state { get; set; }
        public SensorConfig config { get; set; }
        public SensorCapabilites capabilities { get; set; }
    }
    public class SensorCapabilites 
    {
        public bool certified { get; set; }
        public bool primary { get; set; }
        public List<SensorInput> inputs { get; set; }
    }

    public class SensorInput 
    {
        public List<int> repeatintervals { get; set; }
        public List<SensorInputEvent> events { get; set; }
    }
    public class SensorInputEvent 
    {
        public int buttonevent { get; set; }
        public string eventtype { get; set; }
    }

    public class SensorSoftwareUpdate 
    {
        public string state { get; set; }
        public DateTime lastinstall { get; set; }
    }

    public class SensorState 
    {
        //String? null value possible
        public string daylight { get; set; }
        public string lastupdated { get; set; }
    }

    public class SensorConfig 
    {
        public bool on { get; set; }
        public Nullable<bool> configured { get; set; }
        public Nullable<int> sunriseoffset { get; set; }
        public Nullable<int> sunsetoffset { get; set; }
        public Nullable<int> battery { get; set; }
        public Nullable<bool> reachable { get; set; }
        public List<string> pending { get; set; }
    }
}
