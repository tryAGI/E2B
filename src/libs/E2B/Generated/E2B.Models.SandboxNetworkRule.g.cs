
#nullable enable

namespace E2B
{
    /// <summary>
    /// Transform rule applied to egress requests matching a domain pattern.
    /// </summary>
    public sealed partial class SandboxNetworkRule
    {
        /// <summary>
        /// Transformations applied to matching egress requests before forwarding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::E2B.SandboxNetworkTransform? Transform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkRule" /> class.
        /// </summary>
        /// <param name="transform">
        /// Transformations applied to matching egress requests before forwarding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkRule(
            global::E2B.SandboxNetworkTransform? transform)
        {
            this.Transform = transform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkRule" /> class.
        /// </summary>
        public SandboxNetworkRule()
        {
        }

    }
}