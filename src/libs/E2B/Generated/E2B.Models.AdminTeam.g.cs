
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminTeam
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBanned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBanned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedReason")]
        public string? BlockedReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxSchedulingLabels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SandboxSchedulingLabels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterId")]
        public global::System.Guid? ClusterId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterName")]
        public string? ClusterName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="createdAt"></param>
        /// <param name="isBlocked"></param>
        /// <param name="isBanned"></param>
        /// <param name="sandboxSchedulingLabels"></param>
        /// <param name="blockedReason"></param>
        /// <param name="clusterId"></param>
        /// <param name="clusterName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminTeam(
            global::System.Guid id,
            string email,
            string name,
            string slug,
            global::System.DateTime createdAt,
            bool isBlocked,
            bool isBanned,
            global::System.Collections.Generic.IList<string> sandboxSchedulingLabels,
            string? blockedReason,
            global::System.Guid? clusterId,
            string? clusterName)
        {
            this.Id = id;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.CreatedAt = createdAt;
            this.IsBlocked = isBlocked;
            this.IsBanned = isBanned;
            this.BlockedReason = blockedReason;
            this.SandboxSchedulingLabels = sandboxSchedulingLabels ?? throw new global::System.ArgumentNullException(nameof(sandboxSchedulingLabels));
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTeam" /> class.
        /// </summary>
        public AdminTeam()
        {
        }

    }
}