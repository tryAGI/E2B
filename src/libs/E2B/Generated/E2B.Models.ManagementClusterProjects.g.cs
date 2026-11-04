
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementClusterProjects
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementClusterProjects" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementClusterProjects(
            global::System.Collections.Generic.IList<global::System.Guid> projectIds)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementClusterProjects" /> class.
        /// </summary>
        public ManagementClusterProjects()
        {
        }

    }
}