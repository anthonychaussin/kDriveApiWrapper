namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The external import file status.
    /// </summary>
    public enum ExternalImportFileStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"downloading")]
        Downloading = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"finished")]
        Finished = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"uploading")]
        Uploading = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"waiting")]
        Waiting = 4,
    }
}