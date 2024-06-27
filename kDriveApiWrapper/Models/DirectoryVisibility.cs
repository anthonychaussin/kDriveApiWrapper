namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The directory visibility.
    /// </summary>
    public enum DirectoryVisibility
    {
        [System.Runtime.Serialization.EnumMember(Value = @"")]
        Empty = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"is_in_team_space_folder")]
        Is_in_team_space_folder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"is_root")]
        Is_root = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"is_shared_space")]
        Is_shared_space = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"is_team_space")]
        Is_team_space = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"is_team_space_folder")]
        Is_team_space_folder = 5,
    }
}