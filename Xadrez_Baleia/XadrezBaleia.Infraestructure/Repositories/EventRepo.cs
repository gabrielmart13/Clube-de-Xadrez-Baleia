using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class EventRepo : IEventRepo
    {
        private readonly DataContext _context;

        public EventRepo(DataContext context)
        {
            _context = context;
        }
        public Task<bool> CancelarInscricao(int eventoid, int usuarioid)
        {
            throw new NotImplementedException();
        }

        public Task<EventRegistros> InscreverUsuario(int eventoid, int usuarioid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Eventos?>> ListarEventosDisponiveis()
        {
            throw new NotImplementedException();
        }

        public Task<List<EventRegistros>> ListarInscritos(int eventoid)
        {
            throw new NotImplementedException();
        }

        public Task<List<EventRegistros>> ListarMinhasInscricoes(int usuarioid)
        {
            throw new NotImplementedException();
        }
    }
}
