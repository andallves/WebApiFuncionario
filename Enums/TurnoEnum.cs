using System.Text.Json.Serialization;

namespace WebAPIFuncionarios.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TurnoEnum
{
    Manha,
    Tarde,
    Noite
}