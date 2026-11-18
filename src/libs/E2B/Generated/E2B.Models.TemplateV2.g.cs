
#nullable enable

namespace E2B
{
    /// <summary>
    /// A template with its default build. `defaultBuild` is the build a sandbox created without a tag starts from, the latest ready build tagged default; it is absent until such a build is ready. `buildStatus` is the status of the latest build tagged default in any state: it is `building` while a rebuild runs, although sandboxes still start from the default build.
    /// </summary>
    public sealed partial class TemplateV2
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Whether the template is public or only accessible by the team
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
        /// Time when the template was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::E2B.TeamUser? CreatedBy { get; set; }

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
        /// Number of times the template was built
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BuildCount { get; set; }

        /// <summary>
        /// Whether the template is one of the platform's default templates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Description of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.TemplateBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.TemplateBuildStatus BuildStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBuild")]
        public global::E2B.TemplateBuild? DefaultBuild { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateV2" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="names">
        /// Names of the template (namespace/alias format when namespaced)
        /// </param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="createdAt">
        /// Time when the template was created
        /// </param>
        /// <param name="updatedAt">
        /// Time when the template was last updated
        /// </param>
        /// <param name="spawnCount">
        /// Number of times the template was used
        /// </param>
        /// <param name="buildCount">
        /// Number of times the template was built
        /// </param>
        /// <param name="isDefault">
        /// Whether the template is one of the platform's default templates
        /// </param>
        /// <param name="buildStatus">
        /// Status of the template build
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="lastSpawnedAt">
        /// Time when the template was last used
        /// </param>
        /// <param name="description">
        /// Description of the template
        /// </param>
        /// <param name="defaultBuild"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateV2(
            string templateID,
            global::System.Collections.Generic.IList<string> names,
            bool @public,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            long spawnCount,
            int buildCount,
            bool isDefault,
            global::E2B.TemplateBuildStatus buildStatus,
            global::E2B.TeamUser? createdBy,
            global::System.DateTime? lastSpawnedAt,
            string? description,
            global::E2B.TemplateBuild? defaultBuild)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastSpawnedAt = lastSpawnedAt;
            this.SpawnCount = spawnCount;
            this.BuildCount = buildCount;
            this.IsDefault = isDefault;
            this.Description = description;
            this.BuildStatus = buildStatus;
            this.DefaultBuild = defaultBuild;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateV2" /> class.
        /// </summary>
        public TemplateV2()
        {
        }

    }
}