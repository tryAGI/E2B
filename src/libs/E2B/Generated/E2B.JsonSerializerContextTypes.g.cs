
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
        public global::System.Collections.Generic.IList<int>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxNetworkRule>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkRule? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkUpdateConfig? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxNetworkTransform? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxAutoResumeConfig? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxOnTimeout? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLifecycle? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLog? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogEntry? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogLevel? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogs? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLog>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxLogEntry>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxLogsV2Response? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxMetric? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxVolumeMount? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Sandbox? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxDetail? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxVolumeMount>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ListedSandbox? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxesWithMetrics? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandbox? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIam? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSandboxV2? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::E2B.SandboxIamToken>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxIamToken? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ResumedSandbox? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandbox? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.ConnectSandboxV2? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxTimeoutRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxRefreshRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxSnapshotRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxPauseRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxForkResult? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Error? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamMetric? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MaxTeamMetric? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminSandboxKillResult? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AdminBuildCancelResult? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeToken? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Template? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStatus? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateRequestResponseV3? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuild? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuilds? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateBuild>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateAliasResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateStep? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildRequestV3? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistry? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistry? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistry? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistry? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminator? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminatorType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AWSRegistryType? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GCPRegistryType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GeneralRegistryType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildStartV2? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateStep>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildFileUpload? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildLogEntry? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.BuildStatusReason? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.BuildLogEntry>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildInfo? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildLogsResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsDirection? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.LogsSource? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatus? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeStatusChange? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DiskMetrics? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeMetrics? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.DiskMetrics>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.MachineInfo? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Node? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NodeDetail? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TeamAPIKey? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.IdentifierMaskingDetails? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.CreatedTeamAPIKey? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewTeamAPIKey? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.UpdateTeamAPIKey? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignedTemplateTags? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateTag? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.AssignTemplateTagsRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.DeleteTemplateTagsRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Volume? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.VolumeAndToken? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewVolume? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.Secret? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.NewSecret? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SecretUpdate? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.SandboxEvent? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreate? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookCreation? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDetail? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookConfiguration? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDelivery? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryErrorClass? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStats? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryStatsBucket>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryStatsBucket? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryDurationStats? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveryGroup? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDelivery>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.WebhookDeliveriesListPayload? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDeliveryGroup>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetTeamsMetricsMaxMetric? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxState>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Team>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamMetric>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.ListedSandbox>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxMetric>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxForkResult>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SnapshotInfo>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Template>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TemplateTag>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Node>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.TeamAPIKey>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Volume>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Secret>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.Rig>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigInstance>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.RigError>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.SandboxEvent>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::E2B.WebhookDetail>? Type157 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType1 { get; set; }
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
        public global::System.Collections.Generic.List<global::E2B.TemplateBuild>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateStep>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.BuildLogEntry>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.DiskMetrics>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryStatsBucket>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDelivery>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDeliveryGroup>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxState>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Team>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamMetric>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.ListedSandbox>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxMetric>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxForkResult>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SnapshotInfo>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Template>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TemplateTag>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Node>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.TeamAPIKey>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Volume>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Secret>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.Rig>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigInstance>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.RigError>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.SandboxEvent>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::E2B.WebhookDetail>? ListType32 { get; set; }
    }
}