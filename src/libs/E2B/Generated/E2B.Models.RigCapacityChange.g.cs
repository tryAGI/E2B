
#nullable enable

namespace E2B
{
    /// <summary>
    /// Desired capacity to set on the rig's scaling group
    /// </summary>
    public sealed partial class RigCapacityChange
    {
        /// <summary>
        /// Absolute desired number of instances in the rig
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Desired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RigCapacityChange" /> class.
        /// </summary>
        /// <param name="desired">
        /// Absolute desired number of instances in the rig
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RigCapacityChange(
            int desired)
        {
            this.Desired = desired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RigCapacityChange" /> class.
        /// </summary>
        public RigCapacityChange()
        {
        }

    }
}