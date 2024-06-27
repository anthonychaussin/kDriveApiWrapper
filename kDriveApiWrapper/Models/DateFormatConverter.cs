namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The date format converter.
    /// </summary>
    internal class DateFormatConverter : JsonConverter<DateTimeOffset>
    {
        /// <summary>
        /// Reads the.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">The options.</param>
        /// <returns>A DateTimeOffset.</returns>
        public override DateTimeOffset Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            var dateTime = reader.GetString() ?? throw new JsonException("Unexpected JsonTokenType.Null");
            return DateTimeOffset.Parse(dateTime);
        }

        /// <summary>
        /// Writes the.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The options.</param>
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }
}