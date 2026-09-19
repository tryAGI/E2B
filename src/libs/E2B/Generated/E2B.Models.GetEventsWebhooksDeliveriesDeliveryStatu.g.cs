
#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public enum GetEventsWebhooksDeliveriesDeliveryStatu
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEventsWebhooksDeliveriesDeliveryStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEventsWebhooksDeliveriesDeliveryStatu value)
        {
            return value switch
            {
                GetEventsWebhooksDeliveriesDeliveryStatu.Failed => "failed",
                GetEventsWebhooksDeliveriesDeliveryStatu.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEventsWebhooksDeliveriesDeliveryStatu? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetEventsWebhooksDeliveriesDeliveryStatu.Failed,
                "success" => GetEventsWebhooksDeliveriesDeliveryStatu.Success,
                _ => null,
            };
        }
    }
}