namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The partner.
    /// </summary>
    public partial class Partner : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Partner`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Partner`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        [JsonPropertyName("image")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool Is_active { get; set; } = default!;

        /// <summary>
        /// Gets or sets the budget_min.
        /// </summary>
        [JsonPropertyName("budget_min")]
        public int Budget_min { get; set; } = default!;

        /// <summary>
        /// Gets or sets the budget_max.
        /// </summary>
        [JsonPropertyName("budget_max")]
        public int Budget_max { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_premium.
        /// </summary>
        [JsonPropertyName("is_premium")]
        public bool Is_premium { get; set; } = default!;

        /// <summary>
        /// Timestamp `Partner` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Description of the resource `Partner`
        /// </summary>

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description_en.
        /// </summary>
        [JsonPropertyName("description_en")]
        public string Description_en { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description_de.
        /// </summary>
        [JsonPropertyName("description_de")]
        public string Description_de { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description_it.
        /// </summary>
        [JsonPropertyName("description_it")]
        public string Description_it { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description_es.
        /// </summary>
        [JsonPropertyName("description_es")]
        public string Description_es { get; set; } = default!;

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public ICollection<object> Addresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the skills.
        /// </summary>
        [JsonPropertyName("skills")]
        public ICollection<object> Skills { get; set; } = default!;

        /// <summary>
        /// Gets or sets the skills_by_domain.
        /// </summary>
        [JsonPropertyName("skills_by_domain")]
        public ICollection<object> Skills_by_domain { get; set; } = default!;

        /// <summary>
        /// Gets or sets the skills_by_activity.
        /// </summary>
        [JsonPropertyName("skills_by_activity")]
        public ICollection<object> Skills_by_activity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the references.
        /// </summary>
        [JsonPropertyName("references")]
        public string References { get; set; } = default!;

        /// <summary>
        /// Gets or sets the certifications.
        /// </summary>
        [JsonPropertyName("certifications")]
        public ICollection<object> Certifications { get; set; } = default!;

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        [JsonPropertyName("languages")]
        public ICollection<object> Languages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the available_languages.
        /// </summary>
        [JsonPropertyName("available_languages")]
        public ICollection<object> Available_languages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tenders.
        /// </summary>
        [JsonPropertyName("tenders")]
        public string Tenders { get; set; } = default!;

        /// <summary>
        /// Gets or sets the opinions.
        /// </summary>
        [JsonPropertyName("opinions")]
        public string Opinions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        [JsonPropertyName("messages")]
        public string Messages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; } = default!;

        /// <summary>
        /// Gets or sets the medal.
        /// </summary>
        [JsonPropertyName("medal")]
        public int Medal { get; set; } = default!;

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        [JsonPropertyName("products")]
        public ICollection<object> Products { get; set; } = default!;

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        [JsonPropertyName("invoices")]
        public ICollection<object> Invoices { get; set; } = default!;
    }
}