using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartyFinder.BLL.User.Command.LoginCommand;

namespace PartyFinder.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiController
    {

        [HttpPost("Login")]
        public async Task<IActionResult> Login()
        {
            var res = await Mediator.Send(new LoginCommand());
            return Ok(res);
        }
    }
}