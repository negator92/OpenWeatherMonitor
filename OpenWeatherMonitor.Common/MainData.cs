using System.Text.Json.Serialization;

namespace OpenWeatherMonitor.Common;

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; } // Current temperature (Metric)

    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("pressure")]
    public double Pressure { get; set; } // In hPa, typically reported as mmHg equivalent in some contexts

    // Assuming 'clouds' data structure might be needed if the user intended to use it
    // For simplicity, we skip adding a separate Clouds property unless necessary.
}
