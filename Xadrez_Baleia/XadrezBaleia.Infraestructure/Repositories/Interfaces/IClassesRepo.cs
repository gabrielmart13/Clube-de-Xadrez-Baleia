using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Infrastructure.Repositories.Interfaces
{
    public interface IClassesRepo
    {
        Task<List<Classes>> ListarTurmasDisponiveis();
        Task<List<ClassEnrollments>> ListarAlunosMatriculados(int id);
        Task<ClassEnrollments> SolicitarIngresso(int turmaId, int usuarioId);
        Task<bool> CancelarIngresso(int turmaId, int usuarioId);
        Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId);
        Task<bool> RemoverAluno(int turmaId, int usuarioId);
    }
}