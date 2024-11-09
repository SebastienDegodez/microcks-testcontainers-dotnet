using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;

public class TestCaseResult
{
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	[JsonPropertyName("elapsedTime")]
	public int ElapsedTime { get; set; }

	[JsonPropertyName("operationName")]
	public string OperationName { get; set; }

	[JsonPropertyName("testStepResults")]
	public List<TestStepResult> TestStepResults { get; set; }
}
