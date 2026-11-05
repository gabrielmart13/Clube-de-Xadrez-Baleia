using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class ClassEnrollments
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuarios? Usuario { get; set; }

        public int TurmaId { get; set; }

        [ForeignKey(nameof(TurmaId))]
        public Classes? Turma { get; set; }

        public string Status { get; set; } = string.Empty;
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}