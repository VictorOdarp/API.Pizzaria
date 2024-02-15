using System.Text.Json.Serialization;

namespace APIPizzaria.Enums.Pizza
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SaborEnum
    {
        Calabresa,
        FrangoCatupiry,
        Mexicana,
        Toscana,
        Palmito
    }
}
