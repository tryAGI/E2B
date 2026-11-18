#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Delete a cluster and its environments as admin<br/>
        /// Deletes a cluster after all team assignments are detached. Deletion protection on the cluster rejects the deletion, and so does a live team assignment, before anything changes. In one transaction it then soft-deletes every live template, snapshot template and paused sandbox snapshot on the cluster, releases their aliases, and releases all environment references while preserving environment and build history, and afterwards the cluster service deletes the cluster. A team assigned between those two steps returns a conflict with the templates already deleted; repeating the deletion once that team is detached completes it. The local cluster's nil ID is rejected. Repeating a completed deletion succeeds.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task AdminDeleteClusterAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a cluster and its environments as admin<br/>
        /// Deletes a cluster after all team assignments are detached. Deletion protection on the cluster rejects the deletion, and so does a live team assignment, before anything changes. In one transaction it then soft-deletes every live template, snapshot template and paused sandbox snapshot on the cluster, releases their aliases, and releases all environment references while preserving environment and build history, and afterwards the cluster service deletes the cluster. A team assigned between those two steps returns a conflict with the templates already deleted; repeating the deletion once that team is detached completes it. The local cluster's nil ID is rejected. Repeating a completed deletion succeeds.
        /// </summary>
        /// <param name="clusterID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> AdminDeleteClusterAsResponseAsync(
            string clusterID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}