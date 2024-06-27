namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Wanted app
    /// </summary>

    public enum Application
    {
        [System.Runtime.Serialization.EnumMember(Value = @"google")]
        Google = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"onedrive")]
        Onedrive = 1,
    }
}