namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The uploadsegment status.
    /// </summary>
    public enum UploadsegmentStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ok")]
        Ok = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"uploading")]
        Uploading = 2,
    }
}