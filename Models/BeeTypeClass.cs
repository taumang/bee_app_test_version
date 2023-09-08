using System.Text.Json.Serialization;

namespace bee_app.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BeeTypeClass
    {
        African_Killer_Bee = 1,
        Sweat_Bee = 2,
        Asian_Honey_Bee = 3
    }
}