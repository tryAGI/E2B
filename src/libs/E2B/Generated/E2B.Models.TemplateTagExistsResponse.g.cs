
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagExistsResponse
    {
        /// <summary>
        /// Whether the template tag has at least one ready assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Exists { get; set; }

        /// <summary>
        /// Normalized template tag name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalizedTag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NormalizedTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagExistsResponse" /> class.
        /// </summary>
        /// <param name="exists">
        /// Whether the template tag has at least one ready assignment.
        /// </param>
        /// <param name="normalizedTag">
        /// Normalized template tag name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagExistsResponse(
            bool exists,
            string normalizedTag)
        {
            this.Exists = exists;
            this.NormalizedTag = normalizedTag ?? throw new global::System.ArgumentNullException(nameof(normalizedTag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagExistsResponse" /> class.
        /// </summary>
        public TemplateTagExistsResponse()
        {
        }

    }
}