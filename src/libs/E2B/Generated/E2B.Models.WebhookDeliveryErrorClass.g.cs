
#nullable enable

namespace E2B
{
    /// <summary>
    /// Machine-readable non-HTTP or HTTP failure class
    /// </summary>
    public enum WebhookDeliveryErrorClass
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        DnsError,
        /// <summary>
        ///
        /// </summary>
        HttpError,
        /// <summary>
        ///
        /// </summary>
        RequestError,
        /// <summary>
        ///
        /// </summary>
        SignatureError,
        /// <summary>
        ///
        /// </summary>
        Timeout,
        /// <summary>
        ///
        /// </summary>
        TransportError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveryErrorClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryErrorClass value)
        {
            return value switch
            {
                WebhookDeliveryErrorClass.Canceled => "canceled",
                WebhookDeliveryErrorClass.DnsError => "dns_error",
                WebhookDeliveryErrorClass.HttpError => "http_error",
                WebhookDeliveryErrorClass.RequestError => "request_error",
                WebhookDeliveryErrorClass.SignatureError => "signature_error",
                WebhookDeliveryErrorClass.Timeout => "timeout",
                WebhookDeliveryErrorClass.TransportError => "transport_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryErrorClass? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => WebhookDeliveryErrorClass.Canceled,
                "dns_error" => WebhookDeliveryErrorClass.DnsError,
                "http_error" => WebhookDeliveryErrorClass.HttpError,
                "request_error" => WebhookDeliveryErrorClass.RequestError,
                "signature_error" => WebhookDeliveryErrorClass.SignatureError,
                "timeout" => WebhookDeliveryErrorClass.Timeout,
                "transport_error" => WebhookDeliveryErrorClass.TransportError,
                _ => null,
            };
        }
    }
}