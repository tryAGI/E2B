#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace E2B
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FromImageRegistry : global::System.IEquatable<FromImageRegistry>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::E2B.FromImageRegistryDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.AWSRegistry? Aws { get; init; }
#else
        public global::E2B.AWSRegistry? Aws { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.GCPRegistry? Gcp { get; init; }
#else
        public global::E2B.GCPRegistry? Gcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::E2B.GeneralRegistry? Registry { get; init; }
#else
        public global::E2B.GeneralRegistry? Registry { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Registry))]
#endif
        public bool IsRegistry => Registry != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FromImageRegistry(global::E2B.AWSRegistry value) => new FromImageRegistry((global::E2B.AWSRegistry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::E2B.AWSRegistry?(FromImageRegistry @this) => @this.Aws;

        /// <summary>
        /// 
        /// </summary>
        public FromImageRegistry(global::E2B.AWSRegistry? value)
        {
            Aws = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FromImageRegistry(global::E2B.GCPRegistry value) => new FromImageRegistry((global::E2B.GCPRegistry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::E2B.GCPRegistry?(FromImageRegistry @this) => @this.Gcp;

        /// <summary>
        /// 
        /// </summary>
        public FromImageRegistry(global::E2B.GCPRegistry? value)
        {
            Gcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FromImageRegistry(global::E2B.GeneralRegistry value) => new FromImageRegistry((global::E2B.GeneralRegistry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::E2B.GeneralRegistry?(FromImageRegistry @this) => @this.Registry;

        /// <summary>
        /// 
        /// </summary>
        public FromImageRegistry(global::E2B.GeneralRegistry? value)
        {
            Registry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FromImageRegistry(
            global::E2B.FromImageRegistryDiscriminatorType? type,
            global::E2B.AWSRegistry? aws,
            global::E2B.GCPRegistry? gcp,
            global::E2B.GeneralRegistry? registry
            )
        {
            Type = type;

            Aws = aws;
            Gcp = gcp;
            Registry = registry;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Registry as object ??
            Gcp as object ??
            Aws as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Gcp?.ToString() ??
            Registry?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsGcp && !IsRegistry || !IsAws && IsGcp && !IsRegistry || !IsAws && !IsGcp && IsRegistry;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::E2B.AWSRegistry?, TResult>? aws = null,
            global::System.Func<global::E2B.GCPRegistry?, TResult>? gcp = null,
            global::System.Func<global::E2B.GeneralRegistry?, TResult>? registry = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws && aws != null)
            {
                return aws(Aws!);
            }
            else if (IsGcp && gcp != null)
            {
                return gcp(Gcp!);
            }
            else if (IsRegistry && registry != null)
            {
                return registry(Registry!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::E2B.AWSRegistry?>? aws = null,
            global::System.Action<global::E2B.GCPRegistry?>? gcp = null,
            global::System.Action<global::E2B.GeneralRegistry?>? registry = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsRegistry)
            {
                registry?.Invoke(Registry!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::E2B.AWSRegistry),
                Gcp,
                typeof(global::E2B.GCPRegistry),
                Registry,
                typeof(global::E2B.GeneralRegistry),
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
        public bool Equals(FromImageRegistry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::E2B.AWSRegistry?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::E2B.GCPRegistry?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::E2B.GeneralRegistry?>.Default.Equals(Registry, other.Registry) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FromImageRegistry obj1, FromImageRegistry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FromImageRegistry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FromImageRegistry obj1, FromImageRegistry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FromImageRegistry o && Equals(o);
        }
    }
}
