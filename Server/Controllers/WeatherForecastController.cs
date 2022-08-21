using DecisoesEmGrupo.Shared;
using Microsoft.AspNetCore.Mvc;
using DecisoesEmGrupo.Server.Context;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DecisoesEmGrupo.Server.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("db")]
        public async Task<ActionResult<string>> Test()
        {
            string st = "teste";
            return await Task.FromResult(st);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //DatabaseDbContext db = new();
            //var created = db.Database.EnsureCreated();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();
        }
    }
}
