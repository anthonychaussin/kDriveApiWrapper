namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity report status.
    /// </summary>
    public enum ActivityReportStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"done")]
        Done = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"failed")]
        Failed = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"in_progress")]
        In_progress = 2,
    }
}