namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file type.
    /// </summary>
    public enum FileType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,
    }
}