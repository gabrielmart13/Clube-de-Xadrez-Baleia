using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IEventosService
    {
        Task<List<Eventos>> ListarEventos();
        Task<Eventos?> ConsultarEvento(int id);
        Task<Eventos> CriarEvento();
        Task<bool> AtualizarEvento(int id);
        Task<bool> CancelarEvento(int id);
        Task<EventRegistros> InscreverUsuario(int eventoId, int usuarioId);
        Task<bool> CancelarInscricao(int eventoId, int usuarioId);
        Task<List<EventRegistros>> ListarInscritos(int eventoId);
        Task<List<EventRegistros>> ListarMinhasInscricoes(int usuarioId);
    }
}