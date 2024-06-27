namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ media activity cause.
    /// </summary>
    public enum Api_MediaActivityCause
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ELOQUENT_CREATED")]
        ELOQUENT_CREATED = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ELOQUENT_RESTORED")]
        ELOQUENT_RESTORED = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ELOQUENT_REMOVED")]
        ELOQUENT_REMOVED = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ELOQUENT_UNREMOVED")]
        ELOQUENT_UNREMOVED = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"ELOQUENT_DELETED")]
        ELOQUENT_DELETED = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_INITIALIZING")]
        UPLOAD_INITIALIZING = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_PULLING")]
        UPLOAD_PULLING = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_PULLED")]
        UPLOAD_PULLED = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_PUSHING")]
        UPLOAD_PUSHING = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_PUSHED")]
        UPLOAD_PUSHED = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"UPLOAD_FAILED")]
        UPLOAD_FAILED = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"AUDIO_SAMPLE_GENERATED")]
        AUDIO_SAMPLE_GENERATED = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"AUDIO_SAMPLE_GENERATING")]
        AUDIO_SAMPLE_GENERATING = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"AUDIO_WAVEFORM_GENERATED")]
        AUDIO_WAVEFORM_GENERATED = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"AUDIO_WAVEFORM_GENERATING")]
        AUDIO_WAVEFORM_GENERATING = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"SCENES_GENERATED")]
        SCENES_GENERATED = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"SCENES_GENERATING")]
        SCENES_GENERATING = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"THUMBNAIL_GENERATION_FAILED")]
        THUMBNAIL_GENERATION_FAILED = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"THUMBSTRIP_GENERATED")]
        THUMBSTRIP_GENERATED = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"THUMBSTRIP_GENERATING")]
        THUMBSTRIP_GENERATING = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_PREVIEW_GENERATED")]
        VIDEO_PREVIEW_GENERATED = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_PREVIEW_GENERATING")]
        VIDEO_PREVIEW_GENERATING = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_SAMPLE_GENERATED")]
        VIDEO_SAMPLE_GENERATED = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_SAMPLE_GENERATING")]
        VIDEO_SAMPLE_GENERATING = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_THUMBNAIL_GENERATED")]
        VIDEO_THUMBNAIL_GENERATED = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_THUMBNAIL_GENERATING")]
        VIDEO_THUMBNAIL_GENERATING = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"ENCODING")]
        ENCODING = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_POSTER_GENERATED")]
        VIDEO_POSTER_GENERATED = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"VIDEO_POSTER_GENERATING")]
        VIDEO_POSTER_GENERATING = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"FILE_STORING")]
        FILE_STORING = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"FILE_STORED")]
        FILE_STORED = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"ENCODING_QUEUED")]
        ENCODING_QUEUED = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"ENCODING_STARTED")]
        ENCODING_STARTED = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"ENCODING_FINISHED")]
        ENCODING_FINISHED = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"ENCODING_FAILED")]
        ENCODING_FAILED = 34,
    }
}