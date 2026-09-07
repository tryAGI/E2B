
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectSandbox
    {
        /// <summary>
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Timeout { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectSandbox" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </param>
        /// <param name="memory">
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectSandbox(
            int timeout,
            bool? memory)
        {
            this.Timeout = timeout;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectSandbox" /> class.
        /// </summary>
        public ConnectSandbox()
        {
        }

    }
}