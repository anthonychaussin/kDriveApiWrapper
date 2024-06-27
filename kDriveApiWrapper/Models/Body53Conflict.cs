namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body53 conflict.
    /// </summary>
    public enum Body53Conflict
    {
        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"rename")]
        Rename = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"version")]
        Version = 2,
    }
}