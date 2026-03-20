#nullable enable

namespace E2B
{
    public partial interface IAccessTokensClient
    {
        /// <summary>
        /// Delete an access token
        /// </summary>
        /// <param name="accessTokenID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAccessTokensByAccessTokenIDAsync(
            string accessTokenID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}