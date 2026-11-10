using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.Partidas
{
    public class VisualizarPartidaDTo
    {
        public int Id { get; set; }

        public int JogadorBrancasId { get; set; }
        public string? NomeJogadorBrancas { get; set; }

        public int JogadorPretasId { get; set; }
        public string? NomeJogadorPretas { get; set; }

        public int? EventoId { get; set; }
        public string? TituloEvento { get; set; }

        public DateTime DataPartida { get; set; }
        public string Resultado { get; set; } = string.Empty;

        public int RegistradoPorId { get; set; }
        public string? NomeRegistrador { get; set; }
    }
}
