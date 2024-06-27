namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The directory type.
    /// </summary>
    public enum DirectoryType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,
    }
}