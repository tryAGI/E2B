
#nullable enable

namespace E2B
{
    /// <summary>
    /// Result of one requested fork. Exactly one of sandbox or error is set: sandbox when the fork started successfully, error when it failed to start.
    /// </summary>
    public sealed partial class SandboxForkResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public global::E2B.Sandbox? Sandbox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::E2B.Error? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForkResult" /> class.
        /// </summary>
        /// <param name="sandbox"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxForkResult(
            global::E2B.Sandbox? sandbox,
            global::E2B.Error? error)
        {
            this.Sandbox = sandbox;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForkResult" /> class.
        /// </summary>
        public SandboxForkResult()
        {
        }

    }
}