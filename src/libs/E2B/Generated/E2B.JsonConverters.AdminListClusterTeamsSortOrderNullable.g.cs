#nullable enable

namespace E2B.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdminListClusterTeamsSortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::E2B.AdminListClusterTeamsSortOrder?>
    {
        /// <inheritdoc />
        public override global::E2B.AdminListClusterTeamsSortOrder? Read(
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
                        return global::E2B.AdminListClusterTeamsSortOrderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::E2B.AdminListClusterTeamsSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::E2B.AdminListClusterTeamsSortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::E2B.AdminListClusterTeamsSortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::E2B.AdminListClusterTeamsSortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
