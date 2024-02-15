using System.Text.Json.Serialization;

namespace APIPizzaria.Enums.Bebida
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TamanhoEnum
    {
        Lata,
        Garrafa1Litro,
        Garrafa2Litros

    }
}
