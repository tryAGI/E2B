
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliasCreateRequest
    {
        /// <summary>
        /// Identifier of the template the alias resolves to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// The alias, without a namespace or tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasCreateRequest" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template the alias resolves to
        /// </param>
        /// <param name="alias">
        /// The alias, without a namespace or tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliasCreateRequest(
            string templateID,
            string alias)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasCreateRequest" /> class.
        /// </summary>
        public AdminTemplateAliasCreateRequest()
        {
        }

    }
}