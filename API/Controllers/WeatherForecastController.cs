using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IDoSomethingService doSomethingService;

        public WeatherForecastController(IDoSomethingService _doSomethingService)
        {
            this.doSomethingService = _doSomethingService;
        }

        [HttpGet]
        public string Get()
        {
            return doSomethingService.getMessage();
        }
    }
}