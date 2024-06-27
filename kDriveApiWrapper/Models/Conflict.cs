namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Select what to do when a file with the same name already exists. The default conflict mode is error.&lt;li&gt;&lt;small&gt;&lt;ul&gt;&lt;strong&gt;error&lt;/strong&gt; : An error is returned without creating the file/session.&lt;/ul&gt;&lt;ul&gt;&lt;strong&gt;rename&lt;/strong&gt; : Rename the new file with an available name (ex. `file.txt` to `file(3).txt`).&lt;/ul&gt;&lt;ul&gt;&lt;strong&gt;version&lt;/strong&gt; : Replace the content of the existing file (create a new version of the file).&lt;/ul&gt;&lt;/small&gt;&lt;/li&gt;
    /// </summary>

    public enum Conflict
    {
        [System.Runtime.Serialization.EnumMember(Value = @"error")]
        Error = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"rename")]
        Rename = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"version")]
        Version = 2,
    }
}