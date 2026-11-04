
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminDefaultTemplate
    {
        /// <summary>
        /// Identifier of the default template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Description of the default template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDefaultTemplate" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the default template
        /// </param>
        /// <param name="description">
        /// Description of the default template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminDefaultTemplate(
            string templateID,
            string? description)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDefaultTemplate" /> class.
        /// </summary>
        public AdminDefaultTemplate()
        {
        }

    }
}