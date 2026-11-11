using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infrastructure;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class PartidasRepo : IPartidasRepo
    {
        private readonly DataContext _context;

        public PartidasRepo(DataContext context)
        {
            _context = context;
        }
        public Task<List<Partidas>> ConsultarPartidasJogador(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CorrigirPartida(int id, Partidas partida)
        {
            throw new NotImplementedException();
        }

        public Task<List<Partidas>> ListarPartidas()
        {
            throw new NotImplementedException();
        }

        public Task<Partidas> RegistrarPartida(Partidas partida)
        {
            throw new NotImplementedException();
        }
    }
}
