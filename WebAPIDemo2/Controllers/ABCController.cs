using Microsoft.AspNetCore.Mvc;
using WebAPIDemo2.VMModels;

namespace WebAPIDemo2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ABCController : ControllerBase
    {
        private readonly ILogger<ABCController> _logger;

        public ABCController(ILogger<ABCController> logger)
        {
            _logger = logger;
        }
        [HttpGet("[action]/{id}")]
        public StudInfo MyNextAction(int id)
        {
            return new StudInfo { Id = id, Address = "from get action" };
        }
        [HttpPost("[action]/{id}")]
        public StudInfo MyAction(int id, [FromBody] StudInfo Data)
        {
            return new StudInfo { Id = id, Address = "ram" };
        }
    }
}