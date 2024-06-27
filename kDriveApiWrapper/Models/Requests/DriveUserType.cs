namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body10 type.
    /// </summary>
    public enum DriveUserType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"main")]
        Main = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"shared")]
        Shared = 1,
    }
}