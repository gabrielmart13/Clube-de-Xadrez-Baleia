using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class EventRegistros
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuarios? Usuario { get; set; }
        public int EventoId { get; set; }

        [ForeignKey(nameof(EventoId))]
        public Eventos? Evento { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime DataInscricao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}