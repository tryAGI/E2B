#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Register a cluster.<br/>
        /// A cluster registered here for the first time starts with deletion protection turned off. Registering an existing cluster again with the same name and auth organization updates its endpoint, TLS setting, sandbox proxy domain and token and keeps its stored deletion protection; a different name or auth organization returns a conflict with error_code cluster_registration_conflict. An invalid registration returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementRegisterClusterAsync(
            string clusterID,

            global::E2B.ManagementClusterRegistrationRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a cluster.<br/>
        /// A cluster registered here for the first time starts with deletion protection turned off. Registering an existing cluster again with the same name and auth organization updates its endpoint, TLS setting, sandbox proxy domain and token and keeps its stored deletion protection; a different name or auth organization returns a conflict with error_code cluster_registration_conflict. An invalid registration returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementRegisterClusterAsResponseAsync(
            string clusterID,

            global::E2B.ManagementClusterRegistrationRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a cluster.<br/>
        /// A cluster registered here for the first time starts with deletion protection turned off. Registering an existing cluster again with the same name and auth organization updates its endpoint, TLS setting, sandbox proxy domain and token and keeps its stored deletion protection; a different name or auth organization returns a conflict with error_code cluster_registration_conflict. An invalid registration returns 400 with error_code cluster_registration_invalid.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="name"></param>
        /// <param name="endpoint"></param>
        /// <param name="endpointTls"></param>
        /// <param name="token"></param>
        /// <param name="sandboxProxyDomain"></param>
        /// <param name="authOrgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementRegisterClusterAsync(
            string clusterID,
            string name,
            string endpoint,
            bool endpointTls,
            string token,
            string? sandboxProxyDomain = default,
            string? authOrgId = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}