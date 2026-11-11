using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IAutenticationService
    {
        Task<VisualizarUsuariosDTO> RegistrarUsuario();
        Task<VisualizarUsuariosDTO> LogarUsuario();
        Task<VisualizarUsuariosDTO> ConsultarDados();
    }
}
