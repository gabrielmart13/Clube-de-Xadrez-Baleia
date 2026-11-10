using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.EventRegistros
{
    public class VisualizarEventRegistrosDTO
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public string? NomeUsuario { get; set; }

        public int EventoId { get; set; }
        public string? TituloEvento { get; set; }

        public string Status { get; set; } = string.Empty;
        public DateTime DataInscricao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
