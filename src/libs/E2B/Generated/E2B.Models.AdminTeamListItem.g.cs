
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTeamListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBanned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBanned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Number of users in the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemberCount { get; set; }

        /// <summary>
        /// Running sandboxes from the same cached snapshot as `GET /admin/sandboxes/running-counts`. Present only when the list is sorted by `runningSandboxes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runningSandboxCount")]
        public long? RunningSandboxCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="isBanned"></param>
        /// <param name="isBlocked"></param>
        /// <param name="createdAt"></param>
        /// <param name="memberCount">
        /// Number of users in the team
        /// </param>
        /// <param name="runningSandboxCount">
        /// Running sandboxes from the same cached snapshot as `GET /admin/sandboxes/running-counts`. Present only when the list is sorted by `runningSandboxes`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeamListItem(
            global::System.Guid id,
            string email,
            string name,
            bool isBanned,
            bool isBlocked,
            global::System.DateTime createdAt,
            long memberCount,
            long? runningSandboxCount)
        {
            this.Id = id;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsBanned = isBanned;
            this.IsBlocked = isBlocked;
            this.CreatedAt = createdAt;
            this.MemberCount = memberCount;
            this.RunningSandboxCount = runningSandboxCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeamListItem" /> class.
        /// </summary>
        public AdminTeamListItem()
        {
        }

    }
}