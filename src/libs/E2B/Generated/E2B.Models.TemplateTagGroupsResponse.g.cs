
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagGroupsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TemplateTagGroup> Tags { get; set; }

        /// <summary>
        /// Cursor to pass as `tagsCursor` for the next page, or `null` if there is no next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagGroupsResponse" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="nextCursor">
        /// Cursor to pass as `tagsCursor` for the next page, or `null` if there is no next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagGroupsResponse(
            global::System.Collections.Generic.IList<global::E2B.TemplateTagGroup> tags,
            string? nextCursor)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagGroupsResponse" /> class.
        /// </summary>
        public TemplateTagGroupsResponse()
        {
        }

    }
}