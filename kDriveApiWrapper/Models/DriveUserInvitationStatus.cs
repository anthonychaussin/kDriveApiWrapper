namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user invitation status.
    /// </summary>
    public enum DriveUserInvitationStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"accepted")]
        Accepted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"cancelled")]
        Cancelled = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"rejected")]
        Rejected = 3,
    }
}