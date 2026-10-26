
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTeamListRequest
    {
        /// <summary>
        /// Only list these teams. An empty list matches no team; omit it to list every team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// A team ID, as a UUID or public project ID, matches that team exactly. Any other text matches a substring of the email, name or slug, ignoring case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Leave out banned teams<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideBanned")]
        public bool? HideBanned { get; set; }

        /// <summary>
        /// Leave out blocked teams<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideBlocked")]
        public bool? HideBlocked { get; set; }

        /// <summary>
        /// Only list teams created at or after this time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAfter")]
        public global::System.DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Only list teams created at or before this time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBefore")]
        public global::System.DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Column to order by, with newer teams first among equal values. Omit it<br/>
        /// to list the newest teams first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminTeamListSortFieldJsonConverter))]
        public global::E2B.AdminTeamListSortField? SortBy { get; set; }

        /// <summary>
        /// Ignored when `sortBy` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.OrderDirectionJsonConverter))]
        public global::E2B.OrderDirection? SortOrder { get; set; }

        /// <summary>
        /// Maximum number of teams to return<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of matching teams to skip<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamListRequest" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// Only list these teams. An empty list matches no team; omit it to list every team.
        /// </param>
        /// <param name="search">
        /// A team ID, as a UUID or public project ID, matches that team exactly. Any other text matches a substring of the email, name or slug, ignoring case.
        /// </param>
        /// <param name="hideBanned">
        /// Leave out banned teams<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hideBlocked">
        /// Leave out blocked teams<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAfter">
        /// Only list teams created at or after this time
        /// </param>
        /// <param name="createdBefore">
        /// Only list teams created at or before this time
        /// </param>
        /// <param name="sortBy">
        /// Column to order by, with newer teams first among equal values. Omit it<br/>
        /// to list the newest teams first.
        /// </param>
        /// <param name="sortOrder">
        /// Ignored when `sortBy` is omitted.
        /// </param>
        /// <param name="limit">
        /// Maximum number of teams to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Number of matching teams to skip<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeamListRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            string? search,
            bool? hideBanned,
            bool? hideBlocked,
            global::System.DateTime? createdAfter,
            global::System.DateTime? createdBefore,
            global::E2B.AdminTeamListSortField? sortBy,
            global::E2B.OrderDirection? sortOrder,
            int? limit,
            int? offset)
        {
            this.ProjectIds = projectIds;
            this.Search = search;
            this.HideBanned = hideBanned;
            this.HideBlocked = hideBlocked;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamListRequest" /> class.
        /// </summary>
        public AdminTeamListRequest()
        {
        }

    }
}