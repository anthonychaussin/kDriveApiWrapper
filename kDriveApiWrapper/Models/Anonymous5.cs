namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Logged interaction type of activities on the drive or file.&lt;note&gt;&lt;strong&gt;acl_insert&lt;/strong&gt;: Technical: when a new group access to a file/directory is create.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_main_users_insert&lt;/strong&gt;: Logged when the main kDrive team access to a file/directory is created.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_main_users_remove&lt;/strong&gt;: Logged when the main kDrive team to a file/directory is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_main_users_update&lt;/strong&gt;: Logged when the main kDrive team to a file/directory is modified.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_remove&lt;/strong&gt;: Technical: when a group access to a file/directory is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_team_insert&lt;/strong&gt;: Logged when a team access to a file/directory is created.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_team_remove&lt;/strong&gt;: Logged when a team access to a file/directory is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_team_update&lt;/strong&gt;: Logged when a team access to a file/directory is modified.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_update&lt;/strong&gt;: Technical: when a group access to a file/directory is modified.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_user_insert&lt;/strong&gt;: Logged when an user/admin access to a file/directory is created.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_user_remove&lt;/strong&gt;: Logged when an user/admin access to a file/directory is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;acl_user_update&lt;/strong&gt;: Logged when an user/admin access to a file/directory is modified.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;category_create&lt;/strong&gt;: Logged when a new category is added.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;category_delete&lt;/strong&gt;: Logged when a category is deleted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;category_update&lt;/strong&gt;: Logged when a category is renamed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_folder_access&lt;/strong&gt;: Logged when an user/guest access to the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_folder_create&lt;/strong&gt;: Logged when an user create a dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_folder_delete&lt;/strong&gt;: Logged when an user delete the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_folder_update&lt;/strong&gt;: Logged when an user update settings of the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_user_access&lt;/strong&gt;: Logged when an user/guest upload to the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_user_create&lt;/strong&gt;: Logged when an user/guest add his information before uploading to the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;collaborative_user_delete&lt;/strong&gt;: Logged when an user remove the directory to the dropbox.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_create&lt;/strong&gt;: Logged when an user/admin add a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_delete&lt;/strong&gt;: Logged when an user/admin delete a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_like&lt;/strong&gt;: Logged when an user/admin like a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_resolve&lt;/strong&gt;: Logged when an user/admin resolve a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_unlike&lt;/strong&gt;: Logged when an user/admin unlike a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;comment_update&lt;/strong&gt;: Logged when an user/admin update a comment on a file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;exchange_pro_create&lt;/strong&gt;: Technical: no used.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_access&lt;/strong&gt;: Logged when an user/guest access to the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_categorize&lt;/strong&gt;: Logged when a category is added to the file/directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_color_delete&lt;/strong&gt;: Logged when a directory color is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_color_update&lt;/strong&gt;: Logged when a directory color changed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_create&lt;/strong&gt;: Logged when on the first file creation.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_delete&lt;/strong&gt;: Logged when the file is deleted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_favorite_create&lt;/strong&gt;: Logged when a file/directory is flagged as favorites.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_favorite_remove&lt;/strong&gt;: Logged when a file/directory is unflagged from favorites.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_ia_categorize&lt;/strong&gt;: Logged when a file is categorized by the ia.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_move&lt;/strong&gt;: Logged when the file is added inside a directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_move_out&lt;/strong&gt;: Logged when the file is removed from a directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_rename&lt;/strong&gt;: Logged when the file is renamed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_rename_alias&lt;/strong&gt;: Logged when a root file is renamed by an external user (only visible for the external user).&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_restore&lt;/strong&gt;: Logged when the file is restored from the trash.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_share_create&lt;/strong&gt;: Logged when an external user access to a file/directory is created.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_share_delete&lt;/strong&gt;: Logged when an external user access to a file/directory is removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_share_update&lt;/strong&gt;: Logged when an external user access to a file/directory is modified to another permission.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_trash&lt;/strong&gt;: Logged when the file is sent to trash.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_uncategorize&lt;/strong&gt;: Logged when a category is removed to the file/directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_update&lt;/strong&gt;: Logged when the file is updated.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_update_mime_type&lt;/strong&gt;: Logged when a file mime_type is updated.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;rewind_ended&lt;/strong&gt;: Logged when the user ended a rewind.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;rewind_started&lt;/strong&gt;: Logged when the user started a rewind.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;share_link_create&lt;/strong&gt;: Logged when a public share link to a file/directory is created.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;share_link_delete&lt;/strong&gt;: Logged when a public share link to a file/directory is deleted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;share_link_show&lt;/strong&gt;: Logged when a public share link to a file/directory is seen by someone else.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;share_link_update&lt;/strong&gt;: Logged when a public share link to a file/directory is modified.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trash_empty&lt;/strong&gt;: Logged when the user empties the trash.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;update_trash_settings&lt;/strong&gt;: Logged when the user changes trash the settings.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user_connected&lt;/strong&gt;: Logged when an user is connected to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user_create&lt;/strong&gt;: Logged when an user/admin is added to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user_delete&lt;/strong&gt;: Logged when an user/admin has been removed of the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user_restore&lt;/strong&gt;: Logged when an user/admin has been restored of the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user_update&lt;/strong&gt;: Logged when an user/admin information has changed.&lt;/note&gt;
    /// </summary>
    public enum Anonymous5
    {
        [System.Runtime.Serialization.EnumMember(Value = @"acl_insert")]
        Acl_insert = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_main_users_insert")]
        Acl_main_users_insert = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_main_users_remove")]
        Acl_main_users_remove = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_main_users_update")]
        Acl_main_users_update = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_remove")]
        Acl_remove = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_team_insert")]
        Acl_team_insert = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_team_remove")]
        Acl_team_remove = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_team_update")]
        Acl_team_update = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_update")]
        Acl_update = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_user_insert")]
        Acl_user_insert = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_user_remove")]
        Acl_user_remove = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"acl_user_update")]
        Acl_user_update = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"category_create")]
        Category_create = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"category_delete")]
        Category_delete = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"category_update")]
        Category_update = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_access")]
        Collaborative_folder_access = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_create")]
        Collaborative_folder_create = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_delete")]
        Collaborative_folder_delete = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_folder_update")]
        Collaborative_folder_update = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_user_access")]
        Collaborative_user_access = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_user_create")]
        Collaborative_user_create = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"collaborative_user_delete")]
        Collaborative_user_delete = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_create")]
        Comment_create = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_delete")]
        Comment_delete = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_like")]
        Comment_like = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_resolve")]
        Comment_resolve = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_unlike")]
        Comment_unlike = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"comment_update")]
        Comment_update = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"exchange_pro_create")]
        Exchange_pro_create = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"file_access")]
        File_access = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"file_categorize")]
        File_categorize = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"file_color_delete")]
        File_color_delete = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"file_color_update")]
        File_color_update = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"file_create")]
        File_create = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"file_delete")]
        File_delete = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"file_favorite_create")]
        File_favorite_create = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"file_favorite_remove")]
        File_favorite_remove = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"file_ia_categorize")]
        File_ia_categorize = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"file_move")]
        File_move = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"file_move_out")]
        File_move_out = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"file_rename")]
        File_rename = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"file_rename_alias")]
        File_rename_alias = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"file_restore")]
        File_restore = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"file_restore_inherited")]
        File_restore_inherited = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"file_share_create")]
        File_share_create = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"file_share_delete")]
        File_share_delete = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"file_share_update")]
        File_share_update = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"file_trash")]
        File_trash = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"file_trash_inherited")]
        File_trash_inherited = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"file_uncategorize")]
        File_uncategorize = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"file_update")]
        File_update = 50,

        [System.Runtime.Serialization.EnumMember(Value = @"file_update_mime_type")]
        File_update_mime_type = 51,

        [System.Runtime.Serialization.EnumMember(Value = @"rewind_ended")]
        Rewind_ended = 52,

        [System.Runtime.Serialization.EnumMember(Value = @"rewind_started")]
        Rewind_started = 53,

        [System.Runtime.Serialization.EnumMember(Value = @"share_link_create")]
        Share_link_create = 54,

        [System.Runtime.Serialization.EnumMember(Value = @"share_link_delete")]
        Share_link_delete = 55,

        [System.Runtime.Serialization.EnumMember(Value = @"share_link_show")]
        Share_link_show = 56,

        [System.Runtime.Serialization.EnumMember(Value = @"share_link_update")]
        Share_link_update = 57,

        [System.Runtime.Serialization.EnumMember(Value = @"trash_empty")]
        Trash_empty = 58,

        [System.Runtime.Serialization.EnumMember(Value = @"update_trash_settings")]
        Update_trash_settings = 59,

        [System.Runtime.Serialization.EnumMember(Value = @"user_connected")]
        User_connected = 60,

        [System.Runtime.Serialization.EnumMember(Value = @"user_create")]
        User_create = 61,

        [System.Runtime.Serialization.EnumMember(Value = @"user_delete")]
        User_delete = 62,

        [System.Runtime.Serialization.EnumMember(Value = @"user_restore")]
        User_restore = 63,

        [System.Runtime.Serialization.EnumMember(Value = @"user_update")]
        User_update = 64,
    }
}