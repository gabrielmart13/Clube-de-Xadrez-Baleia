using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.HistoricoRating
{
    public class CriarHistoricoRatingDTO
    {
        public int UsuarioId { get; set; }
        public int PartidaId { get; set; }
        public int RatingAnterior { get; set; }
        public int Variacao { get; set; }
        public int RatingPosterior { get; set; }
    }
}
