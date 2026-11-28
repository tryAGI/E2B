
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliasResolution
    {
        /// <summary>
        /// The name as given
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The template holding the name as an alias without a namespace, null when none does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naked")]
        public global::E2B.AdminResolvedTemplate? Naked { get; set; }

        /// <summary>
        /// The template holding the name in the requested namespace, null when none does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaced")]
        public global::E2B.AdminResolvedTemplate? Namespaced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolution" /> class.
        /// </summary>
        /// <param name="name">
        /// The name as given
        /// </param>
        /// <param name="naked">
        /// The template holding the name as an alias without a namespace, null when none does
        /// </param>
        /// <param name="namespaced">
        /// The template holding the name in the requested namespace, null when none does
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliasResolution(
            string name,
            global::E2B.AdminResolvedTemplate? naked,
            global::E2B.AdminResolvedTemplate? namespaced)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Naked = naked;
            this.Namespaced = namespaced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolution" /> class.
        /// </summary>
        public AdminTemplateAliasResolution()
        {
        }

    }
}