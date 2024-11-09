using Microcks.Testcontainers.Converter;
using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;

public class Header
{
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("values")]
	[JsonConverter(typeof(ArrayToStringConverter))]
	public string Values { get; set; }

}
