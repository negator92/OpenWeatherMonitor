using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public class OWMResponse
{
    [JsonPropertyName("coord")]
    public Coord Coordinate { get; set; }

    [JsonPropertyName("weather")]
    public List<WeatherDescription> Weather { get; set; }

    [JsonPropertyName("main")]
    public MainData Main { get; set; }

    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }

    [JsonPropertyName("wind")]
    public WindData Wind { get; set; }

    [JsonPropertyName("dt")]
    public long Dt { get; set; } // Time of data

    [JsonPropertyName("sys")]
    public SystemData System { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
