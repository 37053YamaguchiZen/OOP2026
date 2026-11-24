using System;
using System.Windows;
using WeatherApp.Services;

namespace WeatherApp {
    public partial class MainWindow : Window {
        private readonly WeatherService _weatherService;

        public MainWindow() {
            InitializeComponent();

            _weatherService = new WeatherService();

            Loaded += MainWindow_Loaded;
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

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            try {
                var weather = await _weatherService.GetCurrentWeatherAsync();

                TemperatureTextBlock.Text =
                    $"{weather.Temperature:F1} ℃";

                WeatherTextBlock.Text =
                    GetWeatherDescription(weather.WeatherCode);

                HumidityTextBlock.Text =
                    $"{weather.Humidity} %";

                WindTextBlock.Text =
                    $"{weather.WindSpeed:F1} m/s";

                ForecastDataGrid.ItemsSource =
                    weather.DailyForecasts;
            }
            catch (Exception ex) {
                TemperatureTextBlock.Text =
                    $"取得失敗: {ex.Message}";
            }
        }
    }
}