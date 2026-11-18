
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
        public global::E2B.SandboxTimeoutRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRefreshRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSnapshotRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkResult? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Error? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamMetric? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MaxTeamMetric? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamStatusResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimits? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimitsResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterDetail? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterDetailWithTeams? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterListItem? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterListResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterListItem>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListItem? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterTeamListItem>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminClusterCreateRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterUpdateRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTokenRotateRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxKillResult? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandbox? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxState? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildStatusGroup? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuild? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildList? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuild>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildRestoreRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxBuildRestoreResult? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverview? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverviewTeam? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxLastPause? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxOverviewBuild? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxPauseKind? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminBuildCancelResult? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListSortField? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamList? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamListItem>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamListItem? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeam? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamSchedulingLabels? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamBanResult? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamsBanRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamsBanResult? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamBanResult>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTeamBanFailure>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTeamBanFailure? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateTeam? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAlias? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliases? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAlias>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasCreateRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasDeleted? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplate? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateCreateRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateUpdateRequest? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateLookup? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuild>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuild? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeToken? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Template? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStatus? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateSearchResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Template>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatus? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedBuild? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsListResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedBuild>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusItem? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsStatusesResponse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatusItem>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildInfo? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateRequestResponseV3? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildWithTags? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildWithTagsVariant2? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateV2? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuilds? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuildsVariant2? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateAliasResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateStep? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildRequestV3? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistry? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistry? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistry? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistry? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminator? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminatorType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistryType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistryType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistryType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStartV2? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateStep>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildFileUpload? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildLogEntry? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusReason? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildLogEntry>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildInfo? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildLogsResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsDirection? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsSource? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatus? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatusChange? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DiskMetrics? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeMetrics? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.DiskMetrics>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MachineInfo? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Node? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeSandboxes? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.NodeSandbox>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeSandbox? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeDetail? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamAPIKey? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.IdentifierMaskingDetails? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.CreatedTeamAPIKey? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewTeamAPIKey? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.UpdateTeamAPIKey? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignedTemplateTags? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTag? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignment? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroup? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroupsResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagGroup>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagsCountResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagExistsResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignmentsResponse? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignTemplateTagsRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DeleteTemplateTagsRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Volume? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeAndToken? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewVolume? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Secret? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSecret? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SecretUpdate? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEvent? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreate? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreation? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDetail? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookConfiguration? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDelivery? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatus? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryErrorClass? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStats? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatsBucket? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryDurationStats? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryGroup? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDelivery>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveriesListPayload? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementClusterRegistrationRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementClusterProjects? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectSettingsRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ProjectSettings? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSettings? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectUpsertRequest? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProject? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectVariant2? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberIdentity? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberApplyRequest? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberApplyRequestRole? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBlockRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBanRequest? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectLimits? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementUpdateClusterTelemetryRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTeamsMetricsMaxMetric? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxState>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetUnstableTemplatesSearchSort? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatus>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuildStatus>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTemplatesTagsGroupsSort? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuildStatusGroup>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClustersSortBy? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClustersSortOrder? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortBy? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortOrder? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamMetric>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedSandbox>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxMetric>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SnapshotInfo>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuildWithTags>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTag>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Node>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamAPIKey>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliases>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Volume>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Secret>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Rig>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigInstance>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigError>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxEvent>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDetail>? Type265 { get; set; }

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
        public global::System.Collections.Generic.List<global::E2B.ClusterListItem>? ListType8 { get; set; }
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
        public global::System.Collections.Generic.List<global::E2B.TemplateBuild>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Template>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedBuild>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatusItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateStep>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildLogEntry>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.DiskMetrics>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.NodeSandbox>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagAssignment>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagGroup>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryStatsBucket>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDelivery>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryGroup>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ManagementProjectMemberIdentity>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxState>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatus>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuildStatus>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminSandboxBuildStatusGroup>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamMetric>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedSandbox>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxMetric>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxForkResult>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SnapshotInfo>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuildWithTags>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTag>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Node>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamAPIKey>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAliases>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Volume>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Secret>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Rig>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigInstance>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigError>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxEvent>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDetail>? ListType51 { get; set; }
    }
}