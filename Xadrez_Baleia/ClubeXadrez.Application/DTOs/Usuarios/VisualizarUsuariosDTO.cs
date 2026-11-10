using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Usuarios
{
    public class VisualizarUsuariosDTO
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string RegistroEscoteiro { get; set; } = string.Empty;
        public string Ramo { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Papel { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
