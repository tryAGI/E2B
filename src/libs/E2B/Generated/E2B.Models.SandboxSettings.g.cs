
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxSettings
    {
        /// <summary>
        /// Whether new sandboxes without an explicit network.allowPublicTraffic accept traffic without a traffic access token. Omission uses the public default. Existing sandboxes, resumes and forks keep their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAllowPublicTraffic")]
        public bool? DefaultAllowPublicTraffic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxSettings" /> class.
        /// </summary>
        /// <param name="defaultAllowPublicTraffic">
        /// Whether new sandboxes without an explicit network.allowPublicTraffic accept traffic without a traffic access token. Omission uses the public default. Existing sandboxes, resumes and forks keep their settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxSettings(
            bool? defaultAllowPublicTraffic)
        {
            this.DefaultAllowPublicTraffic = defaultAllowPublicTraffic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxSettings" /> class.
        /// </summary>
        public SandboxSettings()
        {
        }

    }
}