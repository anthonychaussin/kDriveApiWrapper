namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The useremail type.
    /// </summary>
    public enum UseremailType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"professional")]
        Professional = 2,
    }
}