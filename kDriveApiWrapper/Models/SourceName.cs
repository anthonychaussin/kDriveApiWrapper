namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The source name.
    /// </summary>
    public enum SourceName
    {
        [System.Runtime.Serialization.EnumMember(Value = @"api")]
        Api = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"job")]
        Job = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"webdav")]
        Webdav = 2,
    }
}