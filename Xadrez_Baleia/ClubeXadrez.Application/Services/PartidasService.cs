using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;

namespace XadrezBaleia.Application.Services
{
    public class PartidasService : IPartidasService
    {
        private readonly GeralRepo _geralrepo;

        public PartidasService(GeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }
        public Task<bool> CorrigirPartida(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Partidas>> ListarPartidas()
        {
            throw new NotImplementedException();
        }

        public Task<Partidas> RegistrarPartida()
        {
            throw new NotImplementedException();
        }
    }
}
