using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.Usuarios;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface IAdministradoresService
    {
        Task<VisualizarUsuariosDTO> PegarAdmin(int id);
        Task <List<VisualizarUsuariosDTO>> PegarTodosAdmin();
        Task<VisualizarUsuariosDTO> CriarAdmin(CriarUsuariosDTO usuario);
        Task<VisualizarUsuariosDTO> AtualizarAdmin(int id, AtualizarUsuariosDTO usuario);
        Task<bool> ExcluirAdmin(int id);
    }
}
