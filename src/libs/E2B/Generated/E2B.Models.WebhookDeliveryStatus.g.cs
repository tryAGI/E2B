
#nullable enable

namespace E2B
{
    /// <summary>
    /// Delivery attempt status
    /// </summary>
    public enum WebhookDeliveryStatus
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
    public static class WebhookDeliveryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryStatus value)
        {
            return value switch
            {
                WebhookDeliveryStatus.Failed => "failed",
                WebhookDeliveryStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => WebhookDeliveryStatus.Failed,
                "success" => WebhookDeliveryStatus.Success,
                _ => null,
            };
        }
    }
}