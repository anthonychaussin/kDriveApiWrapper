namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The calendar event attendees state.
    /// </summary>
    public enum CalendarEventAttendeesState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEEDS-ACTION")]
        NEEDSACTION = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ACCEPTED")]
        ACCEPTED = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DECLINED")]
        DECLINED = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"TENTATIVE")]
        TENTATIVE = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELEGATED")]
        DELEGATED = 4,
    }
}