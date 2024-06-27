namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The logical server type.
    /// </summary>
    public enum LogicalServerType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"DMU")]
        DMU = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"IMU")]
        IMU = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NAS")]
        NAS = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"NMU")]
        NMU = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"NTU")]
        NTU = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OS")]
        OS = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"VMU")]
        VMU = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"VNU")]
        VNU = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"XEN")]
        XEN = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"XENMU")]
        XENMU = 9,
    }
}