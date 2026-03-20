
#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneralRegistry
    {
        /// <summary>
        /// Type of registry authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::E2B.JsonConverters.GeneralRegistryTypeJsonConverter))]
        public global::E2B.GeneralRegistryType Type { get; set; }

        /// <summary>
        /// Username to use for the registry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Password to use for the registry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegistry" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of registry authentication
        /// </param>
        /// <param name="username">
        /// Username to use for the registry
        /// </param>
        /// <param name="password">
        /// Password to use for the registry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneralRegistry(
            string username,
            string password,
            global::E2B.GeneralRegistryType type)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegistry" /> class.
        /// </summary>
        public GeneralRegistry()
        {
        }
    }
}