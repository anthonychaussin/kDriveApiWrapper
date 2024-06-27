namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body16 application.
    /// </summary>
    public enum Body16Application
    {
        [System.Runtime.Serialization.EnumMember(Value = @"nextcloud")]
        Nextcloud = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"owncloud")]
        Owncloud = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"webdav")]
        Webdav = 2,
    }
}