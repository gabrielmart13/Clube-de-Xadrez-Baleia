using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Infrastructure.Repositories.Interfaces
{
    public interface IPartidasRepo
    {
        Task<Partidas> RegistrarPartida(Partidas partida);
        Task<List<Partidas>> ListarPartidas();
        Task<List<Partidas>> ConsultarPartidasJogador(int id);
        Task<bool> CorrigirPartida(int id, Partidas partida);
    }
}