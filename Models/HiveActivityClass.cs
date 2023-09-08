using System.Text.Json.Serialization;

namespace bee_app.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HiveActivityClass
    {
        Active = 1,
        Non_Active = 2,
        Semi_Active = 3,
    }
}