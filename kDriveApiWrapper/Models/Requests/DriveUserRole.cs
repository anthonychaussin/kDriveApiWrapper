namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body10 role.
    /// </summary>
    public enum DriveUserRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"external")]
        External = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}