using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminsController : ControllerBase
    {
        // Listar todos os administradores
        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar um administrador específico
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Criar um novo administrador
        [HttpPost]
        public async Task<ActionResult<Usuarios>> Post(
            [FromBody] CriarUsuariosDTO admin)
        {
            throw new NotImplementedException();
        }

        // Atualizar os dados de um administrador
        [HttpPut("{id}")]
        public async Task<ActionResult<Usuarios>> Put(
            int id,
            [FromBody] AtualizarUsuariosDTO admin)
        {
            throw new NotImplementedException();
        }

        // Ativar ou desativar um administrador
        [HttpPatch("{id}/status")]
        public async Task<ActionResult<Usuarios>> Patch(int id)
        {
            throw new NotImplementedException();
        }
    }
}