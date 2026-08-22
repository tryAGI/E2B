#nullable enable

namespace E2B
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Create a secret<br/>
        /// Create a secret by storing a runtime marker as its first version. The response carries metadata only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Secret> CreateSecretsAsync(

            global::E2B.NewSecret request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a secret<br/>
        /// Create a secret by storing a runtime marker as its first version. The response carries metadata only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.Secret>> CreateSecretsAsResponseAsync(

            global::E2B.NewSecret request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a secret<br/>
        /// Create a secret by storing a runtime marker as its first version. The response carries metadata only.
        /// </summary>
        /// <param name="name">
        /// Name of the secret, unique within the project. Names are lower-cased before storage and returned in that canonical form; the sec_ prefix is reserved for secret identifiers.
        /// </param>
        /// <param name="value">
        /// Runtime marker stored as the secret's first version. The runtime resolves it to a value at sandbox egress.
        /// </param>
        /// <param name="metadata">
        /// Customer metadata of the secret. Always present, empty when unset. At most 32 entries; keys are limited to 128 bytes, values to 1024 bytes, and a secret's metadata to 8192 bytes in total.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Secret> CreateSecretsAsync(
            string name,
            string value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}