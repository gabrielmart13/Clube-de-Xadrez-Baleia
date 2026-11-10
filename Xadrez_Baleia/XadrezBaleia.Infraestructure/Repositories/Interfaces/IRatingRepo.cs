using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Infrastructure.Repositories.Interfaces
{
    public interface IRatingRepo
    {
        Task<List<Usuarios>> ListarUsuariosPorRating();
        Task<Usuarios?> ConsultarUsuarioNoRanking(int id);
        Task<Usuarios?> ConsultarDesempenhoUsuarios(int id);
        Task<List<HistoricoRating>> ConsultarHistoricoDesempenho(int id);
    }
}