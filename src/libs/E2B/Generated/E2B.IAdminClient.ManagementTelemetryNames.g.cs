#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Read team and cluster names for telemetry.<br/>
        /// Requires a direct mutual TLS connection from the configured telemetry reader service identity. Bearer tokens and forwarded identity headers are not accepted. Returns regional team and cluster names without connection credentials. Deleted projects and clusters being deleted are omitted.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.TelemetryNames> ManagementTelemetryNamesAsync(
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read team and cluster names for telemetry.<br/>
        /// Requires a direct mutual TLS connection from the configured telemetry reader service identity. Bearer tokens and forwarded identity headers are not accepted. Returns regional team and cluster names without connection credentials. Deleted projects and clusters being deleted are omitted.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.TelemetryNames>> ManagementTelemetryNamesAsResponseAsync(
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}