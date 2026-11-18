
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateBuildWithTagsVariant2
    {
        /// <summary>
        /// Tags of the template that point at this build. A tag points at the latest ready build it was assigned to, the build a sandbox created with that tag starts from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildWithTagsVariant2" /> class.
        /// </summary>
        /// <param name="tags">
        /// Tags of the template that point at this build. A tag points at the latest ready build it was assigned to, the build a sandbox created with that tag starts from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBuildWithTagsVariant2(
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildWithTagsVariant2" /> class.
        /// </summary>
        public TemplateBuildWithTagsVariant2()
        {
        }

    }
}