using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Usuarios
{
    public class AtualizarSenhaDTO
    {
        public string SenhaAtual { get; set; } = string.Empty;
        public string NovaSenha { get; set; } = string.Empty;
    }
}
