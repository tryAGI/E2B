#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace E2B.JsonConverters
{
    /// <inheritdoc />
    public class ManagementProjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::E2B.ManagementProject>
    {
        /// <inheritdoc />
        public override global::E2B.ManagementProject Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::E2B.ManagementProjectUpsertRequest? upsertRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.ManagementProjectUpsertRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.ManagementProjectUpsertRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.ManagementProjectUpsertRequest).Name}");
                upsertRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }

            global::E2B.ManagementProjectVariant2? managementProjectVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.ManagementProjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.ManagementProjectVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.ManagementProjectVariant2).Name}");
                managementProjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }
            var __value = new global::E2B.ManagementProject(
                upsertRequest,

                managementProjectVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::E2B.ManagementProject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsUpsertRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.ManagementProjectUpsertRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.ManagementProjectUpsertRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.ManagementProjectUpsertRequest).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickUpsertRequest(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsManagementProjectVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.ManagementProjectVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.ManagementProjectVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.ManagementProjectVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickManagementProjectVariant2(), typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}