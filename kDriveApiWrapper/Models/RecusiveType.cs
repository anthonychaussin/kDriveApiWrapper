namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// To search files recursively (use unlimited) or to search files in the first directory (use child)
    /// </summary>

    public enum RecusiveType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"child")]
        Child = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"unlimited")]
        Unlimited = 1,
    }
}