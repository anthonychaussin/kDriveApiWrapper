namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The files property.
    /// </summary>
    public enum FilesProperty
    {
        [System.Runtime.Serialization.EnumMember(Value = @"deleted_at")]
        Deleted_at = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"last_modified_at")]
        Last_modified_at = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"path")]
        Path = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"size")]
        Size = 3,
    }
}