#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TemplateBuildWithTags : global::System.IEquatable<TemplateBuildWithTags>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.TemplateBuild? TemplateBuild { get; init; }
#else
        public global::E2B.TemplateBuild? TemplateBuild { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateBuild))]
#endif
        public bool IsTemplateBuild => TemplateBuild != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateBuild(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.TemplateBuild? value)
        {
            value = TemplateBuild;
            return IsTemplateBuild;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuild PickTemplateBuild() => TemplateBuild is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateBuild' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.TemplateBuildWithTagsVariant2? TemplateBuildWithTagsVariant2 { get; init; }
#else
        public global::E2B.TemplateBuildWithTagsVariant2? TemplateBuildWithTagsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateBuildWithTagsVariant2))]
#endif
        public bool IsTemplateBuildWithTagsVariant2 => TemplateBuildWithTagsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateBuildWithTagsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.TemplateBuildWithTagsVariant2? value)
        {
            value = TemplateBuildWithTagsVariant2;
            return IsTemplateBuildWithTagsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateBuildWithTagsVariant2 PickTemplateBuildWithTagsVariant2() => TemplateBuildWithTagsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateBuildWithTagsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateBuildWithTags(global::E2B.TemplateBuild value) => new TemplateBuildWithTags((global::E2B.TemplateBuild?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.TemplateBuild?(TemplateBuildWithTags @this) => @this.TemplateBuild;

        /// <summary>
        ///
        /// </summary>
        public TemplateBuildWithTags(global::E2B.TemplateBuild? value)
        {
            TemplateBuild = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateBuildWithTags FromTemplateBuild(global::E2B.TemplateBuild? value) => new TemplateBuildWithTags(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateBuildWithTags(global::E2B.TemplateBuildWithTagsVariant2 value) => new TemplateBuildWithTags((global::E2B.TemplateBuildWithTagsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.TemplateBuildWithTagsVariant2?(TemplateBuildWithTags @this) => @this.TemplateBuildWithTagsVariant2;

        /// <summary>
        ///
        /// </summary>
        public TemplateBuildWithTags(global::E2B.TemplateBuildWithTagsVariant2? value)
        {
            TemplateBuildWithTagsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateBuildWithTags FromTemplateBuildWithTagsVariant2(global::E2B.TemplateBuildWithTagsVariant2? value) => new TemplateBuildWithTags(value);

        /// <summary>
        ///
        /// </summary>
        public TemplateBuildWithTags(
            global::E2B.TemplateBuild? templateBuild,
            global::E2B.TemplateBuildWithTagsVariant2? templateBuildWithTagsVariant2
            )
        {
            TemplateBuild = templateBuild;
            TemplateBuildWithTagsVariant2 = templateBuildWithTagsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TemplateBuildWithTagsVariant2 as object ??
            TemplateBuild as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TemplateBuild?.ToString() ??
            TemplateBuildWithTagsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTemplateBuild && IsTemplateBuildWithTagsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::E2B.TemplateBuild, TResult>? templateBuild = null,
            global::System.Func<global::E2B.TemplateBuildWithTagsVariant2, TResult>? templateBuildWithTagsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TemplateBuild is { } __value0 && templateBuild != null)
            {
                return templateBuild(__value0);
            }
            else if (TemplateBuildWithTagsVariant2 is { } __value1 && templateBuildWithTagsVariant2 != null)
            {
                return templateBuildWithTagsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::E2B.TemplateBuild>? templateBuild = null,

            global::System.Action<global::E2B.TemplateBuildWithTagsVariant2>? templateBuildWithTagsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TemplateBuild is { } __value0)
            {
                templateBuild?.Invoke(__value0);
            }
            else if (TemplateBuildWithTagsVariant2 is { } __value1)
            {
                templateBuildWithTagsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::E2B.TemplateBuild>? templateBuild = null,
            global::System.Action<global::E2B.TemplateBuildWithTagsVariant2>? templateBuildWithTagsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TemplateBuild is { } __value0)
            {
                templateBuild?.Invoke(__value0);
            }
            else if (TemplateBuildWithTagsVariant2 is { } __value1)
            {
                templateBuildWithTagsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TemplateBuild,
                typeof(global::E2B.TemplateBuild),
                TemplateBuildWithTagsVariant2,
                typeof(global::E2B.TemplateBuildWithTagsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(TemplateBuildWithTags other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::E2B.TemplateBuild?>.Default.Equals(TemplateBuild, other.TemplateBuild) &&
                global::System.Collections.Generic.EqualityComparer<global::E2B.TemplateBuildWithTagsVariant2?>.Default.Equals(TemplateBuildWithTagsVariant2, other.TemplateBuildWithTagsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemplateBuildWithTags obj1, TemplateBuildWithTags obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateBuildWithTags>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemplateBuildWithTags obj1, TemplateBuildWithTags obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateBuildWithTags o && Equals(o);
        }
    }
}
