using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;

namespace XadrezBaleia.Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly GeralRepo _geralrepo;

        public RatingService(GeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }
        public Task<List<HistoricoRating>> ConsultarDesempenhoProprio()
        {
            throw new NotImplementedException();
        }

        public Task<List<Partidas>> ConsultarHistoricoPartidas()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> ConsultarRatingProprio()
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuarios>> ListarTodosRating()
        {
            throw new NotImplementedException();
        }
    }
}
