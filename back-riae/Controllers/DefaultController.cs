using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DefaultController : ControllerBase
    {
        public DefaultController(ILogger<WeatherForecastController> logger)
        {
            //GET
            [HttpGet]

            public string Get()
            {
                return "Aplicacion corriendo..."
            }
            
        }

        
    }
}