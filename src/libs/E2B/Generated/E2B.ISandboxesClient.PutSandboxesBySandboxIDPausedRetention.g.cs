#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Set the paused sandbox retention<br/>
        /// Replace the sandbox's paused retention (pausedRetentionSeconds); null removes it. For a paused sandbox the clock restarts: expiresAt becomes the time of the request plus the new retention, or null when the retention is removed. A running sandbox keeps the new retention for when its current run ends.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task PutSandboxesBySandboxIDPausedRetentionAsync(
            string sandboxID,

            global::E2B.SandboxPausedRetentionRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the paused sandbox retention<br/>
        /// Replace the sandbox's paused retention (pausedRetentionSeconds); null removes it. For a paused sandbox the clock restarts: expiresAt becomes the time of the request plus the new retention, or null when the retention is removed. A running sandbox keeps the new retention for when its current run ends.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> PutSandboxesBySandboxIDPausedRetentionAsResponseAsync(
            string sandboxID,

            global::E2B.SandboxPausedRetentionRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the paused sandbox retention<br/>
        /// Replace the sandbox's paused retention (pausedRetentionSeconds); null removes it. For a paused sandbox the clock restarts: expiresAt becomes the time of the request plus the new retention, or null when the retention is removed. A running sandbox keeps the new retention for when its current run ends.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="pausedRetentionSeconds">
        /// Seconds a paused sandbox may stay unused before it is deleted, from 1 hour to 100 years. The clock restarts every time a run of the sandbox ends, by pause or by kill. Null means the sandbox is never deleted automatically.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutSandboxesBySandboxIDPausedRetentionAsync(
            string sandboxID,
            long? pausedRetentionSeconds = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}