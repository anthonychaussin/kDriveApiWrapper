namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user status.
    /// </summary>
    public enum DriveUserStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_kept")]
        Deleted_kept = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_removed")]
        Deleted_removed = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_transferred")]
        Deleted_transferred = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_transferring")]
        Deleted_transferring = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"locked")]
        Locked = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 6,
    }
}