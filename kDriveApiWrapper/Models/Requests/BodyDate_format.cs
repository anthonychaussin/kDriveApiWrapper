namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body date_format.
    /// </summary>
    public enum BodyDate_format
    {
        [System.Runtime.Serialization.EnumMember(Value = @"d F Y")]
        D_F_Y = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"d/m/Y")]
        D_m_Y = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"m/d/Y")]
        M_d_Y = 2,
    }
}