namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive.
    /// </summary>
    public partial class Drive : Data
    {
        /// <summary>
        /// Id of the kDrive
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the kDrive
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Maximum space (in bytes)
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Used space (in bytes)
        /// </summary>

        [JsonPropertyName("used_size")]
        public int Used_size { get; set; } = default!;

        /// <summary>
        /// Creation timestamp
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// Last update timestamp
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;

        /// <summary>
        /// When maintenance is activated
        /// </summary>

        [JsonPropertyName("in_maintenance")]
        public bool In_maintenance { get; set; } = default!;

        /// <summary>
        /// Reason of Drive maintenance.&lt;note&gt;&lt;strong&gt;demo_end&lt;/strong&gt;: The demonstration period of the Drive has come to an end.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;invoice_overdue&lt;/strong&gt;: An invoice for this Drive is currently unpaid.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;not_renew&lt;/strong&gt;: This Drive has expired and must be renewed.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("maintenance_reason")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveMaintenance_reason Maintenance_reason { get; set; } = default!;

        /// <summary>
        /// When maintenance was activated at
        /// </summary>

        [JsonPropertyName("maintenance_at")]
        public int? Maintenance_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the maintenance_types.
        /// </summary>
        [JsonPropertyName("maintenance_types")]
        public ICollection<MaintenanceType> Maintenance_types { get; set; } = default!;

        /// <summary>
        /// Backend version
        /// </summary>

        [JsonPropertyName("version")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Number of user slots used
        /// </summary>

        [JsonPropertyName("users_count")]
        public int Users_count { get; set; } = default!;

        /// <summary>
        /// Maximum number of users for this kdrive
        /// </summary>

        [JsonPropertyName("users_quota")]
        public int Users_quota { get; set; } = default!;

        /// <summary>
        /// Unique id of the kDrive product
        /// </summary>

        [JsonPropertyName("product_id")]
        public int Product_id { get; set; } = default!;

        /// <summary>
        /// Id of the account in which the kDrive is
        /// </summary>

        [JsonPropertyName("account_id")]
        public int Account_id { get; set; } = default!;

        /// <summary>
        /// Account the Drive belongs to.
        /// </summary>

        [JsonPropertyName("account")]
        public string Account { get; set; } = default!;

        /// <summary>
        /// Product expiration timestamp
        /// </summary>

        [JsonPropertyName("expired_at")]
        public int? Expired_at { get; set; } = default!;

        /// <summary>
        /// If the product is locked
        /// </summary>

        [JsonPropertyName("is_locked")]
        public bool Is_locked { get; set; } = default!;

        /// <summary>
        /// Custom description of this kDrive
        /// </summary>

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Reference used for billing
        /// </summary>

        [JsonPropertyName("bill_reference")]
        public string Bill_reference { get; set; } = default!;

        /// <summary>
        /// If the product is in free trial period
        /// </summary>

        [JsonPropertyName("is_demo")]
        public bool Is_demo { get; set; } = default!;

        /// <summary>
        /// Role of the current user within this kDrive
        /// </summary>

        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveRole Role { get; set; } = default!;

        /// <summary>
        /// Can be managed as admin
        /// </summary>

        [JsonPropertyName("account_admin")]
        public bool Account_admin { get; set; } = default!;

        /// <summary>
        /// Whether this drive has been purchased within an app store
        /// </summary>

        [JsonPropertyName("is_in_app_subscription")]
        public bool Is_in_app_subscription { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rewind.
        /// </summary>
        [JsonPropertyName("rewind")]
        public Rewind Rewind { get; set; } = default!;

        /// <summary>
        /// Number of pending invitation.
        /// </summary>

        [JsonPropertyName("invitations_count")]
        public int Invitations_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public ICollection<Category> Categories { get; set; } = default!;

        /// <summary>
        /// Gets or sets the categories_permissions.
        /// </summary>
        [JsonPropertyName("categories_permissions")]
        public Categorypermission Categories_permissions { get; set; } = default!;

        /// <summary>
        /// All users identifiers by types
        /// </summary>

        [JsonPropertyName("users")]
        public Users Users { get; set; } = default!;

        /// <summary>
        /// All teams identifiers by types
        /// </summary>

        [JsonPropertyName("teams")]
        public Teams Teams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        public Right Rights { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<Tag> Tags { get; set; } = default!;

        /// <summary>
        /// The kSuite in which the kDrive is
        /// </summary>

        [JsonPropertyName("k_suite")]
        public K_suite K_suite { get; set; } = default!;

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        [JsonPropertyName("capabilities")]
        public Capabilities Capabilities { get; set; } = default!;

        /// <summary>
        /// Settings of the current users for this kDrive
        /// </summary>

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preferences.
        /// </summary>
        [JsonPropertyName("preferences")]
        public Preferences Preferences { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pack.
        /// </summary>
        [JsonPropertyName("pack")]
        [System.ComponentModel.DataAnnotations.Required]
        public PricingPlan Pack { get; set; } = new PricingPlan();
    }
}