namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ encoding audio_codec.
    /// </summary>
    public enum Api_EncodingAudio_codec
    {
        [System.Runtime.Serialization.EnumMember(Value = @"AAC")]
        AAC = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"HE_AAC")]
        HE_AAC = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"FLAC")]
        FLAC = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MP3")]
        MP3 = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"VORBIS")]
        VORBIS = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"COPY")]
        COPY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"OPUS")]
        OPUS = 6,
    }
}