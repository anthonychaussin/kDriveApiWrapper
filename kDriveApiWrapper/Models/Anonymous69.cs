namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file type structure either a File, a Directory or a Vault
    /// </summary>

    public enum Anonymous69
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dir")]
        Dir = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"file")]
        File = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"vault")]
        Vault = 2,
    }
}