#nullable enable

namespace E2B.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetEventsWebhooksDeliveriesDeliveryStatuNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu?>
    {
        /// <inheritdoc />
        public override global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::E2B.GetEventsWebhooksDeliveriesDeliveryStatuExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::E2B.GetEventsWebhooksDeliveriesDeliveryStatu? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::E2B.GetEventsWebhooksDeliveriesDeliveryStatuExtensions.ToValueString(value.Value));
            }
        }
    }
}
