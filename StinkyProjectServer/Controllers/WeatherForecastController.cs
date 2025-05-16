using Microsoft.AspNetCore.Mvc;

namespace StinkyProjectServer.Controllers
{
    [ApiController]
    [Route("[controller]")]



    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Lost Game", "No Gain", "Gained One", "Gain Two",
        };

        private static readonly string[] nameteamsss = new[]
        {
            "Los Angeles Kings", "Ednomonton Oilers", "Anaheim Ducks", "Buffalo Sabres",
        };

        private readonly ILogger<WeatherForecastController> _logger;


        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(1, 32),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Nameteams = nameteamsss[Random.Shared.Next(nameteamsss.Length)]

            })
            .ToArray();
        }
    }
}
