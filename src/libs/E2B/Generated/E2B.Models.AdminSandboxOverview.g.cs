
#nullable enable

namespace E2B
{
    /// <summary>
    /// Who owns a sandbox and what its snapshot holds, read from the database:<br/>
    /// the team, the snapshot template and its most recent pause, and the<br/>
    /// newest default-tag build assignment of that template
    /// </summary>
    public sealed partial class AdminSandboxOverview
    {
        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        /// The team the sandbox belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminSandboxOverviewTeam Team { get; set; }

        /// <summary>
        /// Template that holds the sandbox's snapshot, null when the sandbox has no snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotTemplateId")]
        public string? SnapshotTemplateId { get; set; }

        /// <summary>
        /// What the most recent pause recorded, null when the sandbox has no snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPause")]
        public global::E2B.AdminSandboxLastPause? LastPause { get; set; }

        /// <summary>
        /// Newest default-tag build assignment of the snapshot template, null<br/>
        /// when there is no snapshot or no assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestBuild")]
        public global::E2B.AdminSandboxOverviewBuild? LatestBuild { get; set; }

        /// <summary>
        /// Number of default-tag build assignments of the snapshot template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BuildCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverview" /> class.
        /// </summary>
        /// <param name="sandboxId">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="team">
        /// The team the sandbox belongs to
        /// </param>
        /// <param name="buildCount">
        /// Number of default-tag build assignments of the snapshot template
        /// </param>
        /// <param name="snapshotTemplateId">
        /// Template that holds the sandbox's snapshot, null when the sandbox has no snapshot
        /// </param>
        /// <param name="lastPause">
        /// What the most recent pause recorded, null when the sandbox has no snapshot
        /// </param>
        /// <param name="latestBuild">
        /// Newest default-tag build assignment of the snapshot template, null<br/>
        /// when there is no snapshot or no assignment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxOverview(
            string sandboxId,
            global::E2B.AdminSandboxOverviewTeam team,
            long buildCount,
            string? snapshotTemplateId,
            global::E2B.AdminSandboxLastPause? lastPause,
            global::E2B.AdminSandboxOverviewBuild? latestBuild)
        {
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.SnapshotTemplateId = snapshotTemplateId;
            this.LastPause = lastPause;
            this.LatestBuild = latestBuild;
            this.BuildCount = buildCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverview" /> class.
        /// </summary>
        public AdminSandboxOverview()
        {
        }

    }
}