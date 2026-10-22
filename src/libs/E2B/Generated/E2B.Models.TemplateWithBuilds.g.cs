#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TemplateWithBuilds : global::System.IEquatable<TemplateWithBuilds>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.Template? Template { get; init; }
#else
        public global::E2B.Template? Template { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Template))]
#endif
        public bool IsTemplate => Template != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.Template? value)
        {
            value = Template;
            return IsTemplate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.Template PickTemplate() => Template is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Template' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.TemplateWithBuildsVariant2? TemplateWithBuildsVariant2 { get; init; }
#else
        public global::E2B.TemplateWithBuildsVariant2? TemplateWithBuildsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateWithBuildsVariant2))]
#endif
        public bool IsTemplateWithBuildsVariant2 => TemplateWithBuildsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateWithBuildsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.TemplateWithBuildsVariant2? value)
        {
            value = TemplateWithBuildsVariant2;
            return IsTemplateWithBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.TemplateWithBuildsVariant2 PickTemplateWithBuildsVariant2() => TemplateWithBuildsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateWithBuildsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateWithBuilds(global::E2B.Template value) => new TemplateWithBuilds((global::E2B.Template?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.Template?(TemplateWithBuilds @this) => @this.Template;

        /// <summary>
        ///
        /// </summary>
        public TemplateWithBuilds(global::E2B.Template? value)
        {
            Template = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateWithBuilds FromTemplate(global::E2B.Template? value) => new TemplateWithBuilds(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateWithBuilds(global::E2B.TemplateWithBuildsVariant2 value) => new TemplateWithBuilds((global::E2B.TemplateWithBuildsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.TemplateWithBuildsVariant2?(TemplateWithBuilds @this) => @this.TemplateWithBuildsVariant2;

        /// <summary>
        ///
        /// </summary>
        public TemplateWithBuilds(global::E2B.TemplateWithBuildsVariant2? value)
        {
            TemplateWithBuildsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateWithBuilds FromTemplateWithBuildsVariant2(global::E2B.TemplateWithBuildsVariant2? value) => new TemplateWithBuilds(value);

        /// <summary>
        ///
        /// </summary>
        public TemplateWithBuilds(
            global::E2B.Template? template,
            global::E2B.TemplateWithBuildsVariant2? templateWithBuildsVariant2
            )
        {
            Template = template;
            TemplateWithBuildsVariant2 = templateWithBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TemplateWithBuildsVariant2 as object ??
            Template as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Template?.ToString() ??
            TemplateWithBuildsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTemplate && IsTemplateWithBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::E2B.Template, TResult>? template = null,
            global::System.Func<global::E2B.TemplateWithBuildsVariant2, TResult>? templateWithBuildsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Template is { } __value0 && template != null)
            {
                return template(__value0);
            }
            else if (TemplateWithBuildsVariant2 is { } __value1 && templateWithBuildsVariant2 != null)
            {
                return templateWithBuildsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::E2B.Template>? template = null,

            global::System.Action<global::E2B.TemplateWithBuildsVariant2>? templateWithBuildsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Template is { } __value0)
            {
                template?.Invoke(__value0);
            }
            else if (TemplateWithBuildsVariant2 is { } __value1)
            {
                templateWithBuildsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::E2B.Template>? template = null,
            global::System.Action<global::E2B.TemplateWithBuildsVariant2>? templateWithBuildsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Template is { } __value0)
            {
                template?.Invoke(__value0);
            }
            else if (TemplateWithBuildsVariant2 is { } __value1)
            {
                templateWithBuildsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Template,
                typeof(global::E2B.Template),
                TemplateWithBuildsVariant2,
                typeof(global::E2B.TemplateWithBuildsVariant2),
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
        public bool Equals(TemplateWithBuilds other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::E2B.Template?>.Default.Equals(Template, other.Template) &&
                global::System.Collections.Generic.EqualityComparer<global::E2B.TemplateWithBuildsVariant2?>.Default.Equals(TemplateWithBuildsVariant2, other.TemplateWithBuildsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemplateWithBuilds obj1, TemplateWithBuilds obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateWithBuilds>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemplateWithBuilds obj1, TemplateWithBuilds obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateWithBuilds o && Equals(o);
        }
    }
}
