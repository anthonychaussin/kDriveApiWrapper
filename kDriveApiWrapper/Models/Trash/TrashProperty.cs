namespace kDriveApiWrapper.Models.Trash
{
    /// <summary>
    /// The trash2 property.
    /// </summary>
    public enum TrashProperty
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