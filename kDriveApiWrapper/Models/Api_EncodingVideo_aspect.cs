namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ encoding video_aspect.
    /// </summary>
    public enum Api_EncodingVideo_aspect
    {
        [System.Runtime.Serialization.EnumMember(Value = @"LETTERBOX")]
        LETTERBOX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"STRETCH")]
        STRETCH = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"FILL")]
        FILL = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"KEEP_RATIO")]
        KEEP_RATIO = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"COPY")]
        COPY = 4,
    }
}