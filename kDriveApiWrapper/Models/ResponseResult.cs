namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The response result.
    /// </summary>
    public enum ResponseResult
    {
        [System.Runtime.Serialization.EnumMember(Value = @"success")]
        Success = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"asynchronous")]
        Asynchronous = 2,
    }
}