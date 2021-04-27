using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class ResourceLink
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("classid")]
		public int ClassId { get; set; }

		[JsonPropertyName("owner")]
		public string Owner { get; set; }

		[JsonPropertyName("recycle")]
		public bool Recycle { get; set; }

		[JsonPropertyName("links")]
		public List<string> Links { get; set; }
	}
}
