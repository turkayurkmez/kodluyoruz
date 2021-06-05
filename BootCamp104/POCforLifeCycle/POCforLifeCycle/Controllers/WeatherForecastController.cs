using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POCforLifeCycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ISingletonGenerator singleton;
        private readonly IScopedGenerator scoped;
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ITransientGenerator transient;
        private readonly CustomService customService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISingletonGenerator singleton, IScopedGenerator scoped, ITransientGenerator transient, CustomService customService)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
            this.customService = customService;
            _logger = logger;
        }

        [HttpGet]
        public GuidModel Get()
        {
            GuidModel guidModel = new GuidModel
            {
                ScopedGuid = scoped.GeneratedGuid,
                SingletonGuid = singleton.GeneratedGuid,
                TransientGuid = transient.GeneratedGuid,
                //dikkat!!! servis aracılığı ile geliyor:
                ScopedServiceGuid = customService.ScopedGuid,
                SingletonServiceGuid = customService.SingletonGuid,
                TransientServiceGuid = customService.TransientGuid
            };
        


            return guidModel;
        }
    }
}
