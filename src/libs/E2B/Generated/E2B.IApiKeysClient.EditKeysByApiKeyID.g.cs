#nullable enable

namespace E2B
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task EditKeysByApiKeyIDAsync(
            string apiKeyID,

            global::E2B.UpdateTeamAPIKey request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="name">
        /// New name for the API key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditKeysByApiKeyIDAsync(
            string apiKeyID,
            string name,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}