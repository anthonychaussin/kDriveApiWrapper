namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The shared generic file type.
    /// </summary>
    public enum SharedGenericFileType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,
    }
}