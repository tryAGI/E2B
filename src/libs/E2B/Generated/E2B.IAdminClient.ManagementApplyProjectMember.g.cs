#nullable enable

namespace E2B
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Apply one versioned project member projection.<br/>
        /// Applies the newest desired presence for one project member. An older or duplicate revision is accepted without changing target state.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="userID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task ManagementApplyProjectMemberAsync(
            string projectID,
            string userID,

            global::E2B.ManagementProjectMemberApplyRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply one versioned project member projection.<br/>
        /// Applies the newest desired presence for one project member. An older or duplicate revision is accepted without changing target state.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="userID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::E2B.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::E2B.AutoSDKHttpResponse> ManagementApplyProjectMemberAsResponseAsync(
            string projectID,
            string userID,

            global::E2B.ManagementProjectMemberApplyRequest request,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply one versioned project member projection.<br/>
        /// Applies the newest desired presence for one project member. An older or duplicate revision is accepted without changing target state.
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="userID"></param>
        /// <param name="revision"></param>
        /// <param name="present"></param>
        /// <param name="isDefault">
        /// Whether this membership is the user's default team. Omitted requests from older sources remain non-default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="identities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ManagementApplyProjectMemberAsync(
            string projectID,
            string userID,
            long revision,
            bool present,
            bool? isDefault = default,
            global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? identities = default,
            global::E2B.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}