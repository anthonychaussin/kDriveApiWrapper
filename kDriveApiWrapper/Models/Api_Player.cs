namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Player
    /// </summary>

    public partial class Api_Player
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether default.
        /// </summary>
        [JsonPropertyName("default")]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_controls.
        /// </summary>
        [JsonPropertyName("show_controls")]
        public bool Show_controls { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_progression.
        /// </summary>
        [JsonPropertyName("show_progression")]
        public bool Show_progression { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_audio.
        /// </summary>
        [JsonPropertyName("show_audio")]
        public bool Show_audio { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_duration.
        /// </summary>
        [JsonPropertyName("show_duration")]
        public bool Show_duration { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_fullscreen.
        /// </summary>
        [JsonPropertyName("show_fullscreen")]
        public bool Show_fullscreen { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_default_logo.
        /// </summary>
        [JsonPropertyName("show_default_logo")]
        public bool Show_default_logo { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_speed.
        /// </summary>
        [JsonPropertyName("show_speed")]
        public bool Show_speed { get; set; } = default!;

        /// <summary>
        /// Gets or sets the default_speed.
        /// </summary>
        [JsonPropertyName("default_speed")]
        public float Default_speed { get; set; } = default!;

        /// <summary>
        /// Gets or sets the is360.
        /// </summary>
        [JsonPropertyName("is360")]
        public double Is360 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding_change_enabled.
        /// </summary>
        [JsonPropertyName("encoding_change_enabled")]
        public double Encoding_change_enabled { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding_limit.
        /// </summary>
        [JsonPropertyName("encoding_limit")]
        public double Encoding_limit { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether chromecast.
        /// </summary>
        [JsonPropertyName("chromecast")]
        public bool Chromecast { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether force_media_ratio.
        /// </summary>
        [JsonPropertyName("force_media_ratio")]
        public bool Force_media_ratio { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether auto_start.
        /// </summary>
        [JsonPropertyName("auto_start")]
        public bool Auto_start { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_volume.
        /// </summary>
        [JsonPropertyName("audio_volume")]
        public double Audio_volume { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_replay.
        /// </summary>
        [JsonPropertyName("show_replay")]
        public bool Show_replay { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_loop.
        /// </summary>
        [JsonPropertyName("show_loop")]
        public bool Show_loop { get; set; } = default!;

        /// <summary>
        /// Gets or sets the show_related.
        /// </summary>
        [JsonPropertyName("show_related")]
        public double Show_related { get; set; } = default!;

        /// <summary>
        /// Gets or sets the play_related.
        /// </summary>
        [JsonPropertyName("play_related")]
        public double Play_related { get; set; } = default!;

        /// <summary>
        /// Gets or sets the related_type.
        /// </summary>
        [JsonPropertyName("related_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_PlayerRelated_type Related_type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public double Width { get; set; } = default!;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public double Height { get; set; } = default!;

        /// <summary>
        /// Gets or sets the controlbar_color.
        /// </summary>
        [JsonPropertyName("controlbar_color")]
        public string Controlbar_color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the control_color.
        /// </summary>
        [JsonPropertyName("control_color")]
        public string Control_color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the control_active_color.
        /// </summary>
        [JsonPropertyName("control_active_color")]
        public string Control_active_color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_image.
        /// </summary>
        [JsonPropertyName("logo_image")]
        public Api_DataUrl Logo_image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_anchor.
        /// </summary>
        [JsonPropertyName("logo_anchor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_PlayerLogo_anchor Logo_anchor { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_margin_vertical.
        /// </summary>
        [JsonPropertyName("logo_margin_vertical")]
        public double Logo_margin_vertical { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_margin_horizontal.
        /// </summary>
        [JsonPropertyName("logo_margin_horizontal")]
        public double Logo_margin_horizontal { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_percentage.
        /// </summary>
        [JsonPropertyName("logo_percentage")]
        public double Logo_percentage { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_media_info.
        /// </summary>
        [JsonPropertyName("show_media_info")]
        public bool Show_media_info { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_media_thumbnail.
        /// </summary>
        [JsonPropertyName("show_media_thumbnail")]
        public bool Show_media_thumbnail { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media_thumbnail_anchor.
        /// </summary>
        [JsonPropertyName("media_thumbnail_anchor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_PlayerMedia_thumbnail_anchor Media_thumbnail_anchor { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether auto_hide_controls.
        /// </summary>
        [JsonPropertyName("auto_hide_controls")]
        public bool Auto_hide_controls { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_viewers.
        /// </summary>
        [JsonPropertyName("show_viewers")]
        public bool Show_viewers { get; set; } = default!;

        /// <summary>
        /// Gets or sets the show_viewers_after.
        /// </summary>
        [JsonPropertyName("show_viewers_after")]
        public double Show_viewers_after { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether show_viewers_only_after.
        /// </summary>
        [JsonPropertyName("show_viewers_only_after")]
        public bool Show_viewers_only_after { get; set; } = default!;

        /// <summary>
        /// Gets or sets the time_before_hide_cb.
        /// </summary>
        [JsonPropertyName("time_before_hide_cb")]
        public double Time_before_hide_cb { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enable_facebook.
        /// </summary>
        [JsonPropertyName("enable_facebook")]
        public bool Enable_facebook { get; set; } = default!;

        /// <summary>
        /// Gets or sets the facebook_back_link.
        /// </summary>
        [JsonPropertyName("facebook_back_link")]
        public string Facebook_back_link { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether facebook_player_embed.
        /// </summary>
        [JsonPropertyName("facebook_player_embed")]
        public bool Facebook_player_embed { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enable_twitter.
        /// </summary>
        [JsonPropertyName("enable_twitter")]
        public bool Enable_twitter { get; set; } = default!;

        /// <summary>
        /// Gets or sets the twitter_via.
        /// </summary>
        [JsonPropertyName("twitter_via")]
        public string Twitter_via { get; set; } = default!;

        /// <summary>
        /// Gets or sets the twitter_back_link.
        /// </summary>
        [JsonPropertyName("twitter_back_link")]
        public string Twitter_back_link { get; set; } = default!;

        /// <summary>
        /// Gets or sets the twitter_related.
        /// </summary>
        [JsonPropertyName("twitter_related")]
        public string Twitter_related { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enable_embed_code.
        /// </summary>
        [JsonPropertyName("enable_embed_code")]
        public bool Enable_embed_code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preload_image.
        /// </summary>
        [JsonPropertyName("preload_image")]
        public Api_DataUrl Preload_image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the interrupt_image.
        /// </summary>
        [JsonPropertyName("interrupt_image")]
        public Api_DataUrl Interrupt_image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the geoip_image.
        /// </summary>
        [JsonPropertyName("geoip_image")]
        public Api_DataUrl Geoip_image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the restrict_image.
        /// </summary>
        [JsonPropertyName("restrict_image")]
        public Api_DataUrl Restrict_image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_channel_default.
        /// </summary>
        [JsonPropertyName("is_channel_default")]
        public bool Is_channel_default { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ads.
        /// </summary>
        [JsonPropertyName("ads")]
        public ICollection<Api_Ad> Ads { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether owned.
        /// </summary>
        [JsonPropertyName("owned")]
        public bool Owned { get; set; } = default!;

        /// <summary>
        /// Gets or sets the shares.
        /// </summary>
        [JsonPropertyName("shares")]
        public ICollection<Api_Share> Shares { get; set; } = default!;
    }
}