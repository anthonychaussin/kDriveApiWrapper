namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The player.
    /// </summary>
    public partial class Player : Data
    {
        /// <summary>
        /// Unique identifier of the `player` that is related to the resource `Player`
        /// </summary>

        [JsonPropertyName("player_id")]
        public int Player_id { get; set; } = default!;

        /// <summary>
        /// Name of the ressource `Player` visible by final customer
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Name of the video stream
        /// </summary>

        [JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Description of the stream
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Buffer memory enables the reduction of video interruptions if yours viewers connections become unstable by preloading
        /// </summary>

        [JsonPropertyName("buffer")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Buffer { get; set; } = default!;

        /// <summary>
        /// Start the video automatically (does not function on Android and iOS)
        /// </summary>

        [JsonPropertyName("auto_start")]
        public bool Auto_start { get; set; } = default!;

        /// <summary>
        /// Authorise full-screen mode
        /// </summary>

        [JsonPropertyName("allow_full_screen")]
        public bool Allow_full_screen { get; set; } = default!;

        /// <summary>
        /// This option is required to display your 360 video streaming
        /// </summary>

        [JsonPropertyName("is360")]
        public bool Is360 { get; set; } = default!;

        /// <summary>
        /// Display the playback bar
        /// </summary>

        [JsonPropertyName("show_controls")]
        public bool Show_controls { get; set; } = default!;

        /// <summary>
        /// Hide the playback bar after a few seconds
        /// </summary>

        [JsonPropertyName("auto_hide_controls")]
        public bool Auto_hide_controls { get; set; } = default!;

        /// <summary>
        /// Gets or sets the time_before_hide_cb.
        /// </summary>
        [JsonPropertyName("time_before_hide_cb")]
        public int Time_before_hide_cb { get; set; } = default!;

        /// <summary>
        /// Display the number of viewers
        /// </summary>

        [JsonPropertyName("show_viewers")]
        public bool Show_viewers { get; set; } = default!;

        /// <summary>
        /// Display from the following number after {number} viewers
        /// </summary>

        [JsonPropertyName("show_viewers_after")]
        public int Show_viewers_after { get; set; } = default!;

        /// <summary>
        /// Ratio of the player
        /// </summary>

        [JsonPropertyName("ratio")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ratio { get; set; } = default!;

        /// <summary>
        /// The width used for render the `Player` (px)
        /// </summary>

        [JsonPropertyName("width")]
        public int Width { get; set; } = default!;

        /// <summary>
        /// The height used for render the `Player` (px)
        /// </summary>

        [JsonPropertyName("height")]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Is the logo Infomaniak enabled?
        /// </summary>

        [JsonPropertyName("show_logo")]
        public bool Show_logo { get; set; } = default!;

        /// <summary>
        /// The logo url of the `Player`
        /// </summary>

        [JsonPropertyName("logo_img")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Logo_img { get; set; } = default!;

        /// <summary>
        /// is the position of logo
        /// </summary>

        [JsonPropertyName("logo_anchor")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PlayerLogo_anchor Logo_anchor { get; set; } = default!;

        /// <summary>
        /// The logo size in `Player`
        /// </summary>

        [JsonPropertyName("logo_percentage")]
        public int Logo_percentage { get; set; } = default!;

        /// <summary>
        /// The margin top log in `Player`
        /// </summary>

        [JsonPropertyName("logo_margin_top")]
        public int Logo_margin_top { get; set; } = default!;

        /// <summary>
        /// The margin left log in `Player`
        /// </summary>

        [JsonPropertyName("logo_margin_left")]
        public int Logo_margin_left { get; set; } = default!;

        /// <summary>
        /// The background color used in the `Player`
        /// </summary>

        [JsonPropertyName("control_color")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Control_color { get; set; } = default!;

        /// <summary>
        /// The button color used in the `Player`
        /// </summary>

        [JsonPropertyName("controlbar_color")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Controlbar_color { get; set; } = default!;

        /// <summary>
        /// The secondary color color used in the `Player`
        /// </summary>

        [JsonPropertyName("control_active_color")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Control_active_color { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether extract_preload_img.
        /// </summary>
        [JsonPropertyName("extract_preload_img")]
        public bool Extract_preload_img { get; set; } = default!;

        /// <summary>
        /// This image is displayed before the video is played.
        /// </summary>

        [JsonPropertyName("use_preload_img")]
        public bool Use_preload_img { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preload_img.
        /// </summary>
        [JsonPropertyName("preload_img")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Preload_img { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether use_geo_ip_img.
        /// </summary>
        [JsonPropertyName("use_geo_ip_img")]
        public bool Use_geo_ip_img { get; set; } = default!;

        /// <summary>
        /// Gets or sets the geo_ip_img.
        /// </summary>
        [JsonPropertyName("geo_ip_img")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Geo_ip_img { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether use_interrupt_img.
        /// </summary>
        [JsonPropertyName("use_interrupt_img")]
        public bool Use_interrupt_img { get; set; } = default!;

        /// <summary>
        /// This image is displayed if the viewer is not authorised to view the broadcast (IP, domain, unique hash code, etc.)
        /// </summary>

        [JsonPropertyName("interrupt_img")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Interrupt_img { get; set; } = default!;

        /// <summary>
        /// This image is displayed if the viewer is located in an unauthorised geographic
        /// </summary>

        [JsonPropertyName("use_restrict_img")]
        public bool Use_restrict_img { get; set; } = default!;

        /// <summary>
        /// This image is displayed if the viewer is not authorised to view the broadcast (IP, domain, unique hash code, etc.)
        /// </summary>

        [JsonPropertyName("restrict_img")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Restrict_img { get; set; } = default!;

        /// <summary>
        /// Is the countdown enabled?
        /// </summary>

        [JsonPropertyName("countdown")]
        public bool Countdown { get; set; } = default!;

        /// <summary>
        /// Description of the countdown of the `Player` visible by final customer
        /// </summary>

        [JsonPropertyName("countdown_txt")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Countdown_txt { get; set; } = default!;

        /// <summary>
        /// countdown days
        /// </summary>

        [JsonPropertyName("countdown_days")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Countdown_days { get; set; } = default!;

        /// <summary>
        /// hours days
        /// </summary>

        [JsonPropertyName("countdown_hours")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Countdown_hours { get; set; } = default!;

        /// <summary>
        /// countdown minutes
        /// </summary>

        [JsonPropertyName("countdown_minutes")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Countdown_minutes { get; set; } = default!;

        /// <summary>
        /// countdown seconde
        /// </summary>

        [JsonPropertyName("countdown_seconds")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Countdown_seconds { get; set; } = default!;

        /// <summary>
        /// Authorise other users to intergrate your live event on their sites
        /// </summary>

        [JsonPropertyName("enable_embed_code")]
        public bool Enable_embed_code { get; set; } = default!;

        /// <summary>
        /// Is the facebook embed link visible?
        /// </summary>

        [JsonPropertyName("enable_facebook")]
        public bool Enable_facebook { get; set; } = default!;

        /// <summary>
        /// The Twitter backlink used to facebook embed
        /// </summary>

        [JsonPropertyName("facebook_back_link")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Facebook_back_link { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether facebook_player_embed.
        /// </summary>
        [JsonPropertyName("facebook_player_embed")]
        public bool Facebook_player_embed { get; set; } = default!;

        /// <summary>
        /// Is the Twitter embed link visible?
        /// </summary>

        [JsonPropertyName("enable_twitter")]
        public bool Enable_twitter { get; set; } = default!;

        /// <summary>
        /// Gets or sets the twitter_via.
        /// </summary>
        [JsonPropertyName("twitter_via")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Twitter_via { get; set; } = default!;

        /// <summary>
        /// The Twitter backlink used to twitter embed
        /// </summary>

        [JsonPropertyName("twitter_back_link")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Twitter_back_link { get; set; } = default!;

        /// <summary>
        /// The Twitter hashtag used to Twitter embed
        /// </summary>

        [JsonPropertyName("twitter_related")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Twitter_related { get; set; } = default!;

        /// <summary>
        /// Timestamp `Player` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Player` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Is the ads enabled?
        /// </summary>

        [JsonPropertyName("ads_enabled")]
        public bool Ads_enabled { get; set; } = default!;

        /// <summary>
        /// Display the playback bar during the ads
        /// </summary>

        [JsonPropertyName("show_controls_during_ads")]
        public bool Show_controls_during_ads { get; set; } = default!;

        /// <summary>
        /// Is the sound enabled?
        /// </summary>

        [JsonPropertyName("sound_enabled")]
        public bool Sound_enabled { get; set; } = default!;

        /// <summary>
        /// The volume used in the `Player`
        /// </summary>

        [JsonPropertyName("sound_percentage")]
        public int Sound_percentage { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_viewers_only_after.
        /// </summary>
        [JsonPropertyName("show_viewers_only_after")]
        public bool Show_viewers_only_after { get; set; } = default!;

        /// <summary>
        /// you need to use a player that supports https in order for chromecast to work correctly
        /// </summary>

        [JsonPropertyName("chromecast")]
        public bool Chromecast { get; set; } = default!;

        /// <summary>
        /// Gets or sets the stereo_projection360.
        /// </summary>
        [JsonPropertyName("stereo_projection360")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Stereo_projection360 { get; set; } = default!;

        /// <summary>
        /// The ads url
        /// </summary>

        [JsonPropertyName("ads_url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ads_url { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether interrupted.
        /// </summary>
        [JsonPropertyName("interrupted")]
        public bool Interrupted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        [JsonPropertyName("channel")]
        public Channel Channel { get; set; } = default!;

        /// <summary>
        /// Gets or sets the integrations.
        /// </summary>
        [JsonPropertyName("integrations")]
        public ICollection<Integrationsressource> Integrations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the countdown_stops_at.
        /// </summary>
        [JsonPropertyName("countdown_stops_at")]
        public string Countdown_stops_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the thumbnail_url.
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public string Thumbnail_url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the restrictions.
        /// </summary>
        [JsonPropertyName("restrictions")]
        public string Restrictions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ads.
        /// </summary>
        [JsonPropertyName("ads")]
        public string Ads { get; set; } = default!;
    }
}