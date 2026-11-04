
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
        /// The pause checks that the sandbox guest agent answers before it takes the snapshot. By default an unresponsive agent is recorded on the snapshot and the pause proceeds; the sandbox then shows `envdUnresponsiveAtPause` and a later resume must ask for `memory: false`, since restoring that memory would bring the unresponsive agent back. With this true, the pause is instead refused with 503 while the agent does not answer, and the sandbox keeps running. A filesystem-only pause (`memory: false`) is always refused while the agent does not answer, whatever this says.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireHealthyGuest")]
        public bool? RequireHealthyGuest { get; set; }

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
        /// <param name="requireHealthyGuest">
        /// The pause checks that the sandbox guest agent answers before it takes the snapshot. By default an unresponsive agent is recorded on the snapshot and the pause proceeds; the sandbox then shows `envdUnresponsiveAtPause` and a later resume must ask for `memory: false`, since restoring that memory would bring the unresponsive agent back. With this true, the pause is instead refused with 503 while the agent does not answer, and the sandbox keeps running. A filesystem-only pause (`memory: false`) is always refused while the agent does not answer, whatever this says.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPauseRequest(
            bool? memory,
            bool? requireHealthyGuest)
        {
            this.Memory = memory;
            this.RequireHealthyGuest = requireHealthyGuest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPauseRequest" /> class.
        /// </summary>
        public SandboxPauseRequest()
        {
        }

    }
}