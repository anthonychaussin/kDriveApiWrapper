namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Deletion time of the `File`.&lt;note&gt;&lt;strong&gt;custom&lt;/strong&gt;: Custom period from `{attribute}_after` to `{attribute}_before` params.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;last_month&lt;/strong&gt;: Previous month, from the first day at 00:00:00 to the last day at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;last_week&lt;/strong&gt;: Previous week, from Monday at 00:00:00 to Sunday at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;last_year&lt;/strong&gt;: Previous year, from January 1st at 00:00:00 to December 31st at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;this_month&lt;/strong&gt;: Current month, from the first day at 00:00:00 to the last day at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;this_week&lt;/strong&gt;: Current week, from Monday at 00:00:00 to Sunday at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;this_year&lt;/strong&gt;: Current year, from January 1st at 00:00:00 to December 31st at 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;today&lt;/strong&gt;: Current day, from 00:00:00 to 23:59:59.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;yesterday&lt;/strong&gt;: Previous day, from 00:00:00 to 23:59:59.&lt;/note&gt;
    /// </summary>

    public enum Deleted_at
    {
        [System.Runtime.Serialization.EnumMember(Value = @"custom")]
        Custom = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"last_month")]
        Last_month = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"last_week")]
        Last_week = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"last_year")]
        Last_year = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"this_month")]
        This_month = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"this_week")]
        This_week = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"this_year")]
        This_year = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"today")]
        Today = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"yesterday")]
        Yesterday = 8,
    }
}