using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public class WeatherDescription
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}
