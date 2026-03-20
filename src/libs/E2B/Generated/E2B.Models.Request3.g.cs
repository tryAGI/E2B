
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request3
    {
        /// <summary>
        /// Optional name for the snapshot template. If a snapshot template with this name already exists, a new build will be assigned to the existing template instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional name for the snapshot template. If a snapshot template with this name already exists, a new build will be assigned to the existing template instead of creating a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request3(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        public Request3()
        {
        }
    }
}