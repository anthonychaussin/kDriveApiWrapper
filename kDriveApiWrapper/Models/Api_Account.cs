namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Account
    /// </summary>

    public partial class Api_Account
    {
        /// <summary>
        /// Gets or sets the i code groupes.
        /// </summary>
        [JsonPropertyName("iCodeGroupes")]
        public string ICodeGroupes { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s groupes nom.
        /// </summary>
        [JsonPropertyName("sGroupesNom")]
        public string SGroupesNom { get; set; } = default!;

        /// <summary>
        /// Gets or sets the e type group.
        /// </summary>
        [JsonPropertyName("eTypeGroup")]
        public string ETypeGroup { get; set; } = default!;

        /// <summary>
        /// Numéro de TVA
        /// </summary>

        [JsonPropertyName("sTVA")]
        public string STVA { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s phone.
        /// </summary>
        [JsonPropertyName("sPhone")]
        public string SPhone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s fax.
        /// </summary>
        [JsonPropertyName("sFax")]
        public string SFax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s website.
        /// </summary>
        [JsonPropertyName("sWebsite")]
        public string SWebsite { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b partner.
        /// </summary>
        [JsonPropertyName("bPartner")]
        public string BPartner { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether b contre affaire allowed.
        /// </summary>
        [JsonPropertyName("bContreAffaireAllowed")]
        public bool BContreAffaireAllowed { get; set; } = default!;

        /// <summary>
        /// Exporter les factures et paiements vers GIT
        /// </summary>

        [JsonPropertyName("bExportGIT")]
        public double BExportGIT { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b always on.
        /// </summary>
        [JsonPropertyName("bAlwaysOn")]
        public double BAlwaysOn { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b disable service on unpaid.
        /// </summary>
        [JsonPropertyName("bDisableServiceOnUnpaid")]
        public string BDisableServiceOnUnpaid { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether b use renouvellement.
        /// </summary>
        [JsonPropertyName("bUseRenouvellement")]
        public bool BUseRenouvellement { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether b beta testeur.
        /// </summary>
        [JsonPropertyName("bBetaTesteur")]
        public bool BBetaTesteur { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether b exoneration t v a.
        /// </summary>
        [JsonPropertyName("bExonerationTVA")]
        public bool BExonerationTVA { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether f exoneration t v a limit t t c.
        /// </summary>
        [JsonPropertyName("fExonerationTVALimitTTC")]
        public bool FExonerationTVALimitTTC { get; set; } = default!;

        /// <summary>
        /// Code pays PAR DEFAUT des nouveaux users
        /// </summary>

        [JsonPropertyName("iCountryCode")]
        public double ICountryCode { get; set; } = default!;

        /// <summary>
        /// Code langue par défaut du group
        /// </summary>

        [JsonPropertyName("iLanguageCode")]
        public double ILanguageCode { get; set; } = default!;

        /// <summary>
        /// timezone par défaut du groupe
        /// </summary>

        [JsonPropertyName("iTimezoneCode")]
        public double ITimezoneCode { get; set; } = default!;

        /// <summary>
        /// Echéance par défaut pour les factures du groupe en nombre de jours
        /// </summary>

        [JsonPropertyName("iDefautEcheanceFacture")]
        public double IDefautEcheanceFacture { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b unique reference.
        /// </summary>
        [JsonPropertyName("bUniqueReference")]
        public string BUniqueReference { get; set; } = default!;

        /// <summary>
        /// Possède au moins un fact. passée en perte
        /// </summary>

        [JsonPropertyName("bPerte")]
        public double BPerte { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d date creation.
        /// </summary>
        [JsonPropertyName("dDateCreation")]
        public string DDateCreation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the b deleted.
        /// </summary>
        [JsonPropertyName("bDeleted")]
        public string BDeleted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the d deleted date.
        /// </summary>
        [JsonPropertyName("dDeletedDate")]
        public string DDeletedDate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s i p creation.
        /// </summary>
        [JsonPropertyName("sIPCreation")]
        public string SIPCreation { get; set; } = default!;

        /// <summary>
        /// stocker si groupe a été créé après click sur bannière campagne
        /// </summary>

        [JsonPropertyName("iBannerCampagne")]
        public double IBannerCampagne { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id affiliation.
        /// </summary>
        [JsonPropertyName("idAffiliation")]
        public string IdAffiliation { get; set; } = default!;

        /// <summary>
        /// Etat du traitement si compte en doublon
        /// </summary>

        [JsonPropertyName("iStatutDoublon")]
        public double IStatutDoublon { get; set; } = default!;

        /// <summary>
        /// Date à laquelle le statut a été changé
        /// </summary>

        [JsonPropertyName("dDoublon")]
        public string DDoublon { get; set; } = default!;

        /// <summary>
        /// Référence unique du groupe que le client doit renseigner lors d'un paiement par IBAN
        /// </summary>

        [JsonPropertyName("sUniqueReference")]
        public string SUniqueReference { get; set; } = default!;

        /// <summary>
        /// Gets or sets the c g us.
        /// </summary>
        [JsonPropertyName("CGUs")]
        public ICollection<object> CGUs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public ICollection<Address> Addresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the billing addresses.
        /// </summary>
        [JsonPropertyName("billingAddresses")]
        public ICollection<Address> BillingAddresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonPropertyName("country")]
        public ICollection<Api_Country> Country { get; set; } = default!;

        /// <summary>
        /// Gets or sets the customization url.
        /// </summary>
        [JsonPropertyName("customizationUrl")]
        public object CustomizationUrl { get; set; } = default!;

        /// <summary>
        /// Gets or sets the demo groups.
        /// </summary>
        [JsonPropertyName("demoGroups")]
        public ICollection<Api_DemoGroup> DemoGroups { get; set; } = default!;

        /// <summary>
        /// Gets or sets the beta.
        /// </summary>
        [JsonPropertyName("beta")]
        public string Beta { get; set; } = default!;

        /// <summary>
        /// Gets or sets the country_id.
        /// </summary>
        [JsonPropertyName("country_id")]
        public string Country_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

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
        /// Gets or sets the fax.
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language_id.
        /// </summary>
        [JsonPropertyName("language_id")]
        public string Language_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the legal_entity_type.
        /// </summary>
        [JsonPropertyName("legal_entity_type")]
        public string Legal_entity_type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the partner.
        /// </summary>
        [JsonPropertyName("partner")]
        public string Partner { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s_phone.
        /// </summary>
        [JsonPropertyName("s_phone")]
        public string S_phone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the timezone_id.
        /// </summary>
        [JsonPropertyName("timezone_id")]
        public string Timezone_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tva.
        /// </summary>
        [JsonPropertyName("tva")]
        public string Tva { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; } = default!;

        /// <summary>
        /// Gets or sets the invitations.
        /// </summary>
        [JsonPropertyName("invitations")]
        public ICollection<object> Invitations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        [JsonPropertyName("invoices")]
        public ICollection<object> Invoices { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public ICollection<Api_Language> Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        [JsonPropertyName("logo")]
        public Api_Logo Logo { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logs.
        /// </summary>
        [JsonPropertyName("logs")]
        public ICollection<object> Logs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the premium support.
        /// </summary>
        [JsonPropertyName("premiumSupport")]
        public ICollection<object> PremiumSupport { get; set; } = default!;

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        [JsonPropertyName("products")]
        public ICollection<Api_Product> Products { get; set; } = default!;

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        [JsonPropertyName("roles")]
        public ICollection<object> Roles { get; set; } = default!;

        /// <summary>
        /// Gets or sets the services.
        /// </summary>
        [JsonPropertyName("services")]
        public ICollection<object> Services { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<Api_Tag> Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        [JsonPropertyName("teams")]
        public ICollection<object> Teams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        [JsonPropertyName("timezone")]
        public ICollection<object> Timezone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        [JsonPropertyName("users")]
        public ICollection<Api_User> Users { get; set; } = default!;
    }
}