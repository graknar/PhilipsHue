using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class Config
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("zigbeechannel")]
		public int ZigbeeChannel { get; set; }

		[JsonPropertyName("bridgeid")]
		public string BridgeId { get; set; }

		[JsonPropertyName("mac")]
		public string Mac { get; set; }

		[JsonPropertyName("dhcp")]
		public bool DHCP { get; set; }

		[JsonPropertyName("ipaddress")]
		public string IpAddress { get; set; }

		[JsonPropertyName("netmask")]
		public string Netmask { get; set; }

		[JsonPropertyName("gateway")]
		public string Gateway { get; set; }

		[JsonPropertyName("proxyaddress")]
		public string ProxyAddress { get; set; }

		[JsonPropertyName("proxyport")]
		public int ProxyPort { get; set; }

		[JsonPropertyName("UTC")]
		public DateTime UTC { get; set; }

		[JsonPropertyName("localtime")]
		public DateTime LocalTime { get; set; }

		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }

		[JsonPropertyName("modelid")]
		public string ModelId { get; set; }

		[JsonPropertyName("datastoreversion")]
		public string DataStoreVersion { get; set; }

		[JsonPropertyName("swversion")]
		public string SoftwareVersion { get; set; }

		[JsonPropertyName("apiversion")]
		public string ApiVersion { get; set; }

		[JsonPropertyName("linkbutton")]
		public bool LinkButton { get; set; }

		[JsonPropertyName("portalservices")]
		public bool PortalServices { get; set; }

		[JsonPropertyName("portalconnection")]
		public string PortalConnection { get; set; }

		[JsonPropertyName("factorynew")]
		public bool FactoryNew { get; set; }

		[JsonPropertyName("replacesbridgeid")]
		public string ReplacesBridgeId { get; set; }

		[JsonPropertyName("starterkitid")]
		public string StarterKitId { get; set; }

		[Obsolete]
		[JsonPropertyName("swupdate")]
		public SoftwareUpdate SoftwareUpdate { get; set; }

		[JsonPropertyName("swupdate2")]
		public SoftwareUpdateV2 SoftwareUpdateV2 { get; set; }

		[JsonPropertyName("portalstate")]
		public PortalState PortalState { get; set; }

		[JsonPropertyName("backup")]
		public Backup Backup { get; set; }

		[JsonPropertyName("internetservices")]
		public InternetServices InternetServices {get;set;}

		[JsonPropertyName("whitelist")]
		public Dictionary<string,Whitelist> Whitelist { get; set; }	
	}

	public class Whitelist
	{
		[JsonPropertyName("last use date")]
		public DateTime LastUseDate { get; set; }

		[JsonPropertyName("create date")]
		public DateTime CreateDate { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}

	public class InternetServices
	{
		[JsonPropertyName("internet")]
		public string Internet { get; set; }

		[JsonPropertyName("remoteaccess")]
		public string RemoteAccess { get; set; }

		[JsonPropertyName("time")]
		public string Time { get; set; }

		[JsonPropertyName("swupdate")]
		public string SoftwareUpdate { get; set; }
	}

	public class Backup
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("errorcode")]
		public int ErrorCode { get; set; }
	}

	public class SoftwareUpdateV2
	{
		[JsonPropertyName("checkforupdate")]
		public bool CheckForUpdate { get; set; }

		[JsonPropertyName("lastchange")]
		public DateTime LastChange { get; set; }

		[JsonPropertyName("state")]
		public string State { get; set; }

		[JsonPropertyName("autoinstall")]
		public AutoInstall AutoInstall { get; set; }
	}

	public class SoftwareUpdateV2Bridge
	{
		[JsonPropertyName("state")]
		public string State { get; set; }

		[JsonPropertyName("lastinstall")]
		public DateTime LastInstall { get; set; }
	}

	public class AutoInstall
	{

		[JsonPropertyName("on")]
		public bool IsOn { get; set; }

		[JsonPropertyName("updatetime")]
		//T14:00:00
		public string UpdateTime { get; set; }
	}

	public class PortalState
	{
		[JsonPropertyName("communication")]
		public string Communication { get; set; }

		[JsonPropertyName("signedon")]
		public bool Signedon { get; set; }

		[JsonPropertyName("incoming")]
		public bool Incoming { get; set; }

		[JsonPropertyName("outgoing")]
		public bool Outgoing { get; set; }
	}

	[Obsolete]
	public class SoftwareUpdate
	{
		[JsonPropertyName("updatestate")]
		public int UpdateState { get; set; }

		[JsonPropertyName("checkforupdate")]
		public bool CheckForUpdate { get; set; }

		[JsonPropertyName("url")]
		public string Url { get; set; }

		[JsonPropertyName("text")]
		public string Text { get; set; }

		[JsonPropertyName("notify")]
		public bool Notify { get; set; }

		[JsonPropertyName("devicetypes")]
		public DeviceType DeviceTypes { get; set; }
	}

	public class DeviceType
	{
		[JsonPropertyName("bridge")]
		public bool Bridge { get; set; }

		[JsonPropertyName("lights")]
		public string[] Lights { get; set; }

		[JsonPropertyName("sensors")]
		public string[] Sensors { get; set; }
	}
}
