using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int CapacidadeMaxima { get; set; }
        public DayOfWeek DiaDaSemana { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioTermino { get; set; }

        public int InstrutorId { get; set; }

        [ForeignKey(nameof(InstrutorId))]
        public Usuarios? Instrutor { get; set; }

        public bool Ativa { get; set; }
    }
}