namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file category user_validation.
    /// </summary>
    public enum FileCategoryUser_validation
    {
        [System.Runtime.Serialization.EnumMember(Value = @"CORRECT")]
        CORRECT = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"INCORRECT")]
        INCORRECT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TO_VALIDATE")]
        TO_VALIDATE = 2,
    }
}