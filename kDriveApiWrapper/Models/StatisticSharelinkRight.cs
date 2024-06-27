namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The statistic sharelink right.
    /// </summary>
    public enum StatisticSharelinkRight
    {
        [System.Runtime.Serialization.EnumMember(Value = @"inherit")]
        Inherit = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"password")]
        Password = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"public")]
        Public = 2,
    }
}