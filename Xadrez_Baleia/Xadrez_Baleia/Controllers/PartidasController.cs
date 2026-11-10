using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidasController : ControllerBase
    {
        // Registrar uma nova partida (administrador)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Partidas>> Post()
        {
            throw new NotImplementedException();
        }

        // Listar todas as partidas
        [HttpGet]
        public async Task<ActionResult<List<Partidas>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar o histórico de partidas de um jogador
        [HttpGet("player/{id}")]
        public async Task<ActionResult<List<Partidas>>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Corrigir uma partida já registrada (administrador)
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<Partidas>> Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}