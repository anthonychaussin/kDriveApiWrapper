namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The rewind mode.
    /// </summary>
    public enum RewindMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"directory")]
        Directory = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"drive")]
        Drive = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}