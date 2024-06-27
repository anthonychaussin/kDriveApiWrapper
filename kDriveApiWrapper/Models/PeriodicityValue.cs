namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The periodicity value.
    /// </summary>
    public enum PeriodicityValue
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MONTH")]
        MONTH = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"YEAR")]
        YEAR = 1,
    }
}