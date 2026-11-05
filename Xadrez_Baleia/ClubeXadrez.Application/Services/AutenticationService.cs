using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Services
{
    public class AutenticationService : IAutenticationService
    {
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
