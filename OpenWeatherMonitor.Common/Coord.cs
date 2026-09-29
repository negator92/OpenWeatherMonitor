using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public class Coord
{
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    public double Lon { get; set; }
}
