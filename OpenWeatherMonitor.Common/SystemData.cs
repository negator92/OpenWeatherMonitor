using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public class SystemData
{
    [JsonPropertyName("sunrise")]
    public long Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public long Sunset { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("population")]
    public int Population { get; set; }
}
