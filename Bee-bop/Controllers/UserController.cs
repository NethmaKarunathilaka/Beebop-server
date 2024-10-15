using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;
using Bee_bop.Services;

namespace Bee_bop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> Post([FromBody] UserRegDto newUser)
        {
            await _service.Create(newUser);
            return Ok();
        }



    }
}



