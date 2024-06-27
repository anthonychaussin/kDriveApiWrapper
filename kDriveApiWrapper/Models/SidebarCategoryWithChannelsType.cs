namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sidebar category with channels type.
    /// </summary>
    public enum SidebarCategoryWithChannelsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"channels")]
        Channels = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"custom")]
        Custom = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"direct_messages")]
        Direct_messages = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"favorites")]
        Favorites = 3,
    }
}