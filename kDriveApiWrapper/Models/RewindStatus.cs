namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The rewind status.
    /// </summary>
    public enum RewindStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"canceled")]
        Canceled = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"done")]
        Done = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"drive_not_ready")]
        Drive_not_ready = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"expired")]
        Expired = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"failed")]
        Failed = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"in_progress")]
        In_progress = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"new")]
        New = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"sanitizing")]
        Sanitizing = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"waiting_approval")]
        Waiting_approval = 8,
    }
}