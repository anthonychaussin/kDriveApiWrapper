namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The error code.
    /// </summary>
    public enum ErrorCode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"not_found_error")]
        Not_found_error,

        [System.Runtime.Serialization.EnumMember(Value = @"category_right_error")]
        Category_right_error,

        [System.Runtime.Serialization.EnumMember(Value = @"drive_is_in_maintenance_error")]
        Drive_is_in_maintenance_error,

        [System.Runtime.Serialization.EnumMember(Value = @"category_error")]
        Category_error,

        [System.Runtime.Serialization.EnumMember(Value = @"content_advanced_search_currently_being_activated_error")]
        Content_advanced_search_currently_being_activated_error,

        [System.Runtime.Serialization.EnumMember(Value = @"content_advanced_search_currently_being_deactivated_error")]
        Content_advanced_search_currently_being_deactivated_error,

        [System.Runtime.Serialization.EnumMember(Value = @"content_advanced_search_require_base_error")]
        Content_advanced_search_require_base_error,

        [System.Runtime.Serialization.EnumMember(Value = @"forbidden_error")]
        Forbidden_error,

        [System.Runtime.Serialization.EnumMember(Value = @"content_advanced_search_not_compatible_with_this_offer_error")]
        Content_advanced_search_not_compatible_with_this_offer_error,

        [System.Runtime.Serialization.EnumMember(Value = @"drive_user_quota_reached")]
        Drive_user_quota_reached,

        [System.Runtime.Serialization.EnumMember(Value = @"one_email_or_user_at_least_required")]
        One_email_or_user_at_least_required,

        [System.Runtime.Serialization.EnumMember(Value = @"user_not_associated_with_drive")]
        User_not_associated_with_drive,

        [System.Runtime.Serialization.EnumMember(Value = @"no_metrics_requested_error")]
        No_metrics_requested_error,

        [System.Runtime.Serialization.EnumMember(Value = @"external_import_already_canceled_error")]
        External_import_already_canceled_error,

        [System.Runtime.Serialization.EnumMember(Value = @"bad_request_error")]
        Bad_request_error,

        [System.Runtime.Serialization.EnumMember(Value = @"cannot_get_a_temporary_url_for_a_directory")]
        Cannot_get_a_temporary_url_for_a_directory,

        [System.Runtime.Serialization.EnumMember(Value = @"permission_denied")]
        Permission_denied,

        [System.Runtime.Serialization.EnumMember(Value = @"unsupported_file_type")]
        Unsupported_file_type,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_already_exists_for_file")]
        Collaborative_folder_already_exists_for_file,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_must_by_a_folder")]
        Collaborative_folder_must_by_a_folder,

        [System.Runtime.Serialization.EnumMember(Value = @"too_many_files_error")]
        Too_many_files_error,

        [System.Runtime.Serialization.EnumMember(Value = @"lock_error")]
        Lock_error,

        [System.Runtime.Serialization.EnumMember(Value = @"destination_not_writable")]
        Destination_not_writable,

        [System.Runtime.Serialization.EnumMember(Value = @"not_a_directory_error")]
        Not_a_directory_error,

        [System.Runtime.Serialization.EnumMember(Value = @"invalid_path_error")]
        Invalid_path_error,

        [System.Runtime.Serialization.EnumMember(Value = @"destination_not_a_directory")]
        Destination_not_a_directory,

        [System.Runtime.Serialization.EnumMember(Value = @"invalid_file_name_error")]
        Invalid_file_name_error,

        [System.Runtime.Serialization.EnumMember(Value = @"results_set_too_large_error")]
        Results_set_too_large_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_by_another_user_not_terminated_error")]
        Upload_by_another_user_not_terminated_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_error")]
        Upload_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_failed_error")]
        Upload_failed_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_not_terminated_error")]
        Upload_not_terminated_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_destination_not_writable_error")]
        Upload_destination_not_writable_error,

        [System.Runtime.Serialization.EnumMember(Value = @"upload_destination_not_found_error")]
        Upload_destination_not_found_error,

        [System.Runtime.Serialization.EnumMember(Value = @"file_already_exists_error")]
        File_already_exists_error,

        [System.Runtime.Serialization.EnumMember(Value = @"quota_exceeded_error")]
        Quota_exceeded_error,

        [System.Runtime.Serialization.EnumMember(Value = @"conflict_error")]
        Conflict_error,

        [System.Runtime.Serialization.EnumMember(Value = @"too_many_upload_sessions_error")]
        Too_many_upload_sessions_error,
    }
}