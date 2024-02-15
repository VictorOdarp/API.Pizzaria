using System.Text.Json.Serialization;

namespace APIPizzaria.Enums.Pizza
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TamanhoEnum
    {
       Broto,
       Média,
       Grande,
       Big,
       Gigante
    }
}
