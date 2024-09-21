using Microsoft.AspNetCore.Mvc;
using TuckerAPIProject.Models;

namespace TuckerAPIProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public DeliveryController()
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public void Get()
        {
            return;
        }
    }
}