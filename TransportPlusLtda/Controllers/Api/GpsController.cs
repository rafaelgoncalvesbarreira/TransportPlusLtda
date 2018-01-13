using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportPlusLtda.Models.Api;

namespace TransportPlusLtda.Controllers.Api
{
    /// <summary>
    /// This is a Mock API. All values will be random
    /// </summary>
    [Produces("application/json")]
    [Route("api/Gps")]
    public class GpsController : Controller
    {
        [HttpGet("{id}")]
        public PositionViewModel Get(Guid id)
        {
            Random random = new Random();

            return new PositionViewModel
            {
                Id = Guid.NewGuid(),
                Latitude = (random.NextDouble() * 2.0 - 1.0) * 90,
                Longitude = (random.NextDouble() * 2.0 - 1.0) * 180
            };
        }
    }
}