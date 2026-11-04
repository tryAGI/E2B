
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildsStatusesResponse
    {
        /// <summary>
        /// List of build statuses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildStatuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.BuildStatusItem> BuildStatuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsStatusesResponse" /> class.
        /// </summary>
        /// <param name="buildStatuses">
        /// List of build statuses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildsStatusesResponse(
            global::System.Collections.Generic.IList<global::E2B.BuildStatusItem> buildStatuses)
        {
            this.BuildStatuses = buildStatuses ?? throw new global::System.ArgumentNullException(nameof(buildStatuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsStatusesResponse" /> class.
        /// </summary>
        public BuildsStatusesResponse()
        {
        }

    }
}