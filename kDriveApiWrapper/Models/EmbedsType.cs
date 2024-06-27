namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The embeds type.
    /// </summary>
    public enum EmbedsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"image")]
        Image = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"message_attachment")]
        Message_attachment = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"opengraph")]
        Opengraph = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"link")]
        Link = 3,
    }
}