
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAlias
    {
        /// <summary>
        /// Identifier of the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Identifier of the template the alias resolves to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// The alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Namespace of the alias, or null for an alias that resolves for every team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Whether building the template under another name replaces the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRenamable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRenamable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAlias" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the alias
        /// </param>
        /// <param name="templateID">
        /// Identifier of the template the alias resolves to
        /// </param>
        /// <param name="alias">
        /// The alias
        /// </param>
        /// <param name="isRenamable">
        /// Whether building the template under another name replaces the alias
        /// </param>
        /// <param name="namespace">
        /// Namespace of the alias, or null for an alias that resolves for every team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAlias(
            global::System.Guid id,
            string templateID,
            string alias,
            bool isRenamable,
            string? @namespace)
        {
            this.Id = id;
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Namespace = @namespace;
            this.IsRenamable = isRenamable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAlias" /> class.
        /// </summary>
        public AdminTemplateAlias()
        {
        }

    }
}