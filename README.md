# OpenWeatherMonitor
Console, web api solution to get weather info


```csharp
const string baseURL = "https://api.openweathermap.org/data/2.5/weather";
string url = $"{baseURL}?lat={lat}&lon={lon}&units=metric&appid={ApiKey}";
```


```csharp
sting response = $"Погода в {formattedCoordinates}:\n\n" +
                 $"Температура: {weather.Main.Temp:F1}*C\n" +
                 $"Ощущается как: {weather.Main.FeelsLike:F1}*C\n" +
                 $"Состояние: {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(description)}\n" + // Title case formatting
                 $"Влажность: {weather.Main.Humidity}% \n" +
                 $"Ветер: {weather.Wind.Speed:F1}м/с\n" +
                 $"Давление: {weather.Main.Pressure:F0}!mmHg\n" + // Assuming pressure is displayed as integers (hPa)
                                                                  // NOTE: The original Go code used weather.Clouds.All which was not modeled.
                                                                  // I am keeping it out or assuming a placeholder if needed, but sticking to current fields.
                 $"Облачность: N/A%\n" + // Placeholder for Clouds percentage
                 $"Восход: {DateTimeOffset.FromUnixTimeSeconds((long)weather.System.Sunrise).LocalDateTime:HH:mm}\n" + // Convert Unix time to readable format
                 $"Закат: {DateTimeOffset.FromUnixTimeSeconds((long)weather.System.Sunset).LocalDateTime:HH:mm}";
```

```csharp
(double lat2, double lon2) = (55.7164, 37.690); // Placeholder: Example coordinates near Moscow
```