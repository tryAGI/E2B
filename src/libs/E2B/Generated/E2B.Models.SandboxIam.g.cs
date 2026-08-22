
#nullable enable

namespace E2B
{
    /// <summary>
    /// Sandbox workload identity configuration. A non-empty, valid tokens map enables workload identity for the sandbox.
    /// </summary>
    public sealed partial class SandboxIam
    {
        /// <summary>
        /// Named workload-token definitions, keyed by a caller-chosen token name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.Dictionary<string, global::E2B.SandboxIamToken>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxIam" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Named workload-token definitions, keyed by a caller-chosen token name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxIam(
            global::System.Collections.Generic.Dictionary<string, global::E2B.SandboxIamToken>? tokens)
        {
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxIam" /> class.
        /// </summary>
        public SandboxIam()
        {
        }

    }
}