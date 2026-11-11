using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class AdministradoresService : IAdministradoresService
    {
        private readonly IGeralRepo _geralrepo;
        
        public AdministradoresService(IGeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }

        public Task<VisualizarUsuariosDTO> AtualizarAdmin(int id, AtualizarUsuariosDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO> CriarAdmin(CriarUsuariosDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarUsuariosDTO> PegarAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarUsuariosDTO>> PegarTodosAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
