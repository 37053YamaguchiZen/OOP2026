namespace WeatherApp.Models {
    public class DailyWeatherData {
        public string Date { get; set; } = "";

        public int WeatherCode { get; set; }

        public string WeatherDescription { get; set; } = "";

        public double MaxTemperature { get; set; }

        public double MinTemperature { get; set; }

        public int PrecipitationProbability { get; set; }
    }
}
