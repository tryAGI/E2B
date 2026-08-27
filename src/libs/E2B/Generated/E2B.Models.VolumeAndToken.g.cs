
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VolumeAndToken
    {
        /// <summary>
        /// ID of the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeID { get; set; }

        /// <summary>
        /// Name of the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Auth token to use for interacting with volume content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Domain to use as the destination for volume content requests,<br/>
        /// replacing the default `api.&lt;E2B_DOMAIN&gt;`. Only returned when the<br/>
        /// team is connected to a custom (BYOC) cluster; absent otherwise, in<br/>
        /// which case the default domain is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeAndToken" /> class.
        /// </summary>
        /// <param name="volumeID">
        /// ID of the volume
        /// </param>
        /// <param name="name">
        /// Name of the volume
        /// </param>
        /// <param name="token">
        /// Auth token to use for interacting with volume content
        /// </param>
        /// <param name="domain">
        /// Domain to use as the destination for volume content requests,<br/>
        /// replacing the default `api.&lt;E2B_DOMAIN&gt;`. Only returned when the<br/>
        /// team is connected to a custom (BYOC) cluster; absent otherwise, in<br/>
        /// which case the default domain is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeAndToken(
            string volumeID,
            string name,
            string token,
            string? domain)
        {
            this.VolumeID = volumeID ?? throw new global::System.ArgumentNullException(nameof(volumeID));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeAndToken" /> class.
        /// </summary>
        public VolumeAndToken()
        {
        }

    }
}