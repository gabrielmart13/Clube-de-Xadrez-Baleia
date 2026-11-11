
using XadrezBaleia.Application.DTOs.HistoricoRating;
using XadrezBaleia.Application.DTOs.Partidas;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IRatingService
    {
        Task<List<VisualizarUsuariosDTO>> ListarTodosRating();
        Task<VisualizarUsuariosDTO> ConsultarRatingProprio(int id);
        Task<List<VisualizarHistoricoRatingDTO>> ConsultarDesempenhoProprio(int id);
        Task<List<VisualizarPartidaDTo>> ConsultarHistoricoPartidas();
    }
}