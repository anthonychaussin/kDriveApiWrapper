namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file type.
    /// </summary>
    public enum FileTypeEnum
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,
        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,
        [System.Runtime.Serialization.EnumMember(Value = @"vault")]
        Vault = 2,
    }
}