//
// Copyright The Microcks Authors.
//
// Licensed under the Apache License, Version 2.0 (the "License")
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//

using Microcks.Testcontainers.Converter;
using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/// <summary>
/// TestResult model for Microcks.
/// </summary>
public class TestResult
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("testNumber")]
    public int TestNumber { get; set; }

    [JsonPropertyName("testDate")]
    public long TestDate { get; set; }

    [JsonPropertyName("testedEndpoint")]
    public string TestedEndpoint { get; set; }

    [JsonPropertyName("serviceId")]
    public string ServiceId { get; set; }

    [JsonConverter(typeof(TimeSpanToMillisecondsConverter))]
    [JsonPropertyName("timeout")]
    public TimeSpan Timeout { get; set; }

    [JsonPropertyName("elapsedTime")]
    public int ElapsedTime { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("inProgress")]
    public bool InProgress { get; set; }

    [JsonPropertyName("runnerType")]
    public TestRunnerType RunnerType { get; set; }

    [JsonPropertyName("testCaseResults")]
    public List<TestCaseResult> TestCaseResults { get; set; }

    [JsonPropertyName("operationsHeaders")]
    public Dictionary<string, List<Header>> OperationsHeaders { get; set; }

    [JsonPropertyName("authorizedClient")]
    public OAuth2AuthorizedClient AuthorizedClient { get; set; }
}
