namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The shared generic file visibility.
    /// </summary>
    public enum SharedGenericFileVisibility
    {
        [System.Runtime.Serialization.EnumMember(Value = @"")]
        Empty = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"is_in_private_space")]
        Is_in_private_space = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"is_in_shared_space")]
        Is_in_shared_space = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"is_in_team_space_folder")]
        Is_in_team_space_folder = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"is_private_space")]
        Is_private_space = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"is_root")]
        Is_root = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"is_shared_space")]
        Is_shared_space = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"is_team_space")]
        Is_team_space = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"is_team_space_folder")]
        Is_team_space_folder = 8,
    }
}