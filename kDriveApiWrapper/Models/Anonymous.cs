namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Administration level of the user.&lt;note&gt;&lt;strong&gt;admin&lt;/strong&gt;: Administrator of the drive, can manage the drive (settings, invitations and users) and the files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;external&lt;/strong&gt;: External user can only access the files given by the others roles.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user&lt;/strong&gt;: Internal user can invite user and manage the files of his private directory and other directories with manage file access.&lt;/note&gt;
    /// </summary>

    public enum Anonymous
    {
        [System.Runtime.Serialization.EnumMember(Value = @"admin")]
        Admin = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"external")]
        External = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}