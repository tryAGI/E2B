#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ManagementProject : global::System.IEquatable<ManagementProject>
    {
        /// <summary>
        /// The properties of a project this side stores. Name, slug and email are synchronized on every push. The optional cluster assignment is preserved when omitted.<br/>
        /// A project's tier is not among them, and this side assigns none. Limits arrive separately and in full through managementUpsertProjectLimits.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.ManagementProjectUpsertRequest? UpsertRequest { get; init; }
#else
        public global::E2B.ManagementProjectUpsertRequest? UpsertRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpsertRequest))]
#endif
        public bool IsUpsertRequest => UpsertRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpsertRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.ManagementProjectUpsertRequest? value)
        {
            value = UpsertRequest;
            return IsUpsertRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectUpsertRequest PickUpsertRequest() => UpsertRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpsertRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.ManagementProjectVariant2? ManagementProjectVariant2 { get; init; }
#else
        public global::E2B.ManagementProjectVariant2? ManagementProjectVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ManagementProjectVariant2))]
#endif
        public bool IsManagementProjectVariant2 => ManagementProjectVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickManagementProjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::E2B.ManagementProjectVariant2? value)
        {
            value = ManagementProjectVariant2;
            return IsManagementProjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::E2B.ManagementProjectVariant2 PickManagementProjectVariant2() => ManagementProjectVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ManagementProjectVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagementProject(global::E2B.ManagementProjectUpsertRequest value) => new ManagementProject((global::E2B.ManagementProjectUpsertRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.ManagementProjectUpsertRequest?(ManagementProject @this) => @this.UpsertRequest;

        /// <summary>
        ///
        /// </summary>
        public ManagementProject(global::E2B.ManagementProjectUpsertRequest? value)
        {
            UpsertRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagementProject FromUpsertRequest(global::E2B.ManagementProjectUpsertRequest? value) => new ManagementProject(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagementProject(global::E2B.ManagementProjectVariant2 value) => new ManagementProject((global::E2B.ManagementProjectVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::E2B.ManagementProjectVariant2?(ManagementProject @this) => @this.ManagementProjectVariant2;

        /// <summary>
        ///
        /// </summary>
        public ManagementProject(global::E2B.ManagementProjectVariant2? value)
        {
            ManagementProjectVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagementProject FromManagementProjectVariant2(global::E2B.ManagementProjectVariant2? value) => new ManagementProject(value);

        /// <summary>
        ///
        /// </summary>
        public ManagementProject(
            global::E2B.ManagementProjectUpsertRequest? upsertRequest,
            global::E2B.ManagementProjectVariant2? managementProjectVariant2
            )
        {
            UpsertRequest = upsertRequest;
            ManagementProjectVariant2 = managementProjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ManagementProjectVariant2 as object ??
            UpsertRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UpsertRequest?.ToString() ??
            ManagementProjectVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUpsertRequest && IsManagementProjectVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::E2B.ManagementProjectUpsertRequest, TResult>? upsertRequest = null,
            global::System.Func<global::E2B.ManagementProjectVariant2, TResult>? managementProjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UpsertRequest is { } __value0 && upsertRequest != null)
            {
                return upsertRequest(__value0);
            }
            else if (ManagementProjectVariant2 is { } __value1 && managementProjectVariant2 != null)
            {
                return managementProjectVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::E2B.ManagementProjectUpsertRequest>? upsertRequest = null,

            global::System.Action<global::E2B.ManagementProjectVariant2>? managementProjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UpsertRequest is { } __value0)
            {
                upsertRequest?.Invoke(__value0);
            }
            else if (ManagementProjectVariant2 is { } __value1)
            {
                managementProjectVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::E2B.ManagementProjectUpsertRequest>? upsertRequest = null,
            global::System.Action<global::E2B.ManagementProjectVariant2>? managementProjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UpsertRequest is { } __value0)
            {
                upsertRequest?.Invoke(__value0);
            }
            else if (ManagementProjectVariant2 is { } __value1)
            {
                managementProjectVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpsertRequest,
                typeof(global::E2B.ManagementProjectUpsertRequest),
                ManagementProjectVariant2,
                typeof(global::E2B.ManagementProjectVariant2),
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
        public bool Equals(ManagementProject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::E2B.ManagementProjectUpsertRequest?>.Default.Equals(UpsertRequest, other.UpsertRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::E2B.ManagementProjectVariant2?>.Default.Equals(ManagementProjectVariant2, other.ManagementProjectVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ManagementProject obj1, ManagementProject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagementProject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ManagementProject obj1, ManagementProject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagementProject o && Equals(o);
        }
    }
}
