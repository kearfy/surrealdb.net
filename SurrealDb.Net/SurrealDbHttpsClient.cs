using SurrealDb.Net.Internals.Helpers;
using System.Text.Json;

namespace SurrealDb.Net;

public static class SurrealDbHttpsClient
{
    /// <summary>
    /// Creates a new SurrealDbClient using the HTTPS protocol.
    /// </summary>
    /// <param name="host">The host name of the SurrealDB instance.</param>
    /// <param name="httpClientFactory">An IHttpClientFactory instance, or none.</param>
    /// <param name="configureJsonSerializerOptions">An optional action to configure <see cref="JsonSerializerOptions"/>.</param>
    /// <exception cref="ArgumentException">Thrown when host is not valid.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when port in host is provided but is value is out of range.</exception>
    public static ISurrealDbClient New(
        string host,
        IHttpClientFactory? httpClientFactory = null,
        Action<JsonSerializerOptions>? configureJsonSerializerOptions = null
    )
    {
        string endpoint = UriBuilderHelper.CreateEndpointFromProtocolAndHost(
            host,
            Uri.UriSchemeHttps
        );
        return new SurrealDbClient(endpoint, httpClientFactory, configureJsonSerializerOptions);
    }
}
