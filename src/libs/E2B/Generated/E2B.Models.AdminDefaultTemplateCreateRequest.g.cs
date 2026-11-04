
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminDefaultTemplateCreateRequest
    {
        /// <summary>
        /// Identifier of the template to make a default template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Description of the default template; blank is stored as none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDefaultTemplateCreateRequest" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template to make a default template
        /// </param>
        /// <param name="description">
        /// Description of the default template; blank is stored as none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminDefaultTemplateCreateRequest(
            string templateID,
            string? description)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDefaultTemplateCreateRequest" /> class.
        /// </summary>
        public AdminDefaultTemplateCreateRequest()
        {
        }

    }
}