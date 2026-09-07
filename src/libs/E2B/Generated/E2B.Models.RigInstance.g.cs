
#nullable enable

namespace E2B
{
    /// <summary>
    /// An instance attached to a rig's scaling group
    /// </summary>
    public sealed partial class RigInstance
    {
        /// <summary>
        /// Provider instance ID (EC2 instance ID on AWS, instance name on GCP), also the node ID the orchestrator reports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the provider created the instance. Omitted while the instance is transitioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The provider is creating, deleting, recreating or otherwise mutating the instance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitioning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Transitioning { get; set; }

        /// <summary>
        /// The instance is on its way out of the group and can never become healthy again
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Terminating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RigInstance" /> class.
        /// </summary>
        /// <param name="id">
        /// Provider instance ID (EC2 instance ID on AWS, instance name on GCP), also the node ID the orchestrator reports
        /// </param>
        /// <param name="transitioning">
        /// The provider is creating, deleting, recreating or otherwise mutating the instance
        /// </param>
        /// <param name="terminating">
        /// The instance is on its way out of the group and can never become healthy again
        /// </param>
        /// <param name="createdAt">
        /// When the provider created the instance. Omitted while the instance is transitioning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RigInstance(
            string id,
            bool transitioning,
            bool terminating,
            global::System.DateTime? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Transitioning = transitioning;
            this.Terminating = terminating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RigInstance" /> class.
        /// </summary>
        public RigInstance()
        {
        }

    }
}