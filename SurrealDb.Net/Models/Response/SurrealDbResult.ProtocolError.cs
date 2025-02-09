using System.Net;
using System.Text.Json.Serialization;

namespace SurrealDb.Net.Models.Response;

/// <summary>
/// A SurrealDB protocol error result that can be returned from a query request, either from a 400 or 500 error.
/// </summary>
public sealed class SurrealDbProtocolErrorResult : ISurrealDbErrorResult
{
    /// <summary>
    /// The HTTP status code of the error.
    /// </summary>
    [JsonPropertyName("code")]
    public HttpStatusCode Code { get; set; }

    /// <summary>
    /// Details about the error.
    /// </summary>
    [JsonPropertyName("details")]
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Description of the error.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Some information about the error.
    /// </summary>
    [JsonPropertyName("information")]
    public string Information { get; set; } = string.Empty;

    public bool IsOk => false;
}
