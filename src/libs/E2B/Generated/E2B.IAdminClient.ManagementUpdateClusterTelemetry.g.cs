#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Update the telemetry identity of an existing cluster.<br/>
        /// Changes only the telemetry client mapping. Missing or deleting clusters are refused; connection settings, credentials and names are preserved.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementUpdateClusterTelemetryAsync(
            string clusterID,

            global::E2B.ManagementUpdateClusterTelemetryRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the telemetry identity of an existing cluster.<br/>
        /// Changes only the telemetry client mapping. Missing or deleting clusters are refused; connection settings, credentials and names are preserved.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementUpdateClusterTelemetryAsResponseAsync(
            string clusterID,

            global::E2B.ManagementUpdateClusterTelemetryRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the telemetry identity of an existing cluster.<br/>
        /// Changes only the telemetry client mapping. Missing or deleting clusters are refused; connection settings, credentials and names are preserved.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="telemetryClientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementUpdateClusterTelemetryAsync(
            string clusterID,
            string telemetryClientId,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}