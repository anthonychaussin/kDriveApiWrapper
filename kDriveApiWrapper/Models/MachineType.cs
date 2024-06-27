namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The machine type.
    /// </summary>
    public enum MachineType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"edge")]
        Edge = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"load-balancer")]
        LoadBalancer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"master")]
        Master = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"classer")]
        classer = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"time-shifter")]
        TimeShifter = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"transcoder")]
        Transcoder = 5,
    }
}