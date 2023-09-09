namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ILogger<WeatherForecastService> _log;

        public WeatherForecastService(ILogger<WeatherForecastService> log)
        {
            _log = log;
           
        }

    

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {

            _log.LogInformation("Logging from inside method <GetForecastAsync> WeatherForecastService ");

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
