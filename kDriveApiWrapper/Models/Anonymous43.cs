namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Specifies the sorting direction for a specific order_by, it should be used with the `order_by` key like `order_for[last_modified_at]=asc`
    /// </summary>

    public enum Anonymous43
    {
        [System.Runtime.Serialization.EnumMember(Value = @"asc")]
        Asc = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"desc")]
        Desc = 1,
    }
}