using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.HistoricoRating
{
    public class VisualizarHistoricoRatingDTO
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public string? NomeUsuario { get; set; }

        public int PartidaId { get; set; }
        public string ResultadoPartida { get; set; } = string.Empty;
        public DateTime DataPartida { get; set; }

        public int RatingAnterior { get; set; }
        public int Variacao { get; set; }
        public int RatingPosterior { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
