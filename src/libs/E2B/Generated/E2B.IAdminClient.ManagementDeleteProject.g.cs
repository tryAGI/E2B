#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Soft-delete a project.<br/>
        /// Marks the project deleted and blocked, releases its cluster assignment, scrubs its name and email to DELETED and its slug to deleted-&lt;project ID&gt;, which releases the old slug for reuse, deletes its memberships and API keys, soft-deletes its templates and snapshots, and enqueues the teardown of its running sandboxes, all in one transaction. The project row remains. Afterwards the project answers 404 to other management writes. Repeating the call answers 204 and repeats every step except the deletion time: it re-blocks and re-scrubs the project, clears a cluster assignment written since, deletes any memberships, keys, templates or snapshots created since, and enqueues the teardown again.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementDeleteProjectAsync(
            string projectID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Soft-delete a project.<br/>
        /// Marks the project deleted and blocked, releases its cluster assignment, scrubs its name and email to DELETED and its slug to deleted-&lt;project ID&gt;, which releases the old slug for reuse, deletes its memberships and API keys, soft-deletes its templates and snapshots, and enqueues the teardown of its running sandboxes, all in one transaction. The project row remains. Afterwards the project answers 404 to other management writes. Repeating the call answers 204 and repeats every step except the deletion time: it re-blocks and re-scrubs the project, clears a cluster assignment written since, deletes any memberships, keys, templates or snapshots created since, and enqueues the teardown again.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementDeleteProjectAsResponseAsync(
            string projectID,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}