using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PhilipsHue
{
    public class Schedule
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("localtime")]
		//PT00:00:10
		public string LocalTime { get; set; }

		[JsonPropertyName("time")]
		//PT00:00:10
		public string Time { get; set; }

		[JsonPropertyName("created")]
		public DateTime Created { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("autodelete")]
		public bool AutoDelete { get; set; }

		[JsonPropertyName("starttime")]
		public DateTime StartTime { get; set; }

		[JsonPropertyName("recycle")]
		public bool Recycle { get; set; }

		[JsonPropertyName("command")]
		public Command Command { get; set; }		
	}

	public class Command
	{

		[JsonPropertyName("address")]
		public string Address { get; set; }

		[JsonPropertyName("method")]
		public string Method { get; set; }

		[JsonPropertyName("body")]
		public Body Body { get; set; }
	}

	public class Body
	{

		[JsonPropertyName("status")]
		public int Status { get; set; }
	}
}
