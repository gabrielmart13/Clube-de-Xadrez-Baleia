using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.HistoricoRating;
using XadrezBaleia.Application.DTOs.Partidas;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly IGeralRepo _geralrepo;
        private readonly IRatingRepo _ratingrepo;

        public RatingService(IGeralRepo geralRepo, IRatingRepo ratingrepo)
        {
            _geralrepo = geralRepo;
            _ratingrepo = ratingrepo;
        }

        public Task<List<VisualizarHistoricoRatingDTO>> ConsultarDesempenhoProprio(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarPartidaDTo>> ConsultarHistoricoPartidas()
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO> ConsultarRatingProprio(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarUsuariosDTO>> ListarTodosRating()
        {
            throw new NotImplementedException();
        }
    }
}
