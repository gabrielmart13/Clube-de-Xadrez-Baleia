using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.ClassEnrollments;
using XadrezBaleia.Application.DTOs.Classes;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface ITurmasService
    {
        Task<VisualizarClassesDTO?> ConsultarTurma(int id);
        Task<VisualizarClassesDTO> CriarTurma(CriarClasseDTO classe);
        Task<bool> AtualizarTurma(int id, AtualizarClasseDTO classe); 
        Task<bool> DesativarTurma(int id);
        Task<List<VisualizarSolicitacaoDTO>> ListarAlunosTurma(int turmaId);
        Task<VisualizarSolicitacaoDTO> SolicitarIngresso(int turmaId, int usuarioId);
        Task<bool> CancelarIngresso(int turmaId, int usuarioId);
        Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId);
        Task<bool> RemoverAluno(int turmaId, int usuarioId);
    }
}
