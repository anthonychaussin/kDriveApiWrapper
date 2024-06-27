namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body18 application.
    /// </summary>
    public enum Body18Application
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dropbox")]
        Dropbox = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"google_drive")]
        Google_drive = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"onedrive")]
        Onedrive = 2,
    }
}