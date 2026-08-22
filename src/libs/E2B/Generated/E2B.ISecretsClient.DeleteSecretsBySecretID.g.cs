#nullable enable

namespace E2B
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Delete a secret<br/>
        /// Revoke the secret and schedule its versions for cleanup.
        /// </summary>
        /// <param name="secretID">
        /// Identifier of the secret (sec_ prefixed), or its canonical lower-case name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSecretsBySecretIDAsync(
            string secretID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a secret<br/>
        /// Revoke the secret and schedule its versions for cleanup.
        /// </summary>
        /// <param name="secretID">
        /// Identifier of the secret (sec_ prefixed), or its canonical lower-case name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> DeleteSecretsBySecretIDAsResponseAsync(
            string secretID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}