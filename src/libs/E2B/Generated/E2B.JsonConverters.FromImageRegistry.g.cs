#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace E2B.JsonConverters
{
    /// <inheritdoc />
    public class FromImageRegistryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::E2B.FromImageRegistry>
    {
        /// <inheritdoc />
        public override global::E2B.FromImageRegistry Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.FromImageRegistryDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.FromImageRegistryDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::E2B.FromImageRegistryDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::E2B.AWSRegistry? aws = default;
            if (discriminator?.Type == global::E2B.FromImageRegistryDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.AWSRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.AWSRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::E2B.AWSRegistry)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::E2B.GCPRegistry? gcp = default;
            if (discriminator?.Type == global::E2B.FromImageRegistryDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.GCPRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.GCPRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::E2B.GCPRegistry)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::E2B.GeneralRegistry? registry = default;
            if (discriminator?.Type == global::E2B.FromImageRegistryDiscriminatorType.Registry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.GeneralRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.GeneralRegistry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::E2B.GeneralRegistry)}");
                registry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::E2B.FromImageRegistry(
                discriminator?.Type,
                aws,

                gcp,

                registry
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::E2B.FromImageRegistry value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.AWSRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.AWSRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.AWSRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.GCPRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.GCPRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.GCPRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
            else if (value.IsRegistry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::E2B.GeneralRegistry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::E2B.GeneralRegistry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::E2B.GeneralRegistry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Registry!, typeInfo);
            }
        }
    }
}