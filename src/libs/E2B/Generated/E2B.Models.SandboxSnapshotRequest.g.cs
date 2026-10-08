
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxSnapshotRequest
    {
        /// <summary>
        /// Optional name for the snapshot template. If a snapshot template with this name already exists, a new build will be assigned to the existing template instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether to capture a full memory snapshot. When false, only the filesystem is persisted: the snapshot is smaller and faster to take, and sandboxes created from it cold-boot (start fresh from disk) instead of restoring memory, so they begin without the source sandbox's running processes, in-memory state, and open connections. The source sandbox keeps running in both cases. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public bool? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxSnapshotRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional name for the snapshot template. If a snapshot template with this name already exists, a new build will be assigned to the existing template instead of creating a new one.
        /// </param>
        /// <param name="memory">
        /// Whether to capture a full memory snapshot. When false, only the filesystem is persisted: the snapshot is smaller and faster to take, and sandboxes created from it cold-boot (start fresh from disk) instead of restoring memory, so they begin without the source sandbox's running processes, in-memory state, and open connections. The source sandbox keeps running in both cases. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxSnapshotRequest(
            string? name,
            bool? memory)
        {
            this.Name = name;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxSnapshotRequest" /> class.
        /// </summary>
        public SandboxSnapshotRequest()
        {
        }

    }
}