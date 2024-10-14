using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bee_bop.Models;

namespace Bee_bop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        [Route("SubmitMessages")]
        public IActionResult SubmitMessages([FromBody] Message message)
        {
            _messageService.SubmitMessage(message);
            return Ok();
        }
    }
}
