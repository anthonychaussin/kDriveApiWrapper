namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The rewind archiving.
    /// </summary>
    public enum RewindArchiving
    {
        [System.Runtime.Serialization.EnumMember(Value = @"all")]
        All = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"current")]
        Current = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"none")]
        None = 2,
    }
}