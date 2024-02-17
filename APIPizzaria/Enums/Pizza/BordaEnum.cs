using System.Text.Json.Serialization;

namespace APIPizzaria.Enums.Pizza
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BordaEnum
    {
        ChocolatePreto,
        ChocolateBranco,
        DoisAmores,
        Catupiry,
        Cheedar,

    }
}
