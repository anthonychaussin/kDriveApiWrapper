namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The star conflict.
    /// </summary>
    public enum StarConflict
    {
        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"rename")]
        Rename = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"version")]
        Version = 2,
    }
}