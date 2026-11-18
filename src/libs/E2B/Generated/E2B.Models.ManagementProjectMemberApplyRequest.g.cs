
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementProjectMemberApplyRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Present { get; set; }

        /// <summary>
        /// Whether this membership is the user's default team. Omitted requests from older sources remain non-default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The member's effective role on the project. A viewer may only read. An omitted role keeps the stored one, and a new member without one is stored as member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.ManagementProjectMemberApplyRequestRoleJsonConverter))]
        public global::E2B.ManagementProjectMemberApplyRequestRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identities")]
        public global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? Identities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectMemberApplyRequest" /> class.
        /// </summary>
        /// <param name="revision"></param>
        /// <param name="present"></param>
        /// <param name="isDefault">
        /// Whether this membership is the user's default team. Omitted requests from older sources remain non-default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="role">
        /// The member's effective role on the project. A viewer may only read. An omitted role keeps the stored one, and a new member without one is stored as member.
        /// </param>
        /// <param name="identities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectMemberApplyRequest(
            long revision,
            bool present,
            bool? isDefault,
            global::E2B.ManagementProjectMemberApplyRequestRole? role,
            global::System.Collections.Generic.IList<global::E2B.ManagementProjectMemberIdentity>? identities)
        {
            this.Revision = revision;
            this.Present = present;
            this.IsDefault = isDefault;
            this.Role = role;
            this.Identities = identities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectMemberApplyRequest" /> class.
        /// </summary>
        public ManagementProjectMemberApplyRequest()
        {
        }

    }
}