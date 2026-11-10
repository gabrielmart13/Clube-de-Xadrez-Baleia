using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;

namespace XadrezBaleia.Application.Services
{
    public class EventosServices : IEventosService
    {
        private readonly GeralRepo _geralrepo;

        public EventosService(GeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }
        public Task<bool> AtualizarEvento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelarEvento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelarInscricao(int eventoId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<Eventos?> ConsultarEvento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Eventos> CriarEvento()
        {
            throw new NotImplementedException();
        }

        public Task<EventRegistros> InscreverUsuario(int eventoId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Eventos>> ListarEventos()
        {
            throw new NotImplementedException();
        }

        public Task<List<EventRegistros>> ListarInscritos(int eventoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<EventRegistros>> ListarMinhasInscricoes(int usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
