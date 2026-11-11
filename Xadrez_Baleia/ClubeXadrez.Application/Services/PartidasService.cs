using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Partidas;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class PartidasService : IPartidasService
    {
        private readonly IGeralRepo _geralrepo;
        private readonly IPartidasRepo _partidasrepo;

        public PartidasService(IGeralRepo geralRepo,IPartidasRepo partidasRepo)
        {
            _geralrepo = geralRepo;
            _partidasrepo = partidasRepo;
        }

        public Task<bool> CorrigirPartida(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarPartidaDTo>> ListarPartidas()
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarPartidaDTo> RegistrarPartida(CriarPartidaDTO partida)
        {
            throw new NotImplementedException();
        }
    }
}
