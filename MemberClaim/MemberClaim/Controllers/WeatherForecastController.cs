using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberClaim.Model;
using MemberClaim.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MemberClaim.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICsvData csvData;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,ICsvData csv)
        {
            _logger = logger;
            csvData = csv;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            Member c1 = new Member();
            c1.FirstName = "smit";
            c1.LastName = "samarth";
            List<object> ol = new List<object>();
            ol.Add(c1);
            var rng = new Random();
            var result = csvData.LoadClaimCsv();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
