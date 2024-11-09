using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Converter;

public class TimeSpanToMillisecondsConverter : JsonConverter<TimeSpan>
{
	public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return TimeSpan.FromMilliseconds(reader.GetInt64());
	}

	public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
	{
		writer.WriteNumberValue(value.TotalMilliseconds);
	}
}
