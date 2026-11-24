using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;
using System.Collections.Generic;

namespace WeatherApp.Services {
    public class WeatherService {
        private readonly HttpClient _httpClient;

        public WeatherService() {
            _httpClient = new HttpClient();
        }

        private string GetWeatherDescription(int weatherCode) {
            return weatherCode switch {
                0 => "晴れ",
                1 => "晴れ時々曇り",
                2 => "一部曇り",
                3 => "曇り",

                45 => "霧",
                48 => "着氷性の霧",

                61 => "雨",
                63 => "やや強い雨",
                65 => "強い雨",

                71 => "雪",
                73 => "やや強い雪",
                75 => "大雪",

                80 => "にわか雨",
                81 => "強いにわか雨",
                82 => "激しいにわか雨",

                95 => "雷雨",

                _ => "不明"
            };
        }

        public async Task<WeatherData> GetCurrentWeatherAsync() {
            string url =
    "https://api.open-meteo.com/v1/forecast" +
    "?latitude=35.6895" +
    "&longitude=139.6917" +
    "&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m" +
    "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
    "&forecast_days=7" +
    "&timezone=Asia%2FTokyo";

            string json = await _httpClient.GetStringAsync(url);

            using JsonDocument document = JsonDocument.Parse(json);

            JsonElement current =
                document.RootElement.GetProperty("current");

            JsonElement daily =
                document.RootElement.GetProperty("daily");

            var forecasts = new List<DailyWeatherData>();


            JsonElement dates =
                daily.GetProperty("time");

            JsonElement weatherCodes =
                daily.GetProperty("weather_code");

            JsonElement maxTemps =
                daily.GetProperty("temperature_2m_max");

            JsonElement minTemps =
                daily.GetProperty("temperature_2m_min");

            JsonElement precipitationProbabilities =
                daily.GetProperty("precipitation_probability_max");

            for (int i = 0; i < dates.GetArrayLength(); i++) {
                forecasts.Add(new DailyWeatherData {
                    Date = DateTime.Parse(
        dates[i].GetString() ?? "")
        .ToString("MM/dd"),

                    WeatherCode =
        weatherCodes[i].GetInt32(),

                    WeatherDescription =
        GetWeatherDescription(
            weatherCodes[i].GetInt32()),

                    MaxTemperature =
        maxTemps[i].GetDouble(),

                    MinTemperature =
        minTemps[i].GetDouble(),

                    PrecipitationProbability =
        precipitationProbabilities[i].GetInt32()
                });
            }

            return new WeatherData {
                Temperature = current
        .GetProperty("temperature_2m")
        .GetDouble(),

                Humidity = current
        .GetProperty("relative_humidity_2m")
        .GetInt32(),

                WeatherCode = current
        .GetProperty("weather_code")
        .GetInt32(),

                WindSpeed = current
        .GetProperty("wind_speed_10m")
        .GetDouble(),

                DailyForecasts = forecasts
            };
        }
    }
}
