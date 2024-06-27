namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive maintenance_reason.
    /// </summary>
    public enum DriveMaintenance_reason
    {
        [System.Runtime.Serialization.EnumMember(Value = @"demo_end")]
        Demo_end = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"invoice_overdue")]
        Invoice_overdue = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"not_renew")]
        Not_renew = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"technical")]
        Technical = 3,
    }
}