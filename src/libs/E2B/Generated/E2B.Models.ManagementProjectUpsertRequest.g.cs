
#nullable enable

namespace E2B
{
    /// <summary>
    /// The properties of a project this side stores. Name, slug and email are synchronized on every push. The optional cluster assignment is preserved when omitted.<br/>
    /// A project's tier is not among them, and this side assigns none. Limits arrive separately and in full through managementUpsertProjectLimits.
    /// </summary>
    public sealed partial class ManagementProjectUpsertRequest
    {
        /// <summary>
        /// Cluster assignment to synchronize. Omission preserves the existing assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        public global::System.Guid? ClusterId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Changing it renames the project, and its template names follow: each name held under an earlier slug is also given under the new one, and the old names keep working. A name the new slug already holds is left as it is. A slug already held on this control plane is a 409, on a rename as much as on a create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Contact address recorded on the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectUpsertRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Changing it renames the project, and its template names follow: each name held under an earlier slug is also given under the new one, and the old names keep working. A name the new slug already holds is left as it is. A slug already held on this control plane is a 409, on a rename as much as on a create.
        /// </param>
        /// <param name="email">
        /// Contact address recorded on the project.
        /// </param>
        /// <param name="clusterId">
        /// Cluster assignment to synchronize. Omission preserves the existing assignment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectUpsertRequest(
            string name,
            string slug,
            string email,
            global::System.Guid? clusterId)
        {
            this.ClusterId = clusterId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectUpsertRequest" /> class.
        /// </summary>
        public ManagementProjectUpsertRequest()
        {
        }

    }
}