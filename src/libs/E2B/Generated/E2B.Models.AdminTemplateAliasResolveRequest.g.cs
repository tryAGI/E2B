
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliasResolveRequest
    {
        /// <summary>
        /// Namespace to resolve each name in, next to the alias without a namespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// Aliases to resolve, matched exactly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolveRequest" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace to resolve each name in, next to the alias without a namespace
        /// </param>
        /// <param name="names">
        /// Aliases to resolve, matched exactly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliasResolveRequest(
            string @namespace,
            global::System.Collections.Generic.IList<string> names)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolveRequest" /> class.
        /// </summary>
        public AdminTemplateAliasResolveRequest()
        {
        }

    }
}