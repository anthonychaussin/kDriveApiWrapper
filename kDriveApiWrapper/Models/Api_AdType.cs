namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ ad type.
    /// </summary>
    public enum Api_AdType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PRE_ROLL")]
        PRE_ROLL = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"MID_ROLL")]
        MID_ROLL = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PST_ROLL")]
        PST_ROLL = 2,
    }
}