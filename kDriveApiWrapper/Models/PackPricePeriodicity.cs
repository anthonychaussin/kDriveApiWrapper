namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pack price periodicity.
    /// </summary>
    public enum PackPricePeriodicity
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MONTH")]
        MONTH = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"YEAR")]
        YEAR = 1,
    }
}