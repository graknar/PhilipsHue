using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Config
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("zigbeechannel")]
		public int ZigbeeChannel { get; set; }

		[JsonProperty("bridgeid")]
		public string BridgeId { get; set; }

		[JsonProperty("mac")]
		public string Mac { get; set; }

		[JsonProperty("dhcp")]
		public bool DHCP { get; set; }

		[JsonProperty("ipaddress")]
		public string IpAddress { get; set; }

		[JsonProperty("netmask")]
		public string Netmask { get; set; }

		[JsonProperty("gateway")]
		public string Gateway { get; set; }

		[JsonProperty("proxyaddress")]
		public string ProxyAddress { get; set; }

		[JsonProperty("proxyport")]
		public int ProxyPort { get; set; }

		[JsonProperty("UTC")]
		public DateTime UTC { get; set; }

		[JsonProperty("localtime")]
		public DateTime LocalTime { get; set; }

		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		[JsonProperty("modelid")]
		public string ModelId { get; set; }

		[JsonProperty("datastoreversion")]
		public string DataStoreVersion { get; set; }

		[JsonProperty("swversion")]
		public string SoftwareVersion { get; set; }

		[JsonProperty("apiversion")]
		public string ApiVersion { get; set; }

		[JsonProperty("linkbutton")]
		public bool LinkButton { get; set; }

		[JsonProperty("portalservices")]
		public bool PortalServices { get; set; }

		[JsonProperty("portalconnection")]
		public string PortalConnection { get; set; }

		[JsonProperty("factorynew")]
		public bool FactoryNew { get; set; }

		[JsonProperty("replacesbridgeid")]
		public string ReplacesBridgeId { get; set; }

		[JsonProperty("starterkitid")]
		public string StarterKitId { get; set; }

		[Obsolete]
		[JsonProperty("swupdate")]
		public SoftwareUpdate SoftwareUpdate { get; set; }

		[JsonProperty("swupdate2")]
		public SoftwareUpdateV2 SoftwareUpdateV2 { get; set; }

		[JsonProperty("portalstate")]
		public PortalState PortalState { get; set; }

		[JsonProperty("backup")]
		public Backup Backup { get; set; }

		[JsonProperty("internetservices")]
		public InternetServices InternetServices {get;set;}

		[JsonProperty("whitelist")]
		public Dictionary<string,Whitelist> Whitelist { get; set; }	
	}

	public class Whitelist
	{
		[JsonProperty("last use date")]
		public DateTime LastUseDate { get; set; }

		[JsonProperty("create date")]
		public DateTime CreateDate { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class InternetServices
	{
		[JsonProperty("internet")]
		public string Internet { get; set; }

		[JsonProperty("remoteaccess")]
		public string RemoteAccess { get; set; }

		[JsonProperty("time")]
		public string Time { get; set; }

		[JsonProperty("swupdate")]
		public string SoftwareUpdate { get; set; }
	}

	public class Backup
	{
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("errorcode")]
		public int ErrorCode { get; set; }
	}

	public class SoftwareUpdateV2
	{
		[JsonProperty("checkforupdate")]
		public bool CheckForUpdate { get; set; }

		[JsonProperty("lastchange")]
		public DateTime LastChange { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("autoinstall")]
		public AutoInstall AutoInstall { get; set; }
	}

	public class SoftwareUpdateV2Bridge
	{
		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("lastinstall")]
		public DateTime LastInstall { get; set; }
	}

	public class AutoInstall
	{

		[JsonProperty("on")]
		public bool IsOn { get; set; }

		[JsonProperty("updatetime")]
		//T14:00:00
		public string UpdateTime { get; set; }
	}

	public class PortalState
	{
		[JsonProperty("communication")]
		public string Communication { get; set; }

		[JsonProperty("signedon")]
		public bool Signedon { get; set; }

		[JsonProperty("incoming")]
		public bool Incoming { get; set; }

		[JsonProperty("outgoing")]
		public bool Outgoing { get; set; }
	}

	[Obsolete]
	public class SoftwareUpdate
	{
		[JsonProperty("updatestate")]
		public int UpdateState { get; set; }

		[JsonProperty("checkforupdate")]
		public bool CheckForUpdate { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }

		[JsonProperty("notify")]
		public bool Notify { get; set; }

		[JsonProperty("devicetypes")]
		public DeviceType DeviceTypes { get; set; }
	}

	public class DeviceType
	{
		[JsonProperty("bridge")]
		public bool Bridge { get; set; }

		[JsonProperty("lights")]
		public List<string> Lights { get; set; }

		[JsonProperty("sensors")]
		public List<string> Sensors { get; set; }
	}
}
