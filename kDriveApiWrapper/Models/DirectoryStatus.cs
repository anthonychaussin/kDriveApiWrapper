namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The directory status.
    /// </summary>
    public enum DirectoryStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"erasing")]
        Erasing = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"locked")]
        Locked = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"trash_inherited")]
        Trash_inherited = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"trashed")]
        Trashed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"uploading")]
        Uploading = 4,
    }
}