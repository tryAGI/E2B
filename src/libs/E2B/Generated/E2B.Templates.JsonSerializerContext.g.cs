
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TeamUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogLevel), TypeInfoPropertyName = "LogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildStatus), TypeInfoPropertyName = "TemplateBuildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateRequestResponseV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateWithBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::E2B.TemplateBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateAliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.FromImageRegistry), TypeInfoPropertyName = "FromImageRegistry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.AWSRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GCPRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GeneralRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.FromImageRegistryDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.FromImageRegistryDiscriminatorType), TypeInfoPropertyName = "FromImageRegistryDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.AWSRegistryType), TypeInfoPropertyName = "AWSRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GCPRegistryType), TypeInfoPropertyName = "GCPRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GeneralRegistryType), TypeInfoPropertyName = "GeneralRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildStartV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::E2B.TemplateStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildFileUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.BuildLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.BuildStatusReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::E2B.BuildLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogsDirection), TypeInfoPropertyName = "LogsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogsSource), TypeInfoPropertyName = "LogsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::E2B.Template>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogLevel?), TypeInfoPropertyName = "NullableLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.TemplateBuildStatus?), TypeInfoPropertyName = "NullableTemplateBuildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.FromImageRegistry?), TypeInfoPropertyName = "NullableFromImageRegistry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.FromImageRegistryDiscriminatorType?), TypeInfoPropertyName = "NullableFromImageRegistryDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.AWSRegistryType?), TypeInfoPropertyName = "NullableAWSRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GCPRegistryType?), TypeInfoPropertyName = "NullableGCPRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.GeneralRegistryType?), TypeInfoPropertyName = "NullableGeneralRegistryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogsDirection?), TypeInfoPropertyName = "NullableLogsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::E2B.LogsSource?), TypeInfoPropertyName = "NullableLogsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::E2B.TemplateBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::E2B.TemplateStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::E2B.BuildLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::E2B.Template>))]
    internal sealed partial class TemplatesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TemplatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TemplatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::E2B.JsonConverters.FromImageRegistryJsonConverter());
            options.Converters.Add(new global::E2B.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::E2B.FromImageRegistryDiscriminatorType)

                    || typeToConvert == typeof(global::E2B.FromImageRegistryDiscriminatorType?)

                    || typeToConvert == typeof(global::E2B.AWSRegistryType)

                    || typeToConvert == typeof(global::E2B.AWSRegistryType?)

                    || typeToConvert == typeof(global::E2B.GCPRegistryType)

                    || typeToConvert == typeof(global::E2B.GCPRegistryType?)

                    || typeToConvert == typeof(global::E2B.GeneralRegistryType)

                    || typeToConvert == typeof(global::E2B.GeneralRegistryType?)

                    || typeToConvert == typeof(global::E2B.LogLevel)

                    || typeToConvert == typeof(global::E2B.LogLevel?)

                    || typeToConvert == typeof(global::E2B.TemplateBuildStatus)

                    || typeToConvert == typeof(global::E2B.TemplateBuildStatus?)

                    || typeToConvert == typeof(global::E2B.LogsDirection)

                    || typeToConvert == typeof(global::E2B.LogsDirection?)

                    || typeToConvert == typeof(global::E2B.LogsSource)

                    || typeToConvert == typeof(global::E2B.LogsSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::E2B.FromImageRegistryDiscriminatorType))
                {
                    return new global::E2B.JsonConverters.FromImageRegistryDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.FromImageRegistryDiscriminatorType?))
                {
                    return new global::E2B.JsonConverters.FromImageRegistryDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.AWSRegistryType))
                {
                    return new global::E2B.JsonConverters.AWSRegistryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.AWSRegistryType?))
                {
                    return new global::E2B.JsonConverters.AWSRegistryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.GCPRegistryType))
                {
                    return new global::E2B.JsonConverters.GCPRegistryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.GCPRegistryType?))
                {
                    return new global::E2B.JsonConverters.GCPRegistryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.GeneralRegistryType))
                {
                    return new global::E2B.JsonConverters.GeneralRegistryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.GeneralRegistryType?))
                {
                    return new global::E2B.JsonConverters.GeneralRegistryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogLevel))
                {
                    return new global::E2B.JsonConverters.LogLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogLevel?))
                {
                    return new global::E2B.JsonConverters.LogLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.TemplateBuildStatus))
                {
                    return new global::E2B.JsonConverters.TemplateBuildStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.TemplateBuildStatus?))
                {
                    return new global::E2B.JsonConverters.TemplateBuildStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogsDirection))
                {
                    return new global::E2B.JsonConverters.LogsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogsDirection?))
                {
                    return new global::E2B.JsonConverters.LogsDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogsSource))
                {
                    return new global::E2B.JsonConverters.LogsSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::E2B.LogsSource?))
                {
                    return new global::E2B.JsonConverters.LogsSourceNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TemplatesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}