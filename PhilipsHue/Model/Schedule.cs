using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PhilipsHue
{
    public class Schedule
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("localtime")]
		//PT00:00:10
		public string LocalTime { get; set; }

		[JsonProperty("time")]
		//PT00:00:10
		public string Time { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("autodelete")]
		public bool AutoDelete { get; set; }

		[JsonProperty("starttime")]
		public DateTime StartTime { get; set; }

		[JsonProperty("recycle")]
		public bool Recycle { get; set; }

		[JsonProperty("command")]
		public Command Command { get; set; }		
	}

	public class Command
	{

		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("method")]
		public string Method { get; set; }

		[JsonProperty("body")]
		public Body Body { get; set; }
	}

	public class Body
	{

		[JsonProperty("status")]
		public int Status { get; set; }
	}
}
