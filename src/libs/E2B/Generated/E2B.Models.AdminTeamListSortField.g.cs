
#nullable enable

namespace E2B
{
    /// <summary>
    /// Column to order by, with newer teams first among equal values. Omit it<br/>
    /// to list the newest teams first.
    /// </summary>
    public enum AdminTeamListSortField
    {
        /// <summary>
        ///
        /// </summary>
        AdminTeamListSortFieldCreatedAt,
        /// <summary>
        ///
        /// </summary>
        AdminTeamListSortFieldEmail,
        /// <summary>
        ///
        /// </summary>
        AdminTeamListSortFieldName,
        /// <summary>
        ///
        /// </summary>
        AdminTeamListSortFieldRunningSandboxes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminTeamListSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminTeamListSortField value)
        {
            return value switch
            {
                AdminTeamListSortField.AdminTeamListSortFieldCreatedAt => "createdAt",
                AdminTeamListSortField.AdminTeamListSortFieldEmail => "email",
                AdminTeamListSortField.AdminTeamListSortFieldName => "name",
                AdminTeamListSortField.AdminTeamListSortFieldRunningSandboxes => "runningSandboxes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminTeamListSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => AdminTeamListSortField.AdminTeamListSortFieldCreatedAt,
                "email" => AdminTeamListSortField.AdminTeamListSortFieldEmail,
                "name" => AdminTeamListSortField.AdminTeamListSortFieldName,
                "runningSandboxes" => AdminTeamListSortField.AdminTeamListSortFieldRunningSandboxes,
                _ => null,
            };
        }
    }
}