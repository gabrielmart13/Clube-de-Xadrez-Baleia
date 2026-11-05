using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class Partidas
    {
        [Key]
        public int Id { get; set; }
        public int JogadorBrancasId { get; set; }

        [ForeignKey(nameof(JogadorBrancasId))]
        public Usuarios? JogadorBrancas { get; set; }
        public int JogadorPretasId { get; set; }

        [ForeignKey(nameof(JogadorPretasId))]
        public Usuarios? JogadorPretas { get; set; }
        public int? EventoId { get; set; }

        [ForeignKey(nameof(EventoId))]
        public Eventos? Evento { get; set; }
        public DateTime DataPartida { get; set; }
        public string Resultado { get; set; } = string.Empty;
        public int RegistradoPorId { get; set; }

        [ForeignKey(nameof(RegistradoPorId))]
        public Usuarios? RegistradoPor { get; set; }
        public bool ContabilizadaNoRating { get; set; }
    }
}