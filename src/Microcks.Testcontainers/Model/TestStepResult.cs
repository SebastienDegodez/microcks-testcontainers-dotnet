using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;

public class TestStepResult
{
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	[JsonPropertyName("elapsedTime")]
	public int ElapsedTime { get; set; }

	[JsonPropertyName("requestName")]
	public string RequestName { get; set; }

	[JsonPropertyName("eventMessageName")]
	public string EventMessageName { get; set; }

	[JsonPropertyName("message")]
	public string Message { get; set; }
}
