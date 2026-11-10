using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;

namespace XadrezBaleia.Application.Services
{
    public class AutenticationService : IAutenticationService
    {
        private readonly GeralRepo _geralrepo;

        public AutenticationService(GeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }
        public Task<Usuarios> ConsultarDados()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> LogarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> RegistrarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
