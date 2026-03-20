#nullable enable

namespace E2B
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create a new team API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.CreatedTeamAPIKey> CreateKeysAsync(

            global::E2B.NewTeamAPIKey request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new team API key
        /// </summary>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.CreatedTeamAPIKey> CreateKeysAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}