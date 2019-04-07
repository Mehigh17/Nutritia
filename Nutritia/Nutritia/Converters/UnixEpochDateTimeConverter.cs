using Newtonsoft.Json;
using System;

namespace Nutritia.Converters
{
    public class UnixEpochDateTimeConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            if (long.TryParse(reader.Value.ToString(), out var epochTime))
            {
                dateTime = dateTime.AddSeconds(epochTime);
            }

            return dateTime;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

    }
}
