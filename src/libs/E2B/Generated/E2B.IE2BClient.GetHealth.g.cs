#nullable enable

namespace E2B
{
    public partial interface IE2BClient
    {
        /// <summary>
        /// Health check
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task GetHealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}