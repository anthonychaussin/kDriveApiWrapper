namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Whether the `Dropbox` has password protection
    /// </summary>

    public enum Has_password
    {
        [System.Runtime.Serialization.EnumMember(Value = @"any")]
        Any = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"no")]
        No = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"yes")]
        Yes = 2,
    }
}