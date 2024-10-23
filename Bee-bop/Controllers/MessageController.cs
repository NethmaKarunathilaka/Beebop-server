using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;
using Bee_bop.Services;
using Microsoft.AspNetCore.Authorization;


namespace Bee_bop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _service;

        public MessageController(IMessageService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("SubmitMessage")]
        public async Task<IActionResult> Post([FromBody] MessageSendDto message)
        {
            await _service.SubmitMessage(message);
            return Ok();
        }


    }
}
