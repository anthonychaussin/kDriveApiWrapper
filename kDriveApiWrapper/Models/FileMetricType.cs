namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The anonymous6.
    /// </summary>
    public enum FileMetricType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"files")]
        Files = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"trash")]
        Trash = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"versions")]
        Versions = 2,
    }
}