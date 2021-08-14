using System;
using Microsoft.AspNetCore.Mvc;
using SignalRFirs.Hubs;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignalRFirs.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private PositionHub _positionHub = new PositionHub();

        [HttpGet]
        public double Get()
        {
            return 12;
        }
    }
}
