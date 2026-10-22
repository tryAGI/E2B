
#nullable enable

namespace E2B
{
    /// <summary>
    /// The team's effective resource limits
    /// </summary>
    public sealed partial class TeamLimits
    {
        /// <summary>
        /// Maximum sandbox lifetime, in hours
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLengthHours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxLengthHours { get; set; }

        /// <summary>
        /// Maximum number of sandboxes running at once
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentSandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ConcurrentSandboxes { get; set; }

        /// <summary>
        /// Maximum number of template builds running at once
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentTemplateBuilds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ConcurrentTemplateBuilds { get; set; }

        /// <summary>
        /// Maximum vCPUs per sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxVcpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxVcpu { get; set; }

        /// <summary>
        /// Maximum memory per sandbox, in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRamMb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxRamMb { get; set; }

        /// <summary>
        /// Disk size per sandbox, in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskMb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DiskMb { get; set; }

        /// <summary>
        /// Number of days sandbox events are kept
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventsTtlDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EventsTtlDays { get; set; }

        /// <summary>
        /// Free disk space a template build gets when it requests none, in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFreeDiskSizeMb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DefaultFreeDiskSizeMb { get; set; }

        /// <summary>
        /// Maximum free disk space a template build may request, in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFreeDiskSizeMb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxFreeDiskSizeMb { get; set; }

        /// <summary>
        /// Requests per second the team may make to list endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiTeamRpsList")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApiTeamRpsList { get; set; }

        /// <summary>
        /// Requests per second the team may make to delete endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiTeamRpsDelete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApiTeamRpsDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimits" /> class.
        /// </summary>
        /// <param name="maxLengthHours">
        /// Maximum sandbox lifetime, in hours
        /// </param>
        /// <param name="concurrentSandboxes">
        /// Maximum number of sandboxes running at once
        /// </param>
        /// <param name="concurrentTemplateBuilds">
        /// Maximum number of template builds running at once
        /// </param>
        /// <param name="maxVcpu">
        /// Maximum vCPUs per sandbox
        /// </param>
        /// <param name="maxRamMb">
        /// Maximum memory per sandbox, in MiB
        /// </param>
        /// <param name="diskMb">
        /// Disk size per sandbox, in MiB
        /// </param>
        /// <param name="eventsTtlDays">
        /// Number of days sandbox events are kept
        /// </param>
        /// <param name="defaultFreeDiskSizeMb">
        /// Free disk space a template build gets when it requests none, in MiB
        /// </param>
        /// <param name="maxFreeDiskSizeMb">
        /// Maximum free disk space a template build may request, in MiB
        /// </param>
        /// <param name="apiTeamRpsList">
        /// Requests per second the team may make to list endpoints
        /// </param>
        /// <param name="apiTeamRpsDelete">
        /// Requests per second the team may make to delete endpoints
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamLimits(
            long maxLengthHours,
            long concurrentSandboxes,
            long concurrentTemplateBuilds,
            long maxVcpu,
            long maxRamMb,
            long diskMb,
            long eventsTtlDays,
            long defaultFreeDiskSizeMb,
            long maxFreeDiskSizeMb,
            long apiTeamRpsList,
            long apiTeamRpsDelete)
        {
            this.MaxLengthHours = maxLengthHours;
            this.ConcurrentSandboxes = concurrentSandboxes;
            this.ConcurrentTemplateBuilds = concurrentTemplateBuilds;
            this.MaxVcpu = maxVcpu;
            this.MaxRamMb = maxRamMb;
            this.DiskMb = diskMb;
            this.EventsTtlDays = eventsTtlDays;
            this.DefaultFreeDiskSizeMb = defaultFreeDiskSizeMb;
            this.MaxFreeDiskSizeMb = maxFreeDiskSizeMb;
            this.ApiTeamRpsList = apiTeamRpsList;
            this.ApiTeamRpsDelete = apiTeamRpsDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimits" /> class.
        /// </summary>
        public TeamLimits()
        {
        }

    }
}