using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IUsuariosService
    {
        Task<Usuarios> PegarTodos();
        Task<Usuarios> PegarUsuarioProprio();
        Task<Usuarios> AtualizarUsuarioProprio();
    }
}
