using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Services
{
    public class RatingService : IRatingService
    {
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
