
#nullable enable

namespace E2B
{
    /// <summary>
    /// A project's effective limits, already resolved by the caller. Every field is absolute: this side stores what it is given and performs no arithmetic of its own.<br/>
    /// The minimums below are the contract for what a limit may be, at least as strict as the CHECK constraints on default_limits. project_limits stores the same values under looser constraints on purpose — it is a push target, and a floor that only rejects the impossible keeps a future decision about what is allowed a change to this schema rather than a migration.<br/>
    /// `max_disk_size_mb` and `max_free_disk_size_mb` are one ceiling under two names, and either name alone carries it. A caller that sends both must send them equal; a caller that sends neither is refused. Sending both is what a caller does while receivers older than the second name are still running.
    /// </summary>
    public sealed partial class ManagementProjectLimits
    {
        /// <summary>
        /// The caller's version of this answer, raised whenever the limits it resolved for the project change. Delivery is over a network, so two pushes can be in flight at once and arrive in either order: this side stores the revision it accepted and drops a delivery at or below it, which is what keeps a delayed retry from putting the project back on limits it has already left.<br/>
        /// Comparable only against earlier revisions for the same project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_sandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentSandboxes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_length_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSandboxLengthHours { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_vcpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxVcpu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_ram_mb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxRamMb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_mb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DiskMb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_template_builds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentTemplateBuilds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_ttl_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventsTtlDays { get; set; }

        /// <summary>
        /// The default free-space growth target when a template build request omits one. May sit anywhere at or below the maximum free-space growth target, and usually sits well below it; a delivery whose default exceeds the maximum is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_free_disk_size_mb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DefaultFreeDiskSizeMb { get; set; }

        /// <summary>
        /// The most a template build may request as its free-space growth target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_free_disk_size_mb")]
        public long? MaxFreeDiskSizeMb { get; set; }

        /// <summary>
        /// The same ceiling as max_free_disk_size_mb, under the name it was first published with. Kept until every deployed sender and receiver speaks the other name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_disk_size_mb")]
        public long? MaxDiskSizeMb { get; set; }

        /// <summary>
        /// Requests per second a project may make to each list endpoint. Zero disables the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_team_rps_list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApiTeamRpsList { get; set; }

        /// <summary>
        /// Requests per second a project may make to each delete endpoint. Zero disables the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_team_rps_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApiTeamRpsDelete { get; set; }

        /// <summary>
        /// Live secrets the project may hold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSecrets { get; set; }

        /// <summary>
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_at")]
        public global::System.DateTime? DecidedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectLimits" /> class.
        /// </summary>
        /// <param name="revision">
        /// The caller's version of this answer, raised whenever the limits it resolved for the project change. Delivery is over a network, so two pushes can be in flight at once and arrive in either order: this side stores the revision it accepted and drops a delivery at or below it, which is what keeps a delayed retry from putting the project back on limits it has already left.<br/>
        /// Comparable only against earlier revisions for the same project.
        /// </param>
        /// <param name="concurrentSandboxes"></param>
        /// <param name="maxSandboxLengthHours"></param>
        /// <param name="maxVcpu"></param>
        /// <param name="maxRamMb"></param>
        /// <param name="diskMb"></param>
        /// <param name="concurrentTemplateBuilds"></param>
        /// <param name="eventsTtlDays"></param>
        /// <param name="defaultFreeDiskSizeMb">
        /// The default free-space growth target when a template build request omits one. May sit anywhere at or below the maximum free-space growth target, and usually sits well below it; a delivery whose default exceeds the maximum is rejected.
        /// </param>
        /// <param name="apiTeamRpsList">
        /// Requests per second a project may make to each list endpoint. Zero disables the limit.
        /// </param>
        /// <param name="apiTeamRpsDelete">
        /// Requests per second a project may make to each delete endpoint. Zero disables the limit.
        /// </param>
        /// <param name="maxSecrets">
        /// Live secrets the project may hold.
        /// </param>
        /// <param name="maxFreeDiskSizeMb">
        /// The most a template build may request as its free-space growth target.
        /// </param>
        /// <param name="maxDiskSizeMb">
        /// The same ceiling as max_free_disk_size_mb, under the name it was first published with. Kept until every deployed sender and receiver speaks the other name.
        /// </param>
        /// <param name="decidedAt">
        /// When the caller decided this revision, in RFC 3339. Stored with the revision and used to measure how long the decision took to apply here. Omit it when the caller does not know; the delivery is then counted as origin unknown rather than as zero lag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectLimits(
            long revision,
            int concurrentSandboxes,
            int maxSandboxLengthHours,
            int maxVcpu,
            long maxRamMb,
            long diskMb,
            int concurrentTemplateBuilds,
            int eventsTtlDays,
            long defaultFreeDiskSizeMb,
            long apiTeamRpsList,
            long apiTeamRpsDelete,
            int maxSecrets,
            long? maxFreeDiskSizeMb,
            long? maxDiskSizeMb,
            global::System.DateTime? decidedAt)
        {
            this.Revision = revision;
            this.ConcurrentSandboxes = concurrentSandboxes;
            this.MaxSandboxLengthHours = maxSandboxLengthHours;
            this.MaxVcpu = maxVcpu;
            this.MaxRamMb = maxRamMb;
            this.DiskMb = diskMb;
            this.ConcurrentTemplateBuilds = concurrentTemplateBuilds;
            this.EventsTtlDays = eventsTtlDays;
            this.DefaultFreeDiskSizeMb = defaultFreeDiskSizeMb;
            this.MaxFreeDiskSizeMb = maxFreeDiskSizeMb;
            this.MaxDiskSizeMb = maxDiskSizeMb;
            this.ApiTeamRpsList = apiTeamRpsList;
            this.ApiTeamRpsDelete = apiTeamRpsDelete;
            this.MaxSecrets = maxSecrets;
            this.DecidedAt = decidedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectLimits" /> class.
        /// </summary>
        public ManagementProjectLimits()
        {
        }

    }
}