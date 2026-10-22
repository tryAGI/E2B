
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateWithBuildsVariant2
    {
        /// <summary>
        /// List of builds for the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.TemplateBuild> Builds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWithBuildsVariant2" /> class.
        /// </summary>
        /// <param name="builds">
        /// List of builds for the template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateWithBuildsVariant2(
            global::System.Collections.Generic.IList<global::E2B.TemplateBuild> builds)
        {
            this.Builds = builds ?? throw new global::System.ArgumentNullException(nameof(builds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWithBuildsVariant2" /> class.
        /// </summary>
        public TemplateWithBuildsVariant2()
        {
        }

    }
}