using System.Collections.Generic;

namespace WeatherApp.Models {
    public class WeatherData {
        public double Temperature { get; set; }

        public string WeatherDescription { get; set; } = "";

        public int WeatherCode { get; set; }

        public int Humidity { get; set; }

        public double WindSpeed { get; set; }

        public List<DailyWeatherData> DailyForecasts { get; set; }
    = new();

    }
}
