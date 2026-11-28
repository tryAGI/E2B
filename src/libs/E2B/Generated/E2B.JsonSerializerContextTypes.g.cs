
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.TelemetryNames? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::E2B.TelemetryTeamName>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TelemetryTeamName? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TelemetryClusterName>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TelemetryClusterName? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Rig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigCapacityChange? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigInstance? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigError? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamUser? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateUpdateRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateUpdateResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxState? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.OrderDirection? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SnapshotInfo? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Mcp? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkConfig? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEgressProxyConfig? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkRule? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkUpdateConfig? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkTransform? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEgressProxyTLSConfig? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxAutoResumeConfig? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxOnTimeout? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLifecycle? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseMode? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLog? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogEntry? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogLevel? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogs? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLog>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLogEntry>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogsV2Response? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxMetric? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxVolumeMount? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Sandbox? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxDetail? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxVolumeMount>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRecord? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedSandbox? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxesWithMetrics? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandbox? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIam? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandboxV2? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::E2B.SandboxIamToken>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIamToken? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ResumedSandbox? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandbox? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandboxV2? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPausedRetentionRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxTimeoutRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRefreshRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSnapshotRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkResult? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Error? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamMetric? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MaxTeamMetric? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamStatusResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimits? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimitsResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListItem? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamCount? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamCountList? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterTeamCount>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterTeamListItem>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxKillResult? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandbox? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxState? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildStatusGroup? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuild? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildList? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuild>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildRestoreRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildRestoreResult? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverview? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverviewTeam? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxLastPause? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverviewBuild? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxPauseKind? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminBuildCancelResult? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListSortField? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamList? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamListItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeam? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamSchedulingLabels? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamBanResult? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamsBanRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamsBanResult? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamBanResult>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamBanFailure>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamBanFailure? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateTeam? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAlias? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliases? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAlias>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasResolveRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminResolvedTemplate? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminResolvedTemplateAlias>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminResolvedTemplateAlias? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasResolution? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasResolveResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliasResolution>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasCreateRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasDeleted? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplate? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateCreateRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateUpdateRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateLookup? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuild>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuild? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeToken? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Template? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStatus? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateSearchResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Template>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatus? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedBuild? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsListResponse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedBuild>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusItem? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsStatusesResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatusItem>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildInfo? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateRequestResponseV3? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildWithTags? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildWithTagsVariant2? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateV2? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuilds? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuildsVariant2? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateAliasResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateStep? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildRequestV3? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistry? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistry? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistry? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistry? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminator? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminatorType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistryType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistryType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistryType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStartV2? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateStep>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildFileUpload? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildLogEntry? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusReason? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildLogEntry>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildInfo? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildLogsResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsDirection? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsSource? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatus? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatusChange? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DiskMetrics? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeMetrics? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.DiskMetrics>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MachineInfo? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Node? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeSandboxes? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.NodeSandbox>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeSandbox? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeDetail? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamAPIKey? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.IdentifierMaskingDetails? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.CreatedTeamAPIKey? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewTeamAPIKey? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.UpdateTeamAPIKey? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignedTemplateTags? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTag? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignment? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroup? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroupsResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagGroup>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagsCountResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagExistsResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignmentsResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignTemplateTagsRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DeleteTemplateTagsRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Volume? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeAndToken? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewVolume? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Secret? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSecret? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SecretUpdate? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEvent? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreate? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreation? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDetail? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookConfiguration? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDelivery? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatus? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryErrorClass? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStats? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatsBucket? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryDurationStats? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryGroup? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDelivery>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveriesListPayload? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementClusterProjects? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectSettingsRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ProjectSettings? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSettings? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectUpsertRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProject? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectVariant2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberIdentity? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberApplyRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberApplyRequestRole? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBlockRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBanRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectLimits? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTeamsMetricsMaxMetric? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxState>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetUnstableTemplatesSearchSort? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatus>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuildStatus>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTemplatesTagsGroupsSort? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuildStatusGroup>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortBy? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortOrder? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamMetric>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedSandbox>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxMetric>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SnapshotInfo>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuildWithTags>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTag>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Node>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamAPIKey>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliases>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Volume>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Secret>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Rig>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigInstance>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigError>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxEvent>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDetail>? Type264 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TelemetryClusterName>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::E2B.SandboxNetworkRule>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxNetworkRule>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxLog>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxLogEntry>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxVolumeMount>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ClusterTeamCount>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ClusterTeamListItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminSandboxBuild>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamListItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamBanResult>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamBanFailure>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAlias>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminResolvedTemplateAlias>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAliasResolution>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuild>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Template>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedBuild>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatusItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateStep>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildLogEntry>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.DiskMetrics>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.NodeSandbox>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagAssignment>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagGroup>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryStatsBucket>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDelivery>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryGroup>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ManagementProjectMemberIdentity>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxState>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatus>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuildStatus>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminSandboxBuildStatusGroup>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamMetric>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedSandbox>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxMetric>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxForkResult>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SnapshotInfo>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuildWithTags>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTag>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Node>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamAPIKey>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAliases>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Volume>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Secret>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Rig>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigInstance>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigError>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxEvent>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDetail>? ListType53 { get; set; }
    }
}