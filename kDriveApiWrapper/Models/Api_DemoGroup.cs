namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// DemoGroup
    /// </summary>

    public partial class Api_DemoGroup
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public double Id { get; set; } = default!;

        /// <summary>
        /// Liaison avec la conf de la démo
        /// </summary>

        [JsonPropertyName("iDemo")]
        public double IDemo { get; set; } = default!;

        /// <summary>
        /// Gets or sets the i groupe.
        /// </summary>
        [JsonPropertyName("iGroupe")]
        public string IGroupe { get; set; } = default!;

        /// <summary>
        /// Gets or sets the i service.
        /// </summary>
        [JsonPropertyName("iService")]
        public string IService { get; set; } = default!;

        /// <summary>
        /// Gets or sets the i item.
        /// </summary>
        [JsonPropertyName("iItem")]
        public string IItem { get; set; } = default!;

        /// <summary>
        /// Gets or sets the i sub item.
        /// </summary>
        [JsonPropertyName("iSubItem")]
        public string ISubItem { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b desactived.
        /// </summary>
        [JsonPropertyName("bDesactived")]
        public string BDesactived { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b ignore use.
        /// </summary>
        [JsonPropertyName("bIgnoreUse")]
        public string BIgnoreUse { get; set; } = default!;

        /// <summary>
        /// Date de création de la démo
        /// </summary>

        [JsonPropertyName("dCreated")]
        public string DCreated { get; set; } = default!;

        /// <summary>
        /// Date de butée de validité. A cette date on désactive l'item puis X jours après on le résilie
        /// </summary>

        [JsonPropertyName("dValidite")]
        public string DValidite { get; set; } = default!;

        /// <summary>
        /// Date ou la désactivation d'une démo est intervenue.
        /// </summary>

        [JsonPropertyName("dResilied")]
        public string DResilied { get; set; } = default!;

        /// <summary>
        /// Date ou la limitation d'une démo est intervenue.
        /// </summary>

        [JsonPropertyName("dLimited")]
        public string DLimited { get; set; } = default!;

        /// <summary>
        /// Date ou la démo a été convertie en produit classique.
        /// </summary>

        [JsonPropertyName("dConverted")]
        public string DConverted { get; set; } = default!;

        /// <summary>
        /// Liste de flag pour les mails déjà envoyé
        /// </summary>

        [JsonPropertyName("iMailSent")]
        public double IMailSent { get; set; } = default!;

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        [JsonPropertyName("account")]
        public ICollection<Api_Account> Account { get; set; } = default!;
    }
}