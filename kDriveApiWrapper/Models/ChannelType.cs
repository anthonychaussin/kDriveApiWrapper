namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel type.
    /// </summary>
    public enum ChannelType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"abr")]
        Abr = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"mono")]
        Mono = 1,
    }
}