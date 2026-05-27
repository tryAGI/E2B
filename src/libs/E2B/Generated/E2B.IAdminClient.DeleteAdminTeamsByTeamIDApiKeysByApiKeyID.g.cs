#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Delete team API key as admin<br/>
        /// Deletes a team API key for internal service workflows.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="apiKeyID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminTeamsByTeamIDApiKeysByApiKeyIDAsync(
            global::System.Guid teamID,
            string apiKeyID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete team API key as admin<br/>
        /// Deletes a team API key for internal service workflows.
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="apiKeyID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> DeleteAdminTeamsByTeamIDApiKeysByApiKeyIDAsResponseAsync(
            global::System.Guid teamID,
            string apiKeyID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}