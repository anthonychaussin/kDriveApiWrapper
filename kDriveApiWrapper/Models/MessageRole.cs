namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The message role.
    /// </summary>
    public enum MessageRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"assistant")]
        Assistant = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"system")]
        System = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}