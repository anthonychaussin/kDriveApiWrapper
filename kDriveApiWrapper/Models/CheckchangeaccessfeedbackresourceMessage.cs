namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The checkchangeaccessfeedbackresource message.
    /// </summary>
    public enum CheckchangeaccessfeedbackresourceMessage
    {
        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"user_not_connected_to_drive")]
        User_not_connected_to_drive = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user_right_is_same_level")]
        User_right_is_same_level = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"user_right_need_change")]
        User_right_need_change = 3,
    }
}