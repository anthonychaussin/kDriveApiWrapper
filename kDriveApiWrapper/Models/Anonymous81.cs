namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The `order_by` parameter accepts values corresponding to the items attributes, allowing you to specify the field by which the list should be sorted
    /// </summary>

    public enum Anonymous81
    {
        [System.Runtime.Serialization.EnumMember(Value = @"added_at")]
        Added_at = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"deleted_at")]
        Deleted_at = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"last_modified_at")]
        Last_modified_at = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"mime_type")]
        Mime_type = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"name")]
        Name = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"revised_at")]
        Revised_at = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"size")]
        Size = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"type")]
        Type = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"updated_at")]
        Updated_at = 8,
    }
}