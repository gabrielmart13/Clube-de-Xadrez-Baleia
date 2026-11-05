using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Services
{
    public class AdministradoresService : IAdministradoresService
    {
        public Task<Usuarios> AtualizarAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> CriarAdmin()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> ExcluirAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> PegarAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuarios>> PegarTodosAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
