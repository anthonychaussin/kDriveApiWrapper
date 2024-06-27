namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The metric.
    /// </summary>
    public enum Metric
    {
        [System.Runtime.Serialization.EnumMember(Value = @"devices")]
        Devices = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"shared_files")]
        Shared_files = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"users")]
        Users = 2,
    }
}