using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Scene
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("group")]
		public string Group { get; set; }

		[JsonProperty("lights")]
		public List<string> Lights { get; set; }

		[JsonProperty("owner")]
		public string Owner { get; set; }

		[JsonProperty("recycle")]
		public bool Recycle { get; set; }

		[JsonProperty("locked")]
		public bool Locked { get; set; }

		[JsonProperty("picture")]
		public string Picture { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("lastupdated")]
		public DateTime LastUpdated { get; set; }

		[JsonProperty("version")]
		public int Version { get; set; }

		[JsonProperty("appdata")]
		public AppData Appdata { get; set; }
	}

	public class AppData
    {
		[JsonProperty("version")]
		public int Version { get; set; }

		[JsonProperty("date")]
		public string Date { get; set; }
    }
}
