
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
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore. A snapshot taken while the sandbox guest agent was not responding (envdUnresponsiveAtPause) can only be resumed this way, and needs no enablement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public bool? Memory { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the memory the sandbox had when it was paused; at least that, and at most the template's maxMemoryMB, in steps of 128 MiB above its memoryMB. A sandbox that is already running keeps its size and the field is ignored. For a paused sandbox, a size the snapshot or the team cannot take is refused with 400; a size it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's memoryMB reports the size the sandbox runs with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// Online vCPU target for the sandbox when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the snapshot's cpuCount; for a resizable template (one with maxCpuCount) that count is lowered to the team's vCPU limit when above it. A requested count is at most the template's maxCpuCount (fixed-size templates accept only their cpuCount) and the team's vCPU limit, and is refused when resizable templates are not enabled for the team. Like memoryMB: a sandbox that is already running keeps its count and the field is ignored. For a paused sandbox, a count the snapshot or the team cannot take is refused with 400; a count it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's cpuCount reports the count the sandbox runs with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        public int? CpuCount { get; set; }

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
        /// Defaults to true. When false and the sandbox is paused, resume from disk state only: the sandbox cold-boots fresh and any memory in the snapshot is ignored, never modified or deleted. Disk state has crash-recovery semantics — writes not flushed before the pause may be lost. A no-op for snapshots that contain no memory. Rejected with an error in environments where this capability is not enabled, never silently downgraded to a memory restore. A snapshot taken while the sandbox guest agent was not responding (envdUnresponsiveAtPause) can only be resumed this way, and needs no enablement.
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the memory the sandbox had when it was paused; at least that, and at most the template's maxMemoryMB, in steps of 128 MiB above its memoryMB. A sandbox that is already running keeps its size and the field is ignored. For a paused sandbox, a size the snapshot or the team cannot take is refused with 400; a size it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's memoryMB reports the size the sandbox runs with.
        /// </param>
        /// <param name="cpuCount">
        /// Online vCPU target for the sandbox when this connect resumes it, from its memory snapshot or by cold-booting (memory false). Defaults to the snapshot's cpuCount; for a resizable template (one with maxCpuCount) that count is lowered to the team's vCPU limit when above it. A requested count is at most the template's maxCpuCount (fixed-size templates accept only their cpuCount) and the team's vCPU limit, and is refused when resizable templates are not enabled for the team. Like memoryMB: a sandbox that is already running keeps its count and the field is ignored. For a paused sandbox, a count the snapshot or the team cannot take is refused with 400; a count it can take applies only when this connect resumes the sandbox, and is ignored when another request is already resuming it. The response's cpuCount reports the count the sandbox runs with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectSandboxV2(
            int? timeout,
            bool? memory,
            int? memoryMB,
            int? cpuCount)
        {
            this.Timeout = timeout;
            this.Memory = memory;
            this.MemoryMB = memoryMB;
            this.CpuCount = cpuCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectSandboxV2" /> class.
        /// </summary>
        public ConnectSandboxV2()
        {
        }

    }
}