namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userfileaccess status.
    /// </summary>
    public enum UserfileaccessStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"accepted")]
        Accepted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"cancelled")]
        Cancelled = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"expired")]
        Expired = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"rejected")]
        Rejected = 4,
    }
}