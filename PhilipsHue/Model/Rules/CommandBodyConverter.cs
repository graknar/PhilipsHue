using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PhilipsHue
{
    internal class CommandBodyConverter : JsonConverter
    {
		public override object? ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.StartObject)
			{
				JObject jObject = JObject.Load(reader);

				return new GenericBodyCommand(jObject.ToString());
			}

			return null;

		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value is GenericBodyCommand)
			{
				var genericCommand = value as GenericBodyCommand;
				writer.WriteRawValue(genericCommand!.JsonString);
			}
			else
			{
				serializer.Serialize(writer, value);
			}
		}

		public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert == typeof(IActionBody));
        }
    }

	public class GenericBodyCommand : IActionBody
	{
		public string JsonString { get; set; }

		public GenericBodyCommand(string jsonString)
		{
			JsonString = jsonString;
		}

		public bool IsSceneCommand()
		{
			JObject jObject = JObject.Parse(this.JsonString);

			return jObject["scene"] != null || jObject["Scene"] != null;
		}

		public ScheduleActionBody AsScheduleActionBody()
		{
			return JsonConvert.DeserializeObject<ScheduleActionBody>(this.JsonString);
		}

		public GroupActionBody AsGroupActionBody()
		{
			return JsonConvert.DeserializeObject<GroupActionBody>(this.JsonString);
		}

		public SensorActionBody AsSensorActionBody()
		{
			return JsonConvert.DeserializeObject<SensorActionBody>(this.JsonString);
		}
	}
}
