using Microsoft.AspNetCore.Mvc;
using ResumeApp.WebApi.Services;

namespace ResumeApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServersController : ControllerBase
    {
        private readonly ILogger<ServersController> _logger;

        public IServerService ServerService { get; }

        public ServersController(ILogger<ServersController> logger, IServerService serverService)
        {
            this._logger = logger;
            this.ServerService = serverService;
        }

        [HttpGet()]
        public ActionResult Get()
        {
            var data = this.ServerService.GetAll();
            return Ok(data);
        }
    }
}
