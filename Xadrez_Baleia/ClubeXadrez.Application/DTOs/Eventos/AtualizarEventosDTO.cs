using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Eventos
{
    public class AtualizarEventosDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraTermino { get; set; }
        public string Local { get; set; } = string.Empty;
        public int? LimiteParticipantes { get; set; }
        public DateTime? PrazoInscricao { get; set; }
        public string Status { get; set; } = string.Empty;
        public bool ContabilizaRating { get; set; }
        public string? RitmoDeJogo { get; set; }
        public int? NumeroDeRodadas { get; set; }
        public string? SistemaEmparceiramento { get; set; }
    }
}
