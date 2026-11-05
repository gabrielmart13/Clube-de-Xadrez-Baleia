using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class HistoricoRating
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuarios? Usuario { get; set; }
        public int PartidaId { get; set; }

        [ForeignKey(nameof(PartidaId))]
        public Partidas? Partida { get; set; }
        public int RatingAnterior { get; set; }
        public int Variacao { get; set; }
        public int RatingPosterior { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}