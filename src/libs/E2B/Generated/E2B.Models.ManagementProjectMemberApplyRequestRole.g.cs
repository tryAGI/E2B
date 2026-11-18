
#nullable enable

namespace E2B
{
    /// <summary>
    /// The member's effective role on the project. A viewer may only read. An omitted role keeps the stored one, and a new member without one is stored as member.
    /// </summary>
    public enum ManagementProjectMemberApplyRequestRole
    {
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Owner,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagementProjectMemberApplyRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementProjectMemberApplyRequestRole value)
        {
            return value switch
            {
                ManagementProjectMemberApplyRequestRole.Member => "member",
                ManagementProjectMemberApplyRequestRole.Owner => "owner",
                ManagementProjectMemberApplyRequestRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementProjectMemberApplyRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ManagementProjectMemberApplyRequestRole.Member,
                "owner" => ManagementProjectMemberApplyRequestRole.Owner,
                "viewer" => ManagementProjectMemberApplyRequestRole.Viewer,
                _ => null,
            };
        }
    }
}