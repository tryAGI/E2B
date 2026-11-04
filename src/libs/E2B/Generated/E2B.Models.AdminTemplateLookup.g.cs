
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateLookup
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminTemplateTeam Team { get; set; }

        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Whether the template is public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Time when the template was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the template was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSpawnedAt")]
        public global::System.DateTime? LastSpawnedAt { get; set; }

        /// <summary>
        /// Number of times the template was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spawnCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SpawnCount { get; set; }

        /// <summary>
        /// Whether the template is a snapshot of a sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSnapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSnapshot { get; set; }

        /// <summary>
        /// The sandbox a snapshot template was taken from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotSandboxID")]
        public string? SnapshotSandboxID { get; set; }

        /// <summary>
        /// The build the query matched, when it was a build ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchedBuildID")]
        public global::System.Guid? MatchedBuildID { get; set; }

        /// <summary>
        /// The template's newest builds of any tag and status, newest first, at most 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TemplateBuild> Builds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateLookup" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="team"></param>
        /// <param name="names">
        /// Names of the template (namespace/alias format when namespaced)
        /// </param>
        /// <param name="public">
        /// Whether the template is public
        /// </param>
        /// <param name="createdAt">
        /// Time when the template was created
        /// </param>
        /// <param name="spawnCount">
        /// Number of times the template was used
        /// </param>
        /// <param name="isSnapshot">
        /// Whether the template is a snapshot of a sandbox
        /// </param>
        /// <param name="builds">
        /// The template's newest builds of any tag and status, newest first, at most 100
        /// </param>
        /// <param name="lastSpawnedAt">
        /// Time when the template was last used
        /// </param>
        /// <param name="snapshotSandboxID">
        /// The sandbox a snapshot template was taken from
        /// </param>
        /// <param name="matchedBuildID">
        /// The build the query matched, when it was a build ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateLookup(
            string templateID,
            global::E2B.AdminTemplateTeam team,
            global::System.Collections.Generic.IList<string> names,
            bool @public,
            global::System.DateTime createdAt,
            long spawnCount,
            bool isSnapshot,
            global::System.Collections.Generic.IList<global::E2B.TemplateBuild> builds,
            global::System.DateTime? lastSpawnedAt,
            string? snapshotSandboxID,
            global::System.Guid? matchedBuildID)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.LastSpawnedAt = lastSpawnedAt;
            this.SpawnCount = spawnCount;
            this.IsSnapshot = isSnapshot;
            this.SnapshotSandboxID = snapshotSandboxID;
            this.MatchedBuildID = matchedBuildID;
            this.Builds = builds ?? throw new global::System.ArgumentNullException(nameof(builds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateLookup" /> class.
        /// </summary>
        public AdminTemplateLookup()
        {
        }

    }
}