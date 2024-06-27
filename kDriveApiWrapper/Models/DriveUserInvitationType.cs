namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user invitation type.
    /// </summary>
    public enum DriveUserInvitationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 1,
    }
}