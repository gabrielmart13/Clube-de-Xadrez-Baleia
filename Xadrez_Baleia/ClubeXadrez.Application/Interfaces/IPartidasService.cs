using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IPartidasService
    {
        Task<Partidas> RegistrarPartida();
        Task<List<Partidas>> ListarPartidas();
        Task<bool> CorrigirPartida(int id);
    }
}