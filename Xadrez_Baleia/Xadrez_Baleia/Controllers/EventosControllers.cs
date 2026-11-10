using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Application.DTOs.Eventos;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        // Listar todos os eventos
        [HttpGet]
        public async Task<ActionResult<List<Eventos>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar um evento específico pelo ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Eventos>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Criar um novo evento
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Eventos>> Post(CriarEventosDTO evento)
        {
            throw new NotImplementedException();
        }

        // Atualizar os dados de um evento
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<Eventos>> Put(int id, AtualizarEventosDTO evento)
        {
            throw new NotImplementedException();
        }

        // Cancelar um evento
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        // Inscrever o usuário em um evento
        [Authorize]
        [HttpPost("{id}/registrations")]
        public async Task<ActionResult<EventRegistros>> Post(int id)
        {
            throw new NotImplementedException();
        }

        // Cancelar a própria inscrição em um evento
        [Authorize]
        [HttpDelete("{id}/registrations/me")]
        public async Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        // Listar todos os inscritos em um evento
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}/registrations")]
        public async Task<ActionResult<List<EventRegistros>>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Listar as inscrições do usuário autenticado
        [Authorize]
        [HttpGet("me/registrations")]
        public async Task<ActionResult<List<EventRegistros>>> Get()
        {
            throw new NotImplementedException();
        }
    }
}