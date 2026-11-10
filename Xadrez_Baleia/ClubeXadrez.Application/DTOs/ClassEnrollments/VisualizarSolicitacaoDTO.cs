using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezBaleia.Application.DTOs.ClassEnrollments
{
    public class VisualizarSolicitacaoDTO
    {
        public int ClassesId { get; }
        public int UsuarioId { get; }
        public string Status { get; }
    }
}
