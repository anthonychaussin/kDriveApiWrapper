namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Current access status of the user in the drive.&lt;note&gt;&lt;strong&gt;active&lt;/strong&gt;: User has access to the Drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_kept&lt;/strong&gt;: User has been removed but his data remain in the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_removed&lt;/strong&gt;: User has been removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_transferred&lt;/strong&gt;: User has been removed and his data has been transferred to another user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_transferring&lt;/strong&gt;: User has been removed and is being transferred to another user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;locked&lt;/strong&gt;: User has been locked, user can no longer access to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;pending&lt;/strong&gt;: User has not accepted the invitation request.&lt;/note&gt;
    /// </summary>

    public enum Anonymous2
    {
        [System.Runtime.Serialization.EnumMember(Value = @"active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_kept")]
        Deleted_kept = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_removed")]
        Deleted_removed = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_transferred")]
        Deleted_transferred = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_transferring")]
        Deleted_transferring = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"locked")]
        Locked = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 6,
    }
}