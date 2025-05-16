namespace StinkyProjectServer
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC);

        public string? Summary { get; set; }

        public string? Nameteams { get; set; }

        public string TeamName { get; set; } = string.Empty;
    }
}
