using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Holidays.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HolidayController : ControllerBase
    {
        private readonly ILogger<HolidayController> _logger;

        public HolidayController(ILogger<HolidayController> logger)
        {
            _logger = logger;
        }
    }
}
