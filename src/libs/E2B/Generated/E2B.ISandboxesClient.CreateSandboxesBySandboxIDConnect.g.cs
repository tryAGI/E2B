#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesBySandboxIDConnectAsync(
            string sandboxID,

            global::E2B.ConnectSandbox request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns sandbox details. If the sandbox is paused, it will be resumed. TTL is only extended.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.Sandbox> CreateSandboxesBySandboxIDConnectAsync(
            string sandboxID,
            int timeout,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}