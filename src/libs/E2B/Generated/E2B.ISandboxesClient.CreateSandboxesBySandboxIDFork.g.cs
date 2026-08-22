#nullable enable

namespace E2B
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Fork sandbox<br/>
        /// Fork the sandbox: checkpoint the running sandbox in place (it is briefly paused, snapshotted with its full memory state, and resumed on its node, keeping its ID and expiration untouched) and create count new sandboxes from that snapshot. Returns one result per requested fork, each carrying either the created sandbox or the error that prevented it from starting. A non-201 status means the request failed before any fork was attempted.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>> CreateSandboxesBySandboxIDForkAsync(
            string sandboxID,

            global::E2B.SandboxForkRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork sandbox<br/>
        /// Fork the sandbox: checkpoint the running sandbox in place (it is briefly paused, snapshotted with its full memory state, and resumed on its node, keeping its ID and expiration untouched) and create count new sandboxes from that snapshot. Returns one result per requested fork, each carrying either the created sandbox or the error that prevented it from starting. A non-201 status means the request failed before any fork was attempted.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>>> CreateSandboxesBySandboxIDForkAsResponseAsync(
            string sandboxID,

            global::E2B.SandboxForkRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork sandbox<br/>
        /// Fork the sandbox: checkpoint the running sandbox in place (it is briefly paused, snapshotted with its full memory state, and resumed on its node, keeping its ID and expiration untouched) and create count new sandboxes from that snapshot. Returns one result per requested fork, each carrying either the created sandbox or the error that prevented it from starting. A non-201 status means the request failed before any fork was attempted.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Time to live for the new forked sandboxes in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="count">
        /// Number of forked sandboxes to create. All forks boot from the same snapshot, so the snapshot is captured once regardless of count. Each fork succeeds or fails independently; the outcome of each is reported in its entry of the response list.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>> CreateSandboxesBySandboxIDForkAsync(
            string sandboxID,
            int? timeout = default,
            int? count = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}