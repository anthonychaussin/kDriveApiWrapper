namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user type.
    /// </summary>
    public enum DriveUserType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"main")]
        Main = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"shared")]
        Shared = 1,
    }
}