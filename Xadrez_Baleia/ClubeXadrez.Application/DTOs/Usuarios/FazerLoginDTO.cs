using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Usuarios
{
    public class FazerLoginDTO
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
