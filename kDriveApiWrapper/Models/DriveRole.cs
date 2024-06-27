namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive role.
    /// </summary>
    public enum DriveRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"external")]
        External = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"none")]
        None = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 3,
    }
}