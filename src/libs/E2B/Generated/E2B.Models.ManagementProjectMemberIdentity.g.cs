
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementProjectMemberIdentity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectMemberIdentity" /> class.
        /// </summary>
        /// <param name="issuer"></param>
        /// <param name="subject"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectMemberIdentity(
            string issuer,
            string subject)
        {
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectMemberIdentity" /> class.
        /// </summary>
        public ManagementProjectMemberIdentity()
        {
        }

    }
}