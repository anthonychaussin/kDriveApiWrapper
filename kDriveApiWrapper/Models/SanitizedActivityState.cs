namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sanitized activity state.
    /// </summary>
    public enum SanitizedActivityState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"not_executed")]
        Not_executed = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"not_handled")]
        Not_handled = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"on_conflict")]
        On_conflict = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"on_error")]
        On_error = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"success")]
        Success = 4,
    }
}