using XadrezBaleia.Application.DTOs.Eventos;
using XadrezBaleia.Application.DTOs.EventRegistros;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IEventosService
    {
        Task<List<VisualizarEventosDTO>> ListarEventos();
        Task<VisualizarEventosDTO?> ConsultarEvento(int id);
        Task<VisualizarEventosDTO> CriarEvento(CriarEventosDTO evento);
        Task<bool> AtualizarEvento(int id, AtualizarEventosDTO evento);
        Task<bool> CancelarEvento(int id);
        Task<VisualizarEventRegistrosDTO> InscreverUsuario(int eventoId, int usuarioId);
        Task<bool> CancelarInscricao(int eventoId, int usuarioId);
        Task<List<VisualizarEventRegistrosDTO>> ListarInscritos(int eventoId);
        Task<List<VisualizarEventRegistrosDTO>> ListarMinhasInscricoes(int usuarioId);
    }
}