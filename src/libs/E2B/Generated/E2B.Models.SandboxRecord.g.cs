
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxRecord
    {
        /// <summary>
        /// Identifier of the template from which is the sandbox created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Time when the sandbox was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Time when the sandbox was stopped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stoppedAt")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Base domain where the sandbox traffic is accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryMB { get; set; }

        /// <summary>
        /// Disk size for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskSizeMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskSizeMB { get; set; }

        /// <summary>
        /// Whether the sandbox ended more than the fixed retention window ago, so its monitoring and logs data is no longer available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionExpired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RetentionExpired { get; set; }

        /// <summary>
        /// Whether the sandbox ended more than the team's events retention window ago, so its events data is no longer available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsRetentionExpired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EventsRetentionExpired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxRecord" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template from which is the sandbox created
        /// </param>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="startedAt">
        /// Time when the sandbox was started
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="diskSizeMB">
        /// Disk size for the sandbox in MiB
        /// </param>
        /// <param name="retentionExpired">
        /// Whether the sandbox ended more than the fixed retention window ago, so its monitoring and logs data is no longer available
        /// </param>
        /// <param name="eventsRetentionExpired">
        /// Whether the sandbox ended more than the team's events retention window ago, so its events data is no longer available
        /// </param>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="stoppedAt">
        /// Time when the sandbox was stopped
        /// </param>
        /// <param name="domain">
        /// Base domain where the sandbox traffic is accessible
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxRecord(
            string templateID,
            string sandboxID,
            global::System.DateTime startedAt,
            int cpuCount,
            int memoryMB,
            int diskSizeMB,
            bool retentionExpired,
            bool eventsRetentionExpired,
            string? alias,
            global::System.DateTime? stoppedAt,
            string? domain)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Alias = alias;
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.StartedAt = startedAt;
            this.StoppedAt = stoppedAt;
            this.Domain = domain;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.DiskSizeMB = diskSizeMB;
            this.RetentionExpired = retentionExpired;
            this.EventsRetentionExpired = eventsRetentionExpired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxRecord" /> class.
        /// </summary>
        public SandboxRecord()
        {
        }

    }
}