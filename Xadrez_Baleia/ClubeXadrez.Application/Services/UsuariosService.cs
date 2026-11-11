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

    public class UsuariosService : IUsuariosService
    {
        private readonly IGeralRepo _geralrepo;

        public UsuariosService(IGeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }

        public Task<VisualizarUsuariosDTO> AtualizarUsuarioProprio(AtualizarUsuariosDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarUsuariosDTO>> PegarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO?> PegarUsuarioProprio(int id)
        {
            throw new NotImplementedException();
        }
    }
}
