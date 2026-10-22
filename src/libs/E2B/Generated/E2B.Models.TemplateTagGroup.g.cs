
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateTagGroup
    {
        /// <summary>
        /// Template tag name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Ready assignment events for this tag, sorted latest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment> Assignments { get; set; }

        /// <summary>
        /// Whether more ready assignment events exist beyond the requested assignment limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagGroup" /> class.
        /// </summary>
        /// <param name="tag">
        /// Template tag name.
        /// </param>
        /// <param name="assignments">
        /// Ready assignment events for this tag, sorted latest first.
        /// </param>
        /// <param name="hasMore">
        /// Whether more ready assignment events exist beyond the requested assignment limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateTagGroup(
            string tag,
            global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment> assignments,
            bool hasMore)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Assignments = assignments ?? throw new global::System.ArgumentNullException(nameof(assignments));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateTagGroup" /> class.
        /// </summary>
        public TemplateTagGroup()
        {
        }

    }
}