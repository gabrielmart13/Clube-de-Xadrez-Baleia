using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XadrezBaleia.Domain.Models
{
    public class EventImagens
    {
        [Key]
        public int Id { get; set; }
        public int EventoId { get; set; }

        [ForeignKey(nameof(EventoId))]
        public Eventos? Evento { get; set; }
        public string NomeArquivo { get; set; } = string.Empty;
        public string CaminhoArquivo { get; set; } = string.Empty;
        public string TipoArquivo { get; set; } = string.Empty;
        public long TamanhoBytes { get; set; }
        public int EnviadoPorId { get; set; }

        [ForeignKey(nameof(EnviadoPorId))]
        public Usuarios? EnviadoPor { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}