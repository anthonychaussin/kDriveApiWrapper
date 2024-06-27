namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The order.
    /// </summary>
    public enum Order
    {
        [System.Runtime.Serialization.EnumMember(Value = @"asc")]
        Asc = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"desc")]
        Desc = 1,
    }
}