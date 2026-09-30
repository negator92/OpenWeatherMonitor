using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public record Coord
{
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    public double Lon { get; set; }
}
