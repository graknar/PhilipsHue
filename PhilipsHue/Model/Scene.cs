using System;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class Scene
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("group")]
		public int Group { get; set; }

		[JsonPropertyName("lights")]
		public string[] Lights { get; set; }

		[JsonPropertyName("owner")]
		public string Owner { get; set; }

		[JsonPropertyName("recycle")]
		public bool Recycle { get; set; }

		[JsonPropertyName("locked")]
		public bool Locked { get; set; }

		[JsonPropertyName("picture")]
		public string Picture { get; set; }

		[JsonPropertyName("image")]
		public string Image { get; set; }

		[JsonPropertyName("lastupdated")]
		public DateTime LastUpdated { get; set; }

		[JsonPropertyName("version")]
		public int Version { get; set; }

		[JsonPropertyName("appdata")]
		public AppData Appdata { get; set; }
	}

	public class AppData
    {
		[JsonPropertyName("version")]
		public int Version { get; set; }

		[JsonPropertyName("date")]
		public string Date { get; set; }
    }
}
