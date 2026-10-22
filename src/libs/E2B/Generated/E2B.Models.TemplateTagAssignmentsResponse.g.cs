
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagAssignmentsResponse
    {
        /// <summary>
        /// Ready assignment events for the tag, sorted latest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment> Data { get; set; }

        /// <summary>
        /// Cursor to pass to the next list request, or `null` if there is no next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagAssignmentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Ready assignment events for the tag, sorted latest first.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to pass to the next list request, or `null` if there is no next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagAssignmentsResponse(
            global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment> data,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagAssignmentsResponse" /> class.
        /// </summary>
        public TemplateTagAssignmentsResponse()
        {
        }

    }
}