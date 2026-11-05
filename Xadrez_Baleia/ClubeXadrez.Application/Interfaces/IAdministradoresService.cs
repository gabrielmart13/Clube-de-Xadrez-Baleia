using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IAdministradoresService
    {
        Task<Usuarios> PegarAdmin(int id);
        Task <List<Usuarios>> PegarTodosAdmin();
        Task<Usuarios> CriarAdmin();
        Task<Usuarios> AtualizarAdmin(int id);
        Task<Usuarios> ExcluirAdmin(int id);
    }
}
