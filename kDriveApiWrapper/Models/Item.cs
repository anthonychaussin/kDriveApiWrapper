namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Reason of {name} maintenance.&lt;note&gt;&lt;strong&gt;demo_end&lt;/strong&gt;: The demonstration period of the {name} has come to an end.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;invoice_overdue&lt;/strong&gt;: An invoice for this {name} is currently unpaid.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;not_renew&lt;/strong&gt;: This {name} has expired and must be renewed.&lt;/note&gt;
    /// </summary>

    public enum Item
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