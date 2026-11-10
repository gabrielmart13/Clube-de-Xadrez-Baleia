using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using XadrezBaleia.Application.DTOs.Usuarios;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult> Post([FromBody] CriarUsuariosDTO usuario)
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Post([FromBody] FazerLoginDTO usuario)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult> Get()
        { 
            throw new NotImplementedException();
        }
    }
}