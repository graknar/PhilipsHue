using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Group
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("lights")]
		public List<string> Lights { get; set; }

		[JsonProperty("sensors")]
		public List<string> Sensors { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("state")]
		public GroupState State { get; set; }

		[JsonProperty("recycle")]
		public bool Recycle { get; set; }

		[JsonProperty("class")]
		public string Class { get;set;}

		[JsonProperty("action")]
		public GroupAction Action { get; set; }
    }

	public class GroupState
    {

		[JsonProperty("all_on")]
		public bool AllOn { get; set; }

		[JsonProperty("any_on")]
		public bool AnyOn { get; set; }
    }
	public class GroupAction 
	{
		[JsonProperty("on")]
		public bool IsOn { get; set; }

		[JsonProperty("bri")]
		public int Brightness { get; set; }

		[JsonProperty("ct")]
		public int ColorTemperature { get; set; }

		[JsonProperty("alert")]
		public string Alert { get; set; }

		[JsonProperty("colormode")]
		public string ColorMode { get; set; }
	}
}
