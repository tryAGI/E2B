
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxPauseRequest
    {
        /// <summary>
        /// Whether to capture a full memory snapshot. When false, only the filesystem is persisted and resuming the sandbox cold-boots (reboots) it from disk, losing in-memory state, running processes, and open connections. Resume it with an explicit request (connect or resume); auto-resume, which can be triggered by arbitrary traffic, refuses such a sandbox. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public bool? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPauseRequest" /> class.
        /// </summary>
        /// <param name="memory">
        /// Whether to capture a full memory snapshot. When false, only the filesystem is persisted and resuming the sandbox cold-boots (reboots) it from disk, losing in-memory state, running processes, and open connections. Resume it with an explicit request (connect or resume); auto-resume, which can be triggered by arbitrary traffic, refuses such a sandbox. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPauseRequest(
            bool? memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPauseRequest" /> class.
        /// </summary>
        public SandboxPauseRequest()
        {
        }

    }
}