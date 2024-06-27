namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The `order_by` parameter accepts values corresponding to the items attributes, allowing you to specify the field by which the list should be sorted
    /// </summary>

    public enum SearchFileOrderParam
    {
        [System.Runtime.Serialization.EnumMember(Value = @"last_modified_at")]
        Last_modified_at = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"relevance")]
        Relevance = 1,
    }
}