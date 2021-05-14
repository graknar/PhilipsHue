using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Rule
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("created")]
        public Nullable<DateTime> Created { get; set; }

        [JsonProperty("lasttriggered")]
        public string LastTriggered { get; set; }

        [JsonProperty("timestriggered")]
        public int TimesTriggered { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("recycle")]
        public bool Recycle { get; set; }

        [JsonProperty("conditions")]
        public List<RuleCondition> Conditions { get; set; }

        [JsonProperty("actions")]
        public List<RuleAction> Actions { get; set; }
    }

    public class RuleCondition
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
    public class RuleAction
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonConverter(typeof(CommandBodyConverter))]
        [JsonProperty("body")]
        public IActionBody Body { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (Body != null)
            {
                if (Body is GenericBodyCommand genericCommand)
                {
                    var invariantAddress = Address.ToLowerInvariant();

                    //Check if it is a scene command
                    if (genericCommand.IsSceneCommand())
                    {
                        Body = genericCommand.AsScheduleActionBody();
                    }
                    //If it is going to a lights or groups URL, it's probably a LightCommand
                    else if (invariantAddress.Contains("/lights") || invariantAddress.Contains("/groups"))
                    {
                        Body = genericCommand.AsGroupActionBody();
                    }
                    //If it is going to a sensor url, it's probably a SensorCommand
                    else if (invariantAddress.Contains("/sensors"))
                    {
                        Body = genericCommand.AsSensorActionBody();
                    }
                }
            }

        }
    }

    public interface IActionBody 
    { }

    public class GroupActionBody : IActionBody
    {
        [JsonProperty("on")]
        public Nullable<bool> IsOn { get; set; }

        [JsonProperty("scene")]
        public string Scene { get; set; }

        [JsonProperty("transitiontime")]
        public Nullable<int> TransitionTime { get; set; }

        [JsonProperty("bri_inc")]
        public Nullable<int> BrightnessIncrement { get; set; }
    }

    public class SensorActionBody : IActionBody
    {
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class ScheduleActionBody : IActionBody
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }
}
