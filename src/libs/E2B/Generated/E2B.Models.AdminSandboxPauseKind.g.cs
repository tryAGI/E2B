
#nullable enable

namespace E2B
{
    /// <summary>
    /// What a pause kept: memory is a full snapshot that resumes where the<br/>
    /// sandbox left off, filesystem keeps only the root filesystem and boots<br/>
    /// it again on resume
    /// </summary>
    public enum AdminSandboxPauseKind
    {
        /// <summary>
        ///
        /// </summary>
        AdminSandboxPauseKindFilesystem,
        /// <summary>
        /// memory is a full snapshot that resumes where the
        /// </summary>
        AdminSandboxPauseKindMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminSandboxPauseKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminSandboxPauseKind value)
        {
            return value switch
            {
                AdminSandboxPauseKind.AdminSandboxPauseKindFilesystem => "filesystem",
                AdminSandboxPauseKind.AdminSandboxPauseKindMemory => "memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminSandboxPauseKind? ToEnum(string value)
        {
            return value switch
            {
                "filesystem" => AdminSandboxPauseKind.AdminSandboxPauseKindFilesystem,
                "memory" => AdminSandboxPauseKind.AdminSandboxPauseKindMemory,
                _ => null,
            };
        }
    }
}