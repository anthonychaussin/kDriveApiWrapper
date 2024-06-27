namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userfileaccess access.
    /// </summary>
    public enum UserfileaccessAccess
    {
        [System.Runtime.Serialization.EnumMember(Value = @"invitation")]
        Invitation = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}