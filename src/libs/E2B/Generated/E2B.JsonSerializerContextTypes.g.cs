
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
        public global::E2B.Rig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigCapacityChange? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigInstance? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.RigError? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Team? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamUser? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateUpdateRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateUpdateResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxState? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.OrderDirection? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SnapshotInfo? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Mcp? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkConfig? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEgressProxyConfig? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkRule? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkUpdateConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkTransform? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEgressProxyTLSConfig? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxAutoResumeConfig? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxOnTimeout? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLifecycle? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseMode? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLog? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogEntry? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogLevel? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogs? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLog>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLogEntry>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogsV2Response? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxMetric? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxVolumeMount? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Sandbox? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxDetail? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxVolumeMount>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRecord? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedSandbox? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxesWithMetrics? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandbox? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIam? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandboxV2? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::E2B.SandboxIamToken>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIamToken? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ResumedSandbox? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandbox? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandboxV2? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxTimeoutRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRefreshRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSnapshotRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkResult? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Error? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamMetric? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MaxTeamMetric? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamStatusResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimits? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamLimitsResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterDetail? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterDetailWithTeams? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterListItem? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterListResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterListItem>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTeamListItem? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ClusterTeamListItem>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminClusterCreateRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterUpdateRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ClusterTokenRotateRequest? Type81 { get; set; }
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
        public global::E2B.AdminTemplateAliasCreateRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateAliasDeleted? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplate? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateCreateRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminDefaultTemplateUpdateRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminTemplateLookup? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuild>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuild? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeToken? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Template? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateSearchResponse? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Template>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatus? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedBuild? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsListResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedBuild>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusItem? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildsStatusesResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatusItem>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildInfo? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateRequestResponseV3? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuilds? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuildsVariant2? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateAliasResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateStep? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildRequestV3? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistry? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistry? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistry? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistry? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminator? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminatorType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistryType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistryType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistryType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStartV2? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateStep>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildFileUpload? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildLogEntry? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusReason? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildLogEntry>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildInfo? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildLogsResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsDirection? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsSource? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatus? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatusChange? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DiskMetrics? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeMetrics? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.DiskMetrics>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MachineInfo? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Node? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeDetail? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamAPIKey? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.IdentifierMaskingDetails? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.CreatedTeamAPIKey? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewTeamAPIKey? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.UpdateTeamAPIKey? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignedTemplateTags? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTag? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignment? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroup? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagAssignment>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagGroupsResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTagGroup>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagsCountResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagExistsResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTagAssignmentsResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignTemplateTagsRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DeleteTemplateTagsRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Volume? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeAndToken? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewVolume? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Secret? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSecret? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SecretUpdate? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEvent? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreate? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreation? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDetail? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookConfiguration? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDelivery? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatus? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryErrorClass? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStats? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatsBucket? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryDurationStats? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryGroup? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDelivery>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveriesListPayload? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementClusterRegistrationRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementClusterProjects? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectSettingsRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ProjectSettings? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSettings? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectUpsertRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProject? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberIdentity? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectMemberApplyRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBlockRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectBanRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectLimits? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTeamsMetricsMaxMetric? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxState>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetUnstableTemplatesSearchSort? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildStatus>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTemplatesTagsGroupsSort? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminSandboxBuildStatusGroup>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClustersSortBy? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClustersSortOrder? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortBy? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminListClusterTeamsSortOrder? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Team>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamMetric>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedSandbox>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxMetric>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SnapshotInfo>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTag>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Node>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamAPIKey>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.AdminTemplateAliases>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Volume>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Secret>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Rig>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigInstance>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigError>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxEvent>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDetail>? Type252 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::E2B.SandboxNetworkRule>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxNetworkRule>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxLog>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxLogEntry>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxVolumeMount>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ClusterListItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ClusterTeamListItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminSandboxBuild>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamListItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamBanResult>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTeamBanFailure>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAlias>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateBuild>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Template>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedBuild>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatusItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateStep>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildLogEntry>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.DiskMetrics>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagAssignment>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTagGroup>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryStatsBucket>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDelivery>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryGroup>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ManagementProjectMemberIdentity>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxState>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildStatus>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminSandboxBuildStatusGroup>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Team>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamMetric>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedSandbox>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxMetric>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxForkResult>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SnapshotInfo>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTag>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Node>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamAPIKey>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.AdminTemplateAliases>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Volume>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Secret>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Rig>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigInstance>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigError>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxEvent>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDetail>? ListType48 { get; set; }
    }
}