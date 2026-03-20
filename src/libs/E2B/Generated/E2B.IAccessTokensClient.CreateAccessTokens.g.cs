#nullable enable

namespace E2B
{
    public partial interface IAccessTokensClient
    {
        /// <summary>
        /// Create a new access token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.CreatedAccessToken> CreateAccessTokensAsync(

            global::E2B.NewAccessToken request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new access token
        /// </summary>
        /// <param name="name">
        /// Name of the access token
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.CreatedAccessToken> CreateAccessTokensAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}