using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Application.Interfaces
{
    public interface ITurmasService
    {
        Task<Classes?> ConsultarTurma(int id);
        Task<Classes> CriarTurma();
        Task<bool> AtualizarTurma(int id);
        Task<bool> DesativarTurma(int id);
        Task<List<ClassEnrollments>> ListarAlunosTurma(int turmaId);
        Task<ClassEnrollments> SolicitarIngresso(int turmaId, int usuarioId);
        Task<bool> CancelarIngresso(int turmaId, int usuarioId);
        Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId);
        Task<bool> RemoverAluno(int turmaId, int usuarioId);
    }
}
