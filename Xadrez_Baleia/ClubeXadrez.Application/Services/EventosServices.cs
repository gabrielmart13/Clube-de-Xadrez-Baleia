using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Eventos;
using XadrezBaleia.Application.DTOs.EventRegistros;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class EventosService : IEventosService
    {
        private readonly IGeralRepo _geralrepo;
        private readonly IEventRepo _eventrepo;

        public EventosService(IGeralRepo geralRepo, IEventRepo eventRepo)
        {
            _geralrepo = geralRepo;
            _eventrepo = eventRepo;
        }

        public Task<bool> AtualizarEvento(int id, AtualizarEventosDTO evento)
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

        public Task<VisualizarEventosDTO?> ConsultarEvento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarEventosDTO> CriarEvento(CriarEventosDTO evento)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarEventRegistrosDTO> InscreverUsuario(int eventoId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarEventosDTO>> ListarEventos()
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarEventRegistrosDTO>> ListarInscritos(int eventoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarEventRegistrosDTO>> ListarMinhasInscricoes(int usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
