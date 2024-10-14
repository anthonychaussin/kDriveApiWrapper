namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Rights required to view the share link.&lt;note&gt;&lt;strong&gt;inherit&lt;/strong&gt;: Share link is accessible only by users of the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;password&lt;/strong&gt;: Share link is public but protected by a password.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;public&lt;/strong&gt;: Share link is public, no restriction set.&lt;/note&gt;
    /// </summary>

    public enum ShareLinkRightType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"inherit")]
        Inherit = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"password")]
        Password = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"public")]
        Public = 2,
    }
}