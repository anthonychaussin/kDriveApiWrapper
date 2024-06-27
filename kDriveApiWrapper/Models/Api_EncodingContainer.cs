namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ encoding container.
    /// </summary>
    public enum Api_EncodingContainer
    {
        [System.Runtime.Serialization.EnumMember(Value = @"FLV")]
        FLV = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"M4A")]
        M4A = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"MKV")]
        MKV = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MP4")]
        MP4 = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"WEBM")]
        WEBM = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"MP3")]
        MP3 = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"COPY")]
        COPY = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"AAC")]
        AAC = 7,
    }
}