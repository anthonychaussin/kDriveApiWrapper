namespace kDriveApiWrapper.Models.Account
{
    /// <summary>
    /// The account legal_entity_type.
    /// </summary>
    public enum AccountLegal_entity_type
    {
        [System.Runtime.Serialization.EnumMember(Value = @"company")]
        Company = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"individual")]
        Individual = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"public_body")]
        Public_body = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"restrict")]
        Restrict = 3,
    }
}