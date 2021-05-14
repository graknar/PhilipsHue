using System;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Light
	{
		[JsonProperty("state")]
		public LightState State {get;set;}

		[JsonProperty("swupdate")]
		public SWUpdate SoftwareUpdate { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("modelid")]
		public string ModelId { get; set; }

		[JsonProperty("manufacturername")]
		public string ManufacturerName { get; set; }

		[JsonProperty("productname")]
		public string ProductName { get; set; }

		[JsonProperty("config")]
		public LightConfig Config { get; set; }

		[JsonProperty("capabilities")]
		public LightCapabilities Capabilities { get; set; }

		[JsonProperty("uniqueid")]
		public string UniqueId { get; set; }

		[JsonProperty("swversion")]
		public string SoftwareVersion { get; set; }

		[JsonProperty("swconfigid")]
		public string SoftwareConfigId{get;set;}

		[JsonProperty("productid")]
		public string ProductId { get; set; }
	}

	public class ConfigStartup
	{

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("configured")]
		public bool Configured { get; set; }
	}

	public class LightConfig
	{

		[JsonProperty("achertype")]
		public string Achertype { get; set; }

		[JsonProperty("function")]
		public string Function { get; set; }

		[JsonProperty("direction")]
		public string Direction { get; set; }

		[JsonProperty("startup")]
		public ConfigStartup Startup { get;set; } 
	}

	public class LightState 
	{
		[JsonProperty("on")]
		public bool IsOn { get; set; }

		[JsonProperty("bri")]
		public int Brightness { get; set; }

		[JsonProperty("hue")]
		public int Hue { get; set; }

		[JsonProperty("sat")]
		public int Saturation { get; set; }

		[JsonProperty("effect")]
		public string Effect { get; set; }

		[JsonProperty("xy")]
		public double[] Position { get; set; }

		[JsonProperty("ct")]
		public int ColorTemperature { get; set; }

		[JsonProperty("alert")]
		public string Alert { get; set; }

		[JsonProperty("colormode")]
		public string ColorMode { get; set; }

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("reachable")]
		public bool Reachable { get; set; }
	}

	public class SWUpdate 
	{
		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("lastinstall")]
		public DateTime LastInstall { get; set; }
	}

	public class LightCapabilities
    {
		[JsonProperty("certified")]
		public bool Certified { get; set; }

		[JsonProperty("control")]
		public LightControl Control { get; set; }

		[JsonProperty("streaming")]
		public Streaming Streaming { get; set; }
	}
	public class LightControl
    {
		[JsonProperty("mindimlevel")]
		public int MindimLevel { get; set; }

		[JsonProperty("maxlumen")]
		public int MaxLumen { get; set; }

		[JsonProperty("colorgamuttype")]
		public string ColorGamutType { get; set; }

		[JsonProperty("colorgamut")]
		public double[][] ColorGamut { get; set; }

		[JsonProperty("ct")]
		public ColorTemperature ColorTemperature { get; set; }
	}
	public class ColorTemperature
    {
		[JsonProperty("min")]
		public int Min { get; set; }

		[JsonProperty("max")]
		public int Max { get; set; }
    }
	public class Streaming
    {
		[JsonProperty("renderer")]
		public bool Renderer { get; set; }

		[JsonProperty("proxy")]
		public bool Proxy { get; set; }
    }
}