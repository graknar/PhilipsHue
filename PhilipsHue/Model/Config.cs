using System;
using System.Collections.Generic;
using System.Text;

namespace PhilipsHue
{
    public class Config
    {
		public string name { get; set; }
		public int zigbeechannel { get; set; }
		public string bridgeid { get; set; }
		public string mac { get; set; }
		public bool dhcp { get; set; }
		public string ipaddress { get; set; }
		public string netmask { get; set; }
		public string gateway { get; set; }
		public string proxyaddress { get; set; }
		public int proxyport { get; set; }
		public DateTime UTC { get; set; }
		public DateTime localtime { get; set; }
		public string timezone { get; set; }
		public string modelid { get; set; }
		public string datastoreversion { get; set; }
		public string swversion { get; set; }
		public string apiversion { get; set; }
		/*
		"swupdate": {
			"updatestate": 0,
			"checkforupdate": false,
			"devicetypes": {
				"bridge": false,
				"lights": [],
				"sensors": []
			},
			"url": "",
			"text": "",
			"notify": true
		},
		"swupdate2": {
			"checkforupdate": false,
			"lastchange": "2021-04-16T12:38:23",
			"bridge": {
				"state": "noupdates",
				"lastinstall": "2021-04-16T12:36:26"
			},
			"state": "noupdates",
			"autoinstall": {
				"updatetime": "T14:00:00",
				"on": true
			}
		},
		"linkbutton": false,
		"portalservices": true,
		"portalconnection": "connected",
		"portalstate": {
			"signedon": true,
			"incoming": false,
			"outgoing": true,
			"communication": "disconnected"
		},
		"internetservices": {
			"internet": "connected",
			"remoteaccess": "connected",
			"time": "connected",
			"swupdate": "connected"
		},
		"factorynew": false,
		"replacesbridgeid": null,
		"backup": {
			"status": "idle",
			"errorcode": 0
		},
		"starterkitid": "",
		"whitelist": {
			"820fa626-7713-489f-9d3e-339bdf329949": {
				"last use date": "2021-04-21T22:35:28",
				"create date": "2021-03-16T17:51:28",
				"name": "Hue 3#Samsung SM-G985F"
			},
			"80e791af-b179-4a5f-a0b1-ebb7ce7b7e09": {
				"last use date": "2021-04-23T03:55:14",
				"create date": "2021-03-18T04:44:41",
				"name": "Hue 3#HUAWEI BKL-L09"
			},
			"G7qht-rzn3VEII1pWKzTW18p4Yu83XpRxweEehEH": {
				"last use date": "2021-04-23T17:29:08",
				"create date": "2021-04-21T19:09:22",
				"name": "my_hue_app#samsung thor"
			}
		}
         */
	}
}
