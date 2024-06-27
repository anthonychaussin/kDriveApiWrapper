namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// User
    /// </summary>

    public partial class Api_User
    {
        /// <summary>
        /// Gets or sets the i global user code.
        /// </summary>
        [JsonPropertyName("iGlobalUserCode")]
        public string IGlobalUserCode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s login.
        /// </summary>
        [JsonPropertyName("sLogin")]
        public string SLogin { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s email.
        /// </summary>
        [JsonPropertyName("sEmail")]
        public string SEmail { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s firstname.
        /// </summary>
        [JsonPropertyName("sFirstname")]
        public string SFirstname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s lastname.
        /// </summary>
        [JsonPropertyName("sLastname")]
        public string SLastname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s password.
        /// </summary>
        [JsonPropertyName("sPassword")]
        public string SPassword { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s crypt key.
        /// </summary>
        [JsonPropertyName("sCryptKey")]
        public string SCryptKey { get; set; } = default!;

        /// <summary>
        /// Gets or sets the i status.
        /// </summary>
        [JsonPropertyName("iStatus")]
        public string IStatus { get; set; } = default!;

        /// <summary>
        /// Date à laquelle le compte utilisateur a été validé (par lui même suite à invitation par exemple)
        /// </summary>

        [JsonPropertyName("dValidationDate")]
        public string DValidationDate { get; set; } = default!;

        /// <summary>
        /// Flag pour indiquer si staff Infomaniak
        /// </summary>

        [JsonPropertyName("bInfomaniak")]
        public double BInfomaniak { get; set; } = default!;

        /// <summary>
        /// Gets or sets the set staff departement.
        /// </summary>
        [JsonPropertyName("setStaffDepartement")]
        public string SetStaffDepartement { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d deleted.
        /// </summary>
        [JsonPropertyName("dDeleted")]
        public string DDeleted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s o t p auth secret.
        /// </summary>
        [JsonPropertyName("sOTPAuthSecret")]
        public string SOTPAuthSecret { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s hash password.
        /// </summary>
        [JsonPropertyName("sHashPassword")]
        public string SHashPassword { get; set; } = default!;

        /// <summary>
        /// Gets or sets the set deleted action.
        /// </summary>
        [JsonPropertyName("setDeletedAction")]
        public string SetDeletedAction { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b o t p auth.
        /// </summary>
        [JsonPropertyName("bOTPAuth")]
        public string BOTPAuth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d last login.
        /// </summary>
        [JsonPropertyName("dLastLogin")]
        public string DLastLogin { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d last login admin.
        /// </summary>
        [JsonPropertyName("dLastLoginAdmin")]
        public string DLastLoginAdmin { get; set; } = default!;

        /// <summary>
        /// Gets or sets the set created action.
        /// </summary>
        [JsonPropertyName("setCreatedAction")]
        public string SetCreatedAction { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b invalid email.
        /// </summary>
        [JsonPropertyName("bInvalidEmail")]
        public string BInvalidEmail { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s o t p auth pending secret.
        /// </summary>
        [JsonPropertyName("sOTPAuthPendingSecret")]
        public string SOTPAuthPendingSecret { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s avatar url.
        /// </summary>
        [JsonPropertyName("sAvatarUrl")]
        public string SAvatarUrl { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d creation.
        /// </summary>
        [JsonPropertyName("dCreation")]
        public string DCreation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d security assistant.
        /// </summary>
        [JsonPropertyName("dSecurityAssistant")]
        public string DSecurityAssistant { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b s m s auth.
        /// </summary>
        [JsonPropertyName("bSMSAuth")]
        public string BSMSAuth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s s m s phone.
        /// </summary>
        [JsonPropertyName("sSMSPhone")]
        public string SSMSPhone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d reset password.
        /// </summary>
        [JsonPropertyName("dResetPassword")]
        public string DResetPassword { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b yubikey auth.
        /// </summary>
        [JsonPropertyName("bYubikeyAuth")]
        public string BYubikeyAuth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s yubikey id.
        /// </summary>
        [JsonPropertyName("sYubikeyId")]
        public string SYubikeyId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b double auth.
        /// </summary>
        [JsonPropertyName("bDoubleAuth")]
        public string BDoubleAuth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s double auth method.
        /// </summary>
        [JsonPropertyName("sDoubleAuthMethod")]
        public string SDoubleAuthMethod { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b application auth.
        /// </summary>
        [JsonPropertyName("bApplicationAuth")]
        public string BApplicationAuth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s password status.
        /// </summary>
        [JsonPropertyName("sPasswordStatus")]
        public string SPasswordStatus { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d date password status changed.
        /// </summary>
        [JsonPropertyName("dDatePasswordStatusChanged")]
        public string DDatePasswordStatusChanged { get; set; } = default!;

        /// <summary>
        /// Gets or sets the access grants.
        /// </summary>
        [JsonPropertyName("accessGrants")]
        public ICollection<object> AccessGrants { get; set; } = default!;

        /// <summary>
        /// Gets or sets the access tokens.
        /// </summary>
        [JsonPropertyName("accessTokens")]
        public ICollection<object> AccessTokens { get; set; } = default!;

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        [JsonPropertyName("accounts")]
        public ICollection<Api_Account> Accounts { get; set; } = default!;

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public ICollection<Address> Addresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the answer.
        /// </summary>
        [JsonPropertyName("answer")]
        public object Answer { get; set; } = default!;

        /// <summary>
        /// Gets or sets the applications.
        /// </summary>
        [JsonPropertyName("applications")]
        public ICollection<object> Applications { get; set; } = default!;

        /// <summary>
        /// Gets or sets the auth devices.
        /// </summary>
        [JsonPropertyName("authDevices")]
        public ICollection<object> AuthDevices { get; set; } = default!;

        /// <summary>
        /// Gets or sets the contact addresses.
        /// </summary>
        [JsonPropertyName("contactAddresses")]
        public ICollection<Address> ContactAddresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        public ICollection<object> Emails { get; set; } = default!;

        /// <summary>
        /// Gets or sets the admin_last_used_at.
        /// </summary>
        [JsonPropertyName("admin_last_used_at")]
        public string Admin_last_used_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the avatar_url.
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string Avatar_url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b_invalid_email.
        /// </summary>
        [JsonPropertyName("b_invalid_email")]
        public string B_invalid_email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_action.
        /// </summary>
        [JsonPropertyName("created_action")]
        public string Created_action { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the current_account.
        /// </summary>
        [JsonPropertyName("current_account")]
        public Api_Account Current_account { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d_security_assistant.
        /// </summary>
        [JsonPropertyName("d_security_assistant")]
        public string D_security_assistant { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_by_id.
        /// </summary>
        [JsonPropertyName("deleted_by_id")]
        public double Deleted_by_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_by_ip.
        /// </summary>
        [JsonPropertyName("deleted_by_ip")]
        public ICollection<string> Deleted_by_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string Firstname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the invalid_email.
        /// </summary>
        [JsonPropertyName("invalid_email")]
        public string Invalid_email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_used_at.
        /// </summary>
        [JsonPropertyName("last_used_at")]
        public string Last_used_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string Lastname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        [JsonPropertyName("login")]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether otp_enabled.
        /// </summary>
        [JsonPropertyName("otp_enabled")]
        public bool Otp_enabled { get; set; } = default!;

        /// <summary>
        /// Gets or sets the otpauth_secret.
        /// </summary>
        [JsonPropertyName("otpauth_secret")]
        public string Otpauth_secret { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether remember_token.
        /// </summary>
        [JsonPropertyName("remember_token")]
        public bool Remember_token { get; set; } = default!;

        /// <summary>
        /// Gets or sets the staff.
        /// </summary>
        [JsonPropertyName("staff")]
        public string Staff { get; set; } = default!;

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Gets or sets the validated_at.
        /// </summary>
        [JsonPropertyName("validated_at")]
        public string Validated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mailboxes.
        /// </summary>
        [JsonPropertyName("mailboxes")]
        public ICollection<object> Mailboxes { get; set; } = default!;

        /// <summary>
        /// Gets or sets the old passwords.
        /// </summary>
        [JsonPropertyName("oldPasswords")]
        public ICollection<object> OldPasswords { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phones.
        /// </summary>
        [JsonPropertyName("phones")]
        public ICollection<object> Phones { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preference.
        /// </summary>
        [JsonPropertyName("preference")]
        public object Preference { get; set; } = default!;

        /// <summary>
        /// Gets or sets the remember tokens.
        /// </summary>
        [JsonPropertyName("rememberTokens")]
        public ICollection<object> RememberTokens { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rescue codes.
        /// </summary>
        [JsonPropertyName("rescueCodes")]
        public ICollection<object> RescueCodes { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        public ICollection<object> Rights { get; set; } = default!;

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        [JsonPropertyName("roles")]
        public ICollection<object> Roles { get; set; } = default!;

        /// <summary>
        /// Gets or sets the service rights.
        /// </summary>
        [JsonPropertyName("serviceRights")]
        public ICollection<object> ServiceRights { get; set; } = default!;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [JsonPropertyName("password")]
        public object Password { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s_email.
        /// </summary>
        [JsonPropertyName("s_email")]
        public object S_email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s_remember_token.
        /// </summary>
        [JsonPropertyName("s_remember_token")]
        public object S_remember_token { get; set; } = default!;

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        [JsonPropertyName("teams")]
        public ICollection<object> Teams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user passwords.
        /// </summary>
        [JsonPropertyName("userPasswords")]
        public ICollection<object> UserPasswords { get; set; } = default!;

        /// <summary>
        /// Gets or sets the validate email tokens.
        /// </summary>
        [JsonPropertyName("validateEmailTokens")]
        public ICollection<object> ValidateEmailTokens { get; set; } = default!;
    }
}