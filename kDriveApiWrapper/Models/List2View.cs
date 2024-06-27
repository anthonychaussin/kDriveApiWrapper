namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The list2 view.
    /// </summary>
    public enum List2View
    {
        [System.Runtime.Serialization.EnumMember(Value = @"largeGrid")]
        LargeGrid = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"medGrid")]
        MedGrid = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"smallGrid")]
        SmallGrid = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"table")]
        Table = 3,
    }
}