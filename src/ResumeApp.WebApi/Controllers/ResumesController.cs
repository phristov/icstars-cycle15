using Microsoft.AspNetCore.Mvc;
using ResumeApp.WebApi.Services;

namespace ResumeApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumesController : ControllerBase
    {
        private readonly ILogger<ResumesController> _logger;

        public IResumeService ResumeService { get; }

        public ResumesController(ILogger<ResumesController> logger, IResumeService resumeService)
        {
            _logger = logger;
            this.ResumeService = resumeService;
        }

        [HttpGet()]
        public ActionResult Get()
        {
            var data = this.ResumeService.GetAll();

            return Ok(data);
        }


        [HttpGet("{id}")]
        public ActionResult GetById(long id)
        {
            var data = this.ResumeService.GetById(id);

            if (data == null)
            {
                return this.NotFound();
            }

            return Ok(data);
        }
    }
}
