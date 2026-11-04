
#nullable enable

namespace E2B
{
    /// <summary>
    /// Coarse build state derived from the build status: pending (pending,<br/>
    /// waiting), in_progress (in_progress, building, snapshotting), ready<br/>
    /// (ready, uploaded, success) or failed (any other status)
    /// </summary>
    public enum AdminSandboxBuildStatusGroup
    {
        /// <summary>
        ///
        /// </summary>
        AdminSandboxBuildStatusGroupFailed,
        /// <summary>
        ///
        /// </summary>
        AdminSandboxBuildStatusGroupInProgress,
        /// <summary>
        /// pending (pending,
        /// </summary>
        AdminSandboxBuildStatusGroupPending,
        /// <summary>
        ///
        /// </summary>
        AdminSandboxBuildStatusGroupReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminSandboxBuildStatusGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminSandboxBuildStatusGroup value)
        {
            return value switch
            {
                AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupFailed => "failed",
                AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupInProgress => "in_progress",
                AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupPending => "pending",
                AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupReady => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminSandboxBuildStatusGroup? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupFailed,
                "in_progress" => AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupInProgress,
                "pending" => AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupPending,
                "ready" => AdminSandboxBuildStatusGroup.AdminSandboxBuildStatusGroupReady,
                _ => null,
            };
        }
    }
}