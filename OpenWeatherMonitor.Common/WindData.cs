using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public record WindData
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; } // In meters/sec (Metric)
}
