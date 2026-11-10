using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        // Listar todos os usuários (administrador)
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar os próprios dados
        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<Usuarios>> GetMe()
        {
            throw new NotImplementedException();
        }

        // Atualizar os próprios dados
        [Authorize]
        [HttpPut("me")]
        public async Task<ActionResult<Usuarios>> Put(
            [FromBody] AtualizarUsuariosDTO usuarios)
        {
            throw new NotImplementedException();
        }
    }
}