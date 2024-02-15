using System.Text.Json.Serialization;

namespace APIPizzaria.Enums.Bebida
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NomeEnum
    {
        CocaCola, 
        Sprite,
        Sukita,
        Pepsi

    }
}
