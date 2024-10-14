namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The `order_by` parameter accepts values corresponding to the items attributes, allowing you to specify the field by which the list should be sorted
    /// </summary>

    public enum DriveFieOrder
    {
        [System.Runtime.Serialization.EnumMember(Value = @"added_at")]
        Added_at = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"last_modified_at")]
        Last_modified_at = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"mime_type")]
        Mime_type = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"name")]
        Name = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"revised_at")]
        Revised_at = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"size")]
        Size = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"type")]
        Type = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"updated_at")]
        Updated_at = 7,
    }
}