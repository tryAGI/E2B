#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Create or reconcile a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ManagementProject> ManagementUpsertProjectAsync(
            string projectID,

            global::E2B.ManagementProjectUpsertRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or reconcile a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse<global::E2B.ManagementProject>> ManagementUpsertProjectAsResponseAsync(
            string projectID,

            global::E2B.ManagementProjectUpsertRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or reconcile a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="clusterId">
        /// Cluster assignment to synchronize. Omission preserves the existing assignment.
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Changing it renames the project, and its template names follow: each name held under an earlier slug is also given under the new one, and the old names keep working. A name the new slug already holds is left as it is. A slug already held on this control plane is a 409, on a rename as much as on a create.
        /// </param>
        /// <param name="email">
        /// Contact address recorded on the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.ManagementProject> ManagementUpsertProjectAsync(
            string projectID,
            string name,
            string slug,
            string email,
            global::System.Guid? clusterId = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}