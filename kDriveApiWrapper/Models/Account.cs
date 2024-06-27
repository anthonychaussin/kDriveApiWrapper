namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The account.
    /// </summary>
    public partial class Account : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Account`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Account`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the legal_entity_type.
        /// </summary>
        [JsonPropertyName("legal_entity_type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AccountLegal_entity_type Legal_entity_type { get; set; } = default!;

        /// <summary>
        /// Timestamp `Account` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public ICollection<Accountaddress> Addresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Represents a language identifier and a region identifier
        /// </summary>

        [JsonPropertyName("locale")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `language` that is related to the resource `Account`
        /// </summary>

        [JsonPropertyName("language_id")]
        public int Language_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        [JsonPropertyName("order")]
        public Order2 Order { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether beta.
        /// </summary>
        [JsonPropertyName("beta")]
        public bool Beta { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether billing.
        /// </summary>
        [JsonPropertyName("billing")]
        public bool Billing { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether mailing.
        /// </summary>
        [JsonPropertyName("mailing")]
        public bool Mailing { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether billing_mailing.
        /// </summary>
        [JsonPropertyName("billing_mailing")]
        public bool Billing_mailing { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether workspace_only.
        /// </summary>
        [JsonPropertyName("workspace_only")]
        public bool Workspace_only { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether no_access.
        /// </summary>
        [JsonPropertyName("no_access")]
        public bool No_access { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_blocked.
        /// </summary>
        [JsonPropertyName("is_blocked")]
        public bool Is_blocked { get; set; } = default!;

        /// <summary>
        /// Gets or sets the blocked_at.
        /// </summary>
        [JsonPropertyName("blocked_at")]
        public int Blocked_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the vat_number.
        /// </summary>
        [JsonPropertyName("vat_number")]
        public string Vat_number { get; set; } = default!;

        /// <summary>
        /// Gets or sets the field1.
        /// </summary>
        [JsonPropertyName("field1")]
        public string Field1 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the field2.
        /// </summary>
        [JsonPropertyName("field2")]
        public string Field2 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<Tag> Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the services_already_demo.
        /// </summary>
        [JsonPropertyName("services_already_demo")]
        public ICollection<object> Services_already_demo { get; set; } = default!;

        /// <summary>
        /// Gets or sets the customization_url.
        /// </summary>
        [JsonPropertyName("customization_url")]
        public object Customization_url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the nb_invitations.
        /// </summary>
        [JsonPropertyName("nb_invitations")]
        public int Nb_invitations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the nb_users.
        /// </summary>
        [JsonPropertyName("nb_users")]
        public int Nb_users { get; set; } = default!;
    }
}