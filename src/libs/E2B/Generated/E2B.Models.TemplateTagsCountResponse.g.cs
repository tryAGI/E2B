
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagsCountResponse
    {
        /// <summary>
        /// Total distinct ready tags for the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagsCountResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total distinct ready tags for the template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagsCountResponse(
            long total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagsCountResponse" /> class.
        /// </summary>
        public TemplateTagsCountResponse()
        {
        }

    }
}