
#nullable enable

namespace E2B
{
    /// <summary>
    /// The newest default-tag build assignment of a sandbox's snapshot template
    /// </summary>
    public sealed partial class AdminSandboxOverviewBuild
    {
        /// <summary>
        /// Identifier of the build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildId { get; set; }

        /// <summary>
        /// Identifier of the snapshot template the build is assigned to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Tag the build is assigned under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Build status as stored, for example ready, snapshotting or waiting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Coarse build state, null when the stored group is not one of the known values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusGroup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminSandboxBuildStatusGroupJsonConverter))]
        public global::E2B.AdminSandboxBuildStatusGroup? StatusGroup { get; set; }

        /// <summary>
        /// Node that produced the build, null when it was not recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterNodeId")]
        public string? ClusterNodeId { get; set; }

        /// <summary>
        /// When the build was assigned to the template under the tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Always true, the newest assignment is the one the template resolves to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrent { get; set; }

        /// <summary>
        /// Always false, the newest assignment is already current
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restorable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Restorable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverviewBuild" /> class.
        /// </summary>
        /// <param name="buildId">
        /// Identifier of the build
        /// </param>
        /// <param name="templateId">
        /// Identifier of the snapshot template the build is assigned to
        /// </param>
        /// <param name="tag">
        /// Tag the build is assigned under
        /// </param>
        /// <param name="status">
        /// Build status as stored, for example ready, snapshotting or waiting
        /// </param>
        /// <param name="assignedAt">
        /// When the build was assigned to the template under the tag
        /// </param>
        /// <param name="isCurrent">
        /// Always true, the newest assignment is the one the template resolves to
        /// </param>
        /// <param name="restorable">
        /// Always false, the newest assignment is already current
        /// </param>
        /// <param name="statusGroup">
        /// Coarse build state, null when the stored group is not one of the known values
        /// </param>
        /// <param name="clusterNodeId">
        /// Node that produced the build, null when it was not recorded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxOverviewBuild(
            global::System.Guid buildId,
            string templateId,
            string tag,
            string status,
            global::System.DateTime assignedAt,
            bool isCurrent,
            bool restorable,
            global::E2B.AdminSandboxBuildStatusGroup? statusGroup,
            string? clusterNodeId)
        {
            this.BuildId = buildId;
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusGroup = statusGroup;
            this.ClusterNodeId = clusterNodeId;
            this.AssignedAt = assignedAt;
            this.IsCurrent = isCurrent;
            this.Restorable = restorable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverviewBuild" /> class.
        /// </summary>
        public AdminSandboxOverviewBuild()
        {
        }

    }
}