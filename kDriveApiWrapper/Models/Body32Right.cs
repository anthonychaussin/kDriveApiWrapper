namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body32 right.
    /// </summary>
    public enum Body32Right
    {
        [System.Runtime.Serialization.EnumMember(Value = @"manage")]
        Manage = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"none")]
        None = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"read")]
        Read = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"write")]
        Write = 3,
    }
}