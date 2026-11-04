
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliases
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Whether the template is public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminTemplateTeam Team { get; set; }

        /// <summary>
        /// All aliases of the template, those without a namespace first
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.AdminTemplateAlias> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliases" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="public">
        /// Whether the template is public
        /// </param>
        /// <param name="team"></param>
        /// <param name="aliases">
        /// All aliases of the template, those without a namespace first
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliases(
            string templateID,
            bool @public,
            global::E2B.AdminTemplateTeam team,
            global::System.Collections.Generic.IList<global::E2B.AdminTemplateAlias> aliases)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Public = @public;
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliases" /> class.
        /// </summary>
        public AdminTemplateAliases()
        {
        }

    }
}