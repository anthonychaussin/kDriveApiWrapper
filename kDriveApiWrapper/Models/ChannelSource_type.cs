namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel source_type.
    /// </summary>
    public enum ChannelSource_type
    {
        [System.Runtime.Serialization.EnumMember(Value = @"camip")]
        Camip = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"encoder")]
        Encoder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"maniak")]
        Maniak = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"mobile")]
        Mobile = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"webcam")]
        Webcam = 4,
    }
}