using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Premium.Common.Dispatchers;
using Premium.ProcessManager.Messages.Commands;

namespace Premium.ProcessManager.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserCommandController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public UserCommandController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<ActionResult> Execute(UserCommand command)
        { 
            await _dispatcher.SendAsync(command);
            return Ok();
        
        }

        
    }
}
