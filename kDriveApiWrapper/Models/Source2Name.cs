namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The source2 name.
    /// </summary>
    public enum Source2Name
    {
        [System.Runtime.Serialization.EnumMember(Value = @"api")]
        Api = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"job")]
        Job = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"webdav")]
        Webdav = 2,
    }
}