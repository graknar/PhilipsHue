using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class Group
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("lights")]
		public string[] Lights { get; set; }

		[JsonPropertyName("sensors")]
		public string[] Sensors { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("state")]
		public GroupState State { get; set; }

		[JsonPropertyName("recycle")]
		public bool Recycle { get; set; }

		[JsonPropertyName("class")]
		public string Class { get;set;}

		[JsonPropertyName("action")]
		public GroupAction Action { get; set; }
    }

	public class GroupState
    {

		[JsonPropertyName("all_on")]
		public bool All_on { get; set; }

		[JsonPropertyName("any_on")]
		public bool Any_on { get; set; }
    }
	public class GroupAction 
	{
		[JsonPropertyName("on")]
		public bool IsOn { get; set; }

		[JsonPropertyName("bri")]
		public int Brightness { get; set; }

		[JsonPropertyName("ct")]
		public int ColorTemperature { get; set; }

		[JsonPropertyName("alert")]
		public string Alert { get; set; }

		[JsonPropertyName("colormode")]
		public string ColorMode { get; set; }
	}
}
