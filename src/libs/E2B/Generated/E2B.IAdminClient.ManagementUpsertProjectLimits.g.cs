#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Reconcile effective limits for a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementUpsertProjectLimitsAsync(
            string projectID,

            global::E2B.ManagementProjectLimits request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reconcile effective limits for a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementUpsertProjectLimitsAsResponseAsync(
            string projectID,

            global::E2B.ManagementProjectLimits request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reconcile effective limits for a project.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="revision">
        /// The caller's version of this answer, raised whenever the limits it resolved for the project change. Delivery is over a network, so two pushes can be in flight at once and arrive in either order: this side stores the revision it accepted and drops a delivery at or below it, which is what keeps a delayed retry from putting the project back on limits it has already left.<br/>
        /// Comparable only against earlier revisions for the same project.
        /// </param>
        /// <param name="concurrentSandboxes"></param>
        /// <param name="maxSandboxLengthHours"></param>
        /// <param name="maxVcpu"></param>
        /// <param name="maxRamMb"></param>
        /// <param name="diskMb"></param>
        /// <param name="concurrentTemplateBuilds"></param>
        /// <param name="eventsTtlDays"></param>
        /// <param name="defaultFreeDiskSizeMb">
        /// The default free-space growth target when a template build request omits one. May sit anywhere at or below the maximum free-space growth target, and usually sits well below it; a delivery whose default exceeds the maximum is rejected.
        /// </param>
        /// <param name="maxFreeDiskSizeMb">
        /// The most a template build may request as its free-space growth target.
        /// </param>
        /// <param name="maxDiskSizeMb">
        /// The same ceiling as max_free_disk_size_mb, under the name it was first published with. Kept until every deployed sender and receiver speaks the other name.
        /// </param>
        /// <param name="apiTeamRpsList">
        /// Requests per second a project may make to each list endpoint. Zero disables the limit.
        /// </param>
        /// <param name="apiTeamRpsDelete">
        /// Requests per second a project may make to each delete endpoint. Zero disables the limit.
        /// </param>
        /// <param name="maxSecrets">
        /// Live secrets the project may hold.
        /// </param>
        /// <param name="decidedAt">
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementUpsertProjectLimitsAsync(
            string projectID,
            long revision,
            int concurrentSandboxes,
            int maxSandboxLengthHours,
            int maxVcpu,
            long maxRamMb,
            long diskMb,
            int concurrentTemplateBuilds,
            int eventsTtlDays,
            long defaultFreeDiskSizeMb,
            long apiTeamRpsList,
            long apiTeamRpsDelete,
            int maxSecrets,
            long? maxFreeDiskSizeMb = default,
            long? maxDiskSizeMb = default,
            global::System.DateTime? decidedAt = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}