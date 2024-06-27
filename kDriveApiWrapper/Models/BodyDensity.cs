namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body density.
    /// </summary>
    public enum BodyDensity
    {
        [System.Runtime.Serialization.EnumMember(Value = @"compact")]
        Compact = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"large")]
        Large = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"normal")]
        Normal = 2,
    }
}