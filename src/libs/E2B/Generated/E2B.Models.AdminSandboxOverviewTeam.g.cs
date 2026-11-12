
#nullable enable

namespace E2B
{
    /// <summary>
    /// The team the sandbox belongs to
    /// </summary>
    public sealed partial class AdminSandboxOverviewTeam
    {
        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Contact email of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverviewTeam" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the team
        /// </param>
        /// <param name="name">
        /// Name of the team
        /// </param>
        /// <param name="email">
        /// Contact email of the team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxOverviewTeam(
            global::System.Guid id,
            string? name,
            string? email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxOverviewTeam" /> class.
        /// </summary>
        public AdminSandboxOverviewTeam()
        {
        }

    }
}