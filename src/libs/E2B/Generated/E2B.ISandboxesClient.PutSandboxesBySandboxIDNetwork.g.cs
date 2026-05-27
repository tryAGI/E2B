#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update the network configuration for a running sandbox. Replaces the current egress rules with the provided configuration. Omitting a field clears it.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task PutSandboxesBySandboxIDNetworkAsync(
            string sandboxID,

            global::E2B.SandboxNetworkUpdateConfig request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the network configuration for a running sandbox. Replaces the current egress rules with the provided configuration. Omitting a field clears it.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> PutSandboxesBySandboxIDNetworkAsResponseAsync(
            string sandboxID,

            global::E2B.SandboxNetworkUpdateConfig request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the network configuration for a running sandbox. Replaces the current egress rules with the provided configuration. Omitting a field clears it.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="allowOut">
        /// List of allowed destinations for egress traffic. Each entry can be a CIDR block (e.g. "8.8.8.8/32"), a bare IP address (e.g. "8.8.8.8"), or a domain name (e.g. "example.com", "*.example.com"). Allowed entries always take precedence over denied entries.
        /// </param>
        /// <param name="denyOut">
        /// List of denied CIDR blocks or IP addresses for egress traffic. Domain names are not supported for deny rules.
        /// </param>
        /// <param name="rules">
        /// Per-domain transform rules. Replaces all existing rules when provided.
        /// </param>
        /// <param name="allowInternetAccess">
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutSandboxesBySandboxIDNetworkAsync(
            string sandboxID,
            global::System.Collections.Generic.IList<string>? allowOut = default,
            global::System.Collections.Generic.IList<string>? denyOut = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? rules = default,
            bool? allowInternetAccess = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}