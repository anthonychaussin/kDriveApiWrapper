namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The upload session feedback message.
    /// </summary>
    public enum UploadSessionFeedbackMessage
    {
        [System.Runtime.Serialization.EnumMember(Value = @"conflict_error")]
        Conflict_error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file_already_exists_error")]
        File_already_exists_error = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"forbidden_error")]
        Forbidden_error = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"lock_error")]
        Lock_error = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"quota_exceeded_error")]
        Quota_exceeded_error = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_by_another_user_not_terminated_error")]
        Upload_by_another_user_not_terminated_error = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_error")]
        Upload_error = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_failed_error")]
        Upload_failed_error = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_not_terminated_error")]
        Upload_not_terminated_error = 8,
    }
}