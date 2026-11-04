
#nullable enable

namespace E2B
{
    /// <summary>
    /// A build assigned to a sandbox's snapshot template under a tag
    /// </summary>
    public sealed partial class AdminSandboxBuild
    {
        /// <summary>
        /// Identifier of the build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// Identifier of the snapshot template the build is assigned to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

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
        /// Coarse build state derived from the build status: pending (pending,<br/>
        /// waiting), in_progress (in_progress, building, snapshotting), ready<br/>
        /// (ready, uploaded, success) or failed (any other status)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusGroup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminSandboxBuildStatusGroupJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminSandboxBuildStatusGroup StatusGroup { get; set; }

        /// <summary>
        /// Node that produced the build, null when it was not recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterNodeID")]
        public string? ClusterNodeID { get; set; }

        /// <summary>
        /// When the build was assigned to the template under this tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Whether this build is the template's newest ready assignment under<br/>
        /// the tag, the build a resume uses, regardless of the status filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrent { get; set; }

        /// <summary>
        /// Whether the restore route would accept this build: it is ready,<br/>
        /// assigned under the default tag, not the current build, and its<br/>
        /// snapshot template is not deleted
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
        /// Initializes a new instance of the <see cref="AdminSandboxBuild" /> class.
        /// </summary>
        /// <param name="buildID">
        /// Identifier of the build
        /// </param>
        /// <param name="templateID">
        /// Identifier of the snapshot template the build is assigned to
        /// </param>
        /// <param name="tag">
        /// Tag the build is assigned under
        /// </param>
        /// <param name="status">
        /// Build status as stored, for example ready, snapshotting or waiting
        /// </param>
        /// <param name="statusGroup">
        /// Coarse build state derived from the build status: pending (pending,<br/>
        /// waiting), in_progress (in_progress, building, snapshotting), ready<br/>
        /// (ready, uploaded, success) or failed (any other status)
        /// </param>
        /// <param name="assignedAt">
        /// When the build was assigned to the template under this tag
        /// </param>
        /// <param name="isCurrent">
        /// Whether this build is the template's newest ready assignment under<br/>
        /// the tag, the build a resume uses, regardless of the status filter
        /// </param>
        /// <param name="restorable">
        /// Whether the restore route would accept this build: it is ready,<br/>
        /// assigned under the default tag, not the current build, and its<br/>
        /// snapshot template is not deleted
        /// </param>
        /// <param name="clusterNodeID">
        /// Node that produced the build, null when it was not recorded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxBuild(
            global::System.Guid buildID,
            string templateID,
            string tag,
            string status,
            global::E2B.AdminSandboxBuildStatusGroup statusGroup,
            global::System.DateTime assignedAt,
            bool isCurrent,
            bool restorable,
            string? clusterNodeID)
        {
            this.BuildID = buildID;
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusGroup = statusGroup;
            this.ClusterNodeID = clusterNodeID;
            this.AssignedAt = assignedAt;
            this.IsCurrent = isCurrent;
            this.Restorable = restorable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxBuild" /> class.
        /// </summary>
        public AdminSandboxBuild()
        {
        }

    }
}