using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;

public class Secret
{
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("username")]
	public string Username { get; set; }

	[JsonPropertyName("password")]
	public string Password { get; set; }

	[JsonPropertyName("token")]
	public string Token { get; set; }

	[JsonPropertyName("tokenHeader")]
	public string TokenHeader { get; set; }

	[JsonPropertyName("caCertPerm")]
	public string CaCertPem { get; set; }
}
