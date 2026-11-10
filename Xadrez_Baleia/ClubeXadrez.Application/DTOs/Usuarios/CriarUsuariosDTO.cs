using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Usuarios
{
    public class CriarUsuariosDTO
    {
        public string NomeCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string RegistroEscoteiro { get; set; } = string.Empty;
        public string Ramo { get; set; } = string.Empty;
        public string Papel { get; set; } = string.Empty;
    }
}
