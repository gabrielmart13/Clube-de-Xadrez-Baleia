using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IRatingService
    {
        Task<List<Usuarios>> ListarTodosRating();
        Task<Usuarios> ConsultarRatingProprio();
        Task<List<HistoricoRating>> ConsultarDesempenhoProprio();
        Task<List<Partidas>> ConsultarHistoricoPartidas();
    }
}