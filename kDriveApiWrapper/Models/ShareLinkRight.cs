namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The share link right.
    /// </summary>
    public enum ShareLinkRight
    {
        [System.Runtime.Serialization.EnumMember(Value = @"inherit")]
        Inherit = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"password")]
        Password = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"public")]
        Public = 2,
    }
}