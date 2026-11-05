using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IAutenticationService
    {
        Task<Usuarios> RegistrarUsuario();
        Task<Usuarios> LogarUsuario();
        Task<Usuarios> ConsultarDados();
    }
}
