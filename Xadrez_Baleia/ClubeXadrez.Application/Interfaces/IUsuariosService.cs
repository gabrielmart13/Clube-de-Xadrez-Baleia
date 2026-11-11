using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IUsuariosService
    {
        Task<List<VisualizarUsuariosDTO>> PegarTodos();
        Task<VisualizarUsuariosDTO?> PegarUsuarioProprio(int id);
        Task<VisualizarUsuariosDTO> AtualizarUsuarioProprio(AtualizarUsuariosDTO usuario);
    }
}
