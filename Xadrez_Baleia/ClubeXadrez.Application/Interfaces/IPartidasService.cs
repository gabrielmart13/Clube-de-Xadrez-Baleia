using XadrezBaleia.Application.DTOs.Partidas;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IPartidasService
    {
        Task<VisualizarPartidaDTo> RegistrarPartida(CriarPartidaDTO partida);
        Task<List<VisualizarPartidaDTo>> ListarPartidas();
        Task<bool> CorrigirPartida(int id);
    }
}