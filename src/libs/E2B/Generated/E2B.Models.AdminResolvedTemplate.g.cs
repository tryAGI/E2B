
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminResolvedTemplate
    {
        /// <summary>
        /// Identifier of the template that holds the alias
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
        /// Every alias of the template, in any namespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<global::E2B.AdminResolvedTemplateAlias>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminResolvedTemplate" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template that holds the alias
        /// </param>
        /// <param name="public">
        /// Whether the template is public
        /// </param>
        /// <param name="aliases">
        /// Every alias of the template, in any namespace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminResolvedTemplate(
            string templateID,
            bool @public,
            global::System.Collections.Generic.IList<global::E2B.AdminResolvedTemplateAlias>? aliases)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Public = @public;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminResolvedTemplate" /> class.
        /// </summary>
        public AdminResolvedTemplate()
        {
        }

    }
}