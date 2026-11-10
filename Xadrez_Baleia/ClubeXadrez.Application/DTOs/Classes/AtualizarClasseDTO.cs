using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Classes
{
    public class AtualizarClasseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int CapacidadeMaxima { get; set; }
        public DayOfWeek DiaDaSemana { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioTermino { get; set; }
        public int InstrutorId { get; set; }
        public bool Ativa { get; set; }
    }
}
