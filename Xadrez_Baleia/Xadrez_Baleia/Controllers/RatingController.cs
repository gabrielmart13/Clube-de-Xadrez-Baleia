using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
        // Listar todos os jogadores no ranking
        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar a posição de um jogador específico no ranking
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Consultar o próprio desempenho
        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<Usuarios>> GetMe()
        {
            throw new NotImplementedException();
        }

        // Consultar o próprio histórico de rating
        [Authorize]
        [HttpGet("me/history")]
        public async Task<ActionResult<List<HistoricoRating>>> GetHistory()
        {
            throw new NotImplementedException();
        }
    }
}