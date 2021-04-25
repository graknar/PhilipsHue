using System;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class Light
	{
		[JsonPropertyName("state")]
		public LightState State {get;set;}

		[JsonPropertyName("swupdate")]
		public SWUpdate swupdate { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("modelid")]
		public string ModelId { get; set; }

		[JsonPropertyName("manufacturername")]
		public string ManufacturerName { get; set; }

		[JsonPropertyName("productname")]
		public string ProductName { get; set; }

		[JsonPropertyName("config")]
		public LightConfig Config { get; set; }

		[JsonPropertyName("capabilities")]
		public LightCapabilities Capabilities { get; set; }

		[JsonPropertyName("uniqueid")]
		public string UniqueId { get; set; }

		[JsonPropertyName("swversion")]
		public string swversion { get; set; }

		[JsonPropertyName("swconfigid")]
		public string swconfigId{get;set;}

		[JsonPropertyName("productid")]
		public string ProductId { get; set; }
	}

	public class ConfigStartup
	{

		[JsonPropertyName("mode")]
		public string Mode { get; set; }

		[JsonPropertyName("configured")]
		public bool Configured { get; set; }
	}

	public class LightConfig
	{

		[JsonPropertyName("achertype")]
		public string Achertype { get; set; }

		[JsonPropertyName("function")]
		public string Function { get; set; }

		[JsonPropertyName("direction")]
		public string Direction { get; set; }

		[JsonPropertyName("startup")]
		public ConfigStartup Startup { get;set; } 
	}

	public class LightState 
	{
		[JsonPropertyName("on")]
		public bool IsOn { get; set; }

		[JsonPropertyName("bri")]
		public int Brightness { get; set; }

		[JsonPropertyName("hue")]
		public int Hue { get; set; }

		[JsonPropertyName("sat")]
		public int Saturation { get; set; }

		[JsonPropertyName("effect")]
		public string Effect { get; set; }

		[JsonPropertyName("xy")]
		public double[] Position { get; set; }

		[JsonPropertyName("ct")]
		public int ColorTemperature { get; set; }

		[JsonPropertyName("alert")]
		public string Alert { get; set; }

		[JsonPropertyName("colormode")]
		public string ColorMode { get; set; }

		[JsonPropertyName("mode")]
		public string Mode { get; set; }

		[JsonPropertyName("reachable")]
		public bool Reachable { get; set; }
	}

	public class SWUpdate 
	{
		[JsonPropertyName("state")]
		public string State { get; set; }

		[JsonPropertyName("lastinstall")]
		public DateTime LastInstall { get; set; }
	}

	public class LightCapabilities
    {
		[JsonPropertyName("certified")]
		public bool Certified { get; set; }

		[JsonPropertyName("control")]
		public LightControl Control { get; set; }

		[JsonPropertyName("streaming")]
		public Streaming Streaming { get; set; }
	}
	public class LightControl
    {
		[JsonPropertyName("mindimlevel")]
		public int mindimlevel { get; set; }

		[JsonPropertyName("maxlumen")]
		public int MaxLumen { get; set; }

		[JsonPropertyName("colorgamuttype")]
		public string colorgamuttype { get; set; }

		[JsonPropertyName("colorgamut")]
		public double[][] colorgamut { get; set; }

		[JsonPropertyName("ct")]
		public ColorTemperature ColorTemperature { get; set; }
	}
	public class ColorTemperature
    {
		[JsonPropertyName("min")]
		public int Min { get; set; }

		[JsonPropertyName("max")]
		public int Max { get; set; }
    }
	public class Streaming
    {
		[JsonPropertyName("renderer")]
		public bool Renderer { get; set; }

		[JsonPropertyName("proxy")]
		public bool Proxy { get; set; }
    }
}