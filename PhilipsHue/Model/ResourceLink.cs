using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class ResourceLink
    {
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("classid")]
		public int ClassId { get; set; }

		[JsonProperty("owner")]
		public string Owner { get; set; }

		[JsonProperty("recycle")]
		public bool Recycle { get; set; }

		[JsonProperty("links")]
		public List<string> Links { get; set; }
	}
}
