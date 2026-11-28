
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTemplateAliasResolveResponse
    {
        /// <summary>
        /// One entry per requested name, in request order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliasResolution> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolveResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// One entry per requested name, in request order
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTemplateAliasResolveResponse(
            global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliasResolution> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTemplateAliasResolveResponse" /> class.
        /// </summary>
        public AdminTemplateAliasResolveResponse()
        {
        }

    }
}