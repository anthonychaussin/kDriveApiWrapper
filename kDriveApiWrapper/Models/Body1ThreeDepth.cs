namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body1 three depth.
    /// </summary>
    public enum Body1ThreeDepth
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