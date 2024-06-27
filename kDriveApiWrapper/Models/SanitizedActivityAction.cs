namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sanitized activity action.
    /// </summary>
    public enum SanitizedActivityAction
    {
        [System.Runtime.Serialization.EnumMember(Value = @"archive")]
        Archive = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"archive_in_trash")]
        Archive_in_trash = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"file_deleted")]
        File_deleted = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"move")]
        Move = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"rename")]
        Rename = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"restore")]
        Restore = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"trash")]
        Trash = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"update")]
        Update = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"version_deleted")]
        Version_deleted = 8,
    }
}