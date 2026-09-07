
#nullable enable

namespace E2B
{
    /// <summary>
    /// An orchestrator node pool backed by one cloud scaling group
    /// </summary>
    public sealed partial class Rig
    {
        /// <summary>
        /// Rig identifier (e.g. "default")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Cloud provider backing the rig ("aws" or "gcp")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Canonical cloud resource ID of the scaling group backing the rig (ARN on AWS, self-link on GCP)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceID { get; set; }

        /// <summary>
        /// Desired number of instances in the rig
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacityDesired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CapacityDesired { get; set; }

        /// <summary>
        /// Minimum capacity enforced on the rig's scaling group. Omitted when nothing enforces bounds (GCP MIG without an active autoscaler).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacityMin")]
        public int? CapacityMin { get; set; }

        /// <summary>
        /// Maximum capacity enforced on the rig's scaling group. Omitted when nothing enforces bounds (GCP MIG without an active autoscaler).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacityMax")]
        public int? CapacityMax { get; set; }

        /// <summary>
        /// Number of instances currently attached to the rig
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacityCurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CapacityCurrent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rig" /> class.
        /// </summary>
        /// <param name="id">
        /// Rig identifier (e.g. "default")
        /// </param>
        /// <param name="provider">
        /// Cloud provider backing the rig ("aws" or "gcp")
        /// </param>
        /// <param name="resourceID">
        /// Canonical cloud resource ID of the scaling group backing the rig (ARN on AWS, self-link on GCP)
        /// </param>
        /// <param name="capacityDesired">
        /// Desired number of instances in the rig
        /// </param>
        /// <param name="capacityCurrent">
        /// Number of instances currently attached to the rig
        /// </param>
        /// <param name="capacityMin">
        /// Minimum capacity enforced on the rig's scaling group. Omitted when nothing enforces bounds (GCP MIG without an active autoscaler).
        /// </param>
        /// <param name="capacityMax">
        /// Maximum capacity enforced on the rig's scaling group. Omitted when nothing enforces bounds (GCP MIG without an active autoscaler).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Rig(
            string id,
            string provider,
            string resourceID,
            int capacityDesired,
            int capacityCurrent,
            int? capacityMin,
            int? capacityMax)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ResourceID = resourceID ?? throw new global::System.ArgumentNullException(nameof(resourceID));
            this.CapacityDesired = capacityDesired;
            this.CapacityMin = capacityMin;
            this.CapacityMax = capacityMax;
            this.CapacityCurrent = capacityCurrent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rig" /> class.
        /// </summary>
        public Rig()
        {
        }

    }
}