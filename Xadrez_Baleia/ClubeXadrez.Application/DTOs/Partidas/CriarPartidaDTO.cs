using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Partidas
{
    public class CriarPartidaDTO
    {
        public int JogadorBrancasId { get; set; }
        public int JogadorPretasId { get; set; }
        public int? EventoId { get; set; }
        public DateTime DataPartida { get; set; }
        public string Resultado { get; set; } = string.Empty;
    }
}
