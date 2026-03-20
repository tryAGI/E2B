#nullable enable

namespace E2B.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemplateBuildStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::E2B.TemplateBuildStatus?>
    {
        /// <inheritdoc />
        public override global::E2B.TemplateBuildStatus? Read(
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
                        return global::E2B.TemplateBuildStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::E2B.TemplateBuildStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::E2B.TemplateBuildStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::E2B.TemplateBuildStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::E2B.TemplateBuildStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
