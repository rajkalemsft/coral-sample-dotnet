using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace App.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        private static readonly Counter Hits = Metrics.CreateCounter("api_hits_total", "Number of hits");

        [HttpGet]
        public string Get()
        {
            Hits.Inc();
            return "Hello, World!";
        }
    }
}