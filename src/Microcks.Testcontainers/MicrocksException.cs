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

namespace Microcks.Testcontainers;

/// <summary>
/// Exception related to Microcks backend connection.
/// </summary>
public class MicrocksException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MicrocksException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public MicrocksException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MicrocksException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public MicrocksException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
