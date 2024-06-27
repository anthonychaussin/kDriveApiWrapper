namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// To search files recursively (use &lt;strong&gt;unlimited&lt;/strong&gt;) or to search files in the first directory (use &lt;strong&gt;child&lt;/strong&gt;)
    /// </summary>

    public enum Anonymous44
    {
        [System.Runtime.Serialization.EnumMember(Value = @"child")]
        Child = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"unlimited")]
        Unlimited = 1,
    }
}