using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class AutenticationService : IAutenticationService
    {
        private readonly IGeralRepo _geralrepo;

        public AutenticationService(IGeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }

        public Task<VisualizarUsuariosDTO> ConsultarDados()
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO> LogarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO> RegistrarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
