namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drivepackprice type.
    /// </summary>
    public enum DrivepackpriceType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"base")]
        Base = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"storage_giga")]
        Storage_giga = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 2,
    }
}