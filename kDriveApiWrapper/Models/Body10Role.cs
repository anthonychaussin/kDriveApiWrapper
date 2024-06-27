namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body10 role.
    /// </summary>
    public enum Body10Role
    {
        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"external")]
        External = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}