#nullable enable

namespace E2B
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKeysByApiKeyIDAsync(
            string apiKeyID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}