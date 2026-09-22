
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectSandboxV2
    {
        /// <summary>
        /// Timeout in seconds from the current time after which the sandbox should expire<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public bool? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectSandboxV2" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="memory">
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectSandboxV2(
            int? timeout,
            bool? memory)
        {
            this.Timeout = timeout;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectSandboxV2" /> class.
        /// </summary>
        public ConnectSandboxV2()
        {
        }

    }
}