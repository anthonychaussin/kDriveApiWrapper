namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The extern invitation file access access.
    /// </summary>
    public enum ExternInvitationFileAccessAccess
    {
        [System.Runtime.Serialization.EnumMember(Value = @"invitation")]
        Invitation = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}