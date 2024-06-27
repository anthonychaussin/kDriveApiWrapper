namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api_ player related_type.
    /// </summary>
    public enum Api_PlayerRelated_type
    {
        [System.Runtime.Serialization.EnumMember(Value = @"SIMILAR_TAGS")]
        SIMILAR_TAGS = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"LAST_UPLOADED")]
        LAST_UPLOADED = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"SAME_FOLDER")]
        SAME_FOLDER = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MOST_VIEWED")]
        MOST_VIEWED = 3,
    }
}