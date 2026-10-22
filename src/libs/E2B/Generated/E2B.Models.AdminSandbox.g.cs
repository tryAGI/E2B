
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminSandbox
    {
        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Identifier of the team that owns the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TeamID { get; set; }

        /// <summary>
        /// State after the sandbox's latest create, resume, pause or kill event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.AdminSandboxStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::E2B.AdminSandboxState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandbox" /> class.
        /// </summary>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="teamID">
        /// Identifier of the team that owns the sandbox
        /// </param>
        /// <param name="state">
        /// State after the sandbox's latest create, resume, pause or kill event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandbox(
            string sandboxID,
            global::System.Guid teamID,
            global::E2B.AdminSandboxState state)
        {
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.TeamID = teamID;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandbox" /> class.
        /// </summary>
        public AdminSandbox()
        {
        }

    }
}