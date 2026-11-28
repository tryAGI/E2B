
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminResolvedTemplateAlias
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminResolvedTemplateAlias" /> class.
        /// </summary>
        /// <param name="alias">
        /// The alias
        /// </param>
        /// <param name="namespace">
        /// Namespace of the alias, or null for an alias that resolves for every team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminResolvedTemplateAlias(
            string alias,
            string? @namespace)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Namespace = @namespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminResolvedTemplateAlias" /> class.
        /// </summary>
        public AdminResolvedTemplateAlias()
        {
        }

    }
}