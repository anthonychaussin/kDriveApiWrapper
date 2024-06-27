namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The depth.
    /// </summary>
    public enum Depth
    {
        [System.Runtime.Serialization.EnumMember(Value = @"children")]
        Children = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"folder")]
        Folder = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"unlimited")]
        Unlimited = 3,
    }
}