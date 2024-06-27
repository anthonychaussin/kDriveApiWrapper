namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file's type structure either a File or a Directory
    /// </summary>

    public enum Type
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,
    }
}