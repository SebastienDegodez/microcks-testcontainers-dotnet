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

using System.Text.Json.Serialization;

namespace Microcks.Testcontainers.Model;

/// <summary>
/// Domain object representing a Microservice operation / action invocation request.
/// </summary>
public class Request : Message
{

    /// <summary>
    /// Gets or sets the id of the request.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the responseId of the request.
    /// </summary>
    [JsonPropertyName("responseId")]
    public string ResponseId { get; set; }

    /// <summary>
    /// Gets or sets the queryParameters of the request.
    /// </summary>
    [JsonPropertyName("queryParameters")]
    public List<Parameter> QueryParameters { get; set; }
}