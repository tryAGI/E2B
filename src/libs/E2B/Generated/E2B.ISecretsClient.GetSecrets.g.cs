#nullable enable

namespace E2B
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// List project secrets<br/>
        /// List the project's secrets. No response carries a secret value.
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.Secret>> GetSecretsAsync(
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List project secrets<br/>
        /// List the project's secrets. No response carries a secret value.
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.Secret>>> GetSecretsAsResponseAsync(
            string? nextToken = default,
            int? limit = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}