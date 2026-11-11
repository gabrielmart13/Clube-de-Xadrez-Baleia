
using Microsoft.EntityFrameworkCore;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infrastructure;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class ClassesRepo : IClassesRepo
    {
        private readonly DataContext _context;

        public ClassesRepo(DataContext context)
        {
            _context = context;
        }

        // Cancelar ingresso de um usuário em uma turma
        public async Task<bool> CancelarIngresso(int turmaId, int usuarioId)
        {
            var turmas = await _context.Classes.ToListAsync();
            var inscricoes = await _context.ClassEnrollments.ToListAsync();

            foreach (var t in turmas)
            {
                if (t.Id == turmaId)
                {
                    foreach (var i in inscricoes)
                    {
                        if (i.UsuarioId == usuarioId && i.ClassesId == t.Id &&
                            i.Status != "Cancelado")
                        {
                            i.Status = "Cancelado";
                            i.DataAtualizacao = DateTime.Now;

                            await _context.SaveChangesAsync();

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        // Consultar posição de um usuário na fila de espera
        public async Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId)
        {
            var inscricoes = await _context.ClassEnrollments.ToListAsync();

            ClassEnrollments? inscricaoUsuario = null;

            foreach (var i in inscricoes)
            {
                if (i.ClassesId == turmaId &&
                    i.UsuarioId == usuarioId &&
                    i.Status == "Aguardando")
                {
                    inscricaoUsuario = i;
                    break;
                }
            }

            if (inscricaoUsuario == null)
                return null;

            int posicao = 1;

            foreach (var i in inscricoes)
            {
                if (i.ClassesId == turmaId &&
                    i.Status == "Aguardando" &&
                    i.DataSolicitacao < inscricaoUsuario.DataSolicitacao)
                {
                    posicao++;
                }
            }

            return posicao;
        }

        // Listar alunos matriculados e pessoas na fila de espera
        public async Task<List<ClassEnrollments>> ListarAlunosMatriculados(int id)
        {
            var inscricoes = await _context.ClassEnrollments.ToListAsync();

            List<ClassEnrollments> alunos = new List<ClassEnrollments>();

            foreach (var i in inscricoes)
            {
                if (i.ClassesId == id && i.Status != "Cancelado")
                {
                    alunos.Add(i);
                }
            }

            return alunos;
        }

        // Listar todas as turmas disponíveis
        public async Task<List<Classes>> ListarTurmasDisponiveis()
        {
            var turmas = await _context.Classes.ToListAsync();

            List<Classes> disponiveis = new List<Classes>();

            foreach (var t in turmas)
            {
                if (t.Ativa)
                {
                    disponiveis.Add(t);
                }
            }

            return disponiveis;
        }

        // Remover um aluno de uma turma (cancelamento administrativo)
        public async Task<bool> RemoverAluno(int turmaId, int usuarioId)
        {
            var turmas = await _context.Classes.ToListAsync();
            var inscricoes = await _context.ClassEnrollments.ToListAsync();

            foreach (var t in turmas)
            {
                if (t.Id == turmaId)
                {
                    foreach (var i in inscricoes)
                    {
                        if (i.ClassesId == t.Id &&
                            i.UsuarioId == usuarioId &&
                            i.Status != "Cancelado")
                        {
                            i.Status = "Cancelado";
                            i.DataAtualizacao = DateTime.Now;

                            await _context.SaveChangesAsync();

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        // Solicitar ingresso em uma turma
        public async Task<ClassEnrollments> SolicitarIngresso(int turmaId, int usuarioId)
        {
            var turmas = await _context.Classes.ToListAsync();
            var usuarios = await _context.Usuarios.ToListAsync();
            var inscricoes = await _context.ClassEnrollments.ToListAsync();

            ClassEnrollments inscricao = new ClassEnrollments();

            foreach (var u in usuarios)
            {
                if (u.Id == usuarioId)
                {
                    foreach (var t in turmas)
                    {
                        if (t.Id == turmaId && t.Ativa)
                        {
                            // Verificar se o usuário já possui uma inscrição ativa
                            foreach (var i in inscricoes)
                            {
                                if (i.UsuarioId == usuarioId &&
                                    i.ClassesId == turmaId &&
                                    i.Status != "Cancelado")
                                {
                                    return null!;
                                }
                            }

                            int matriculados = 0;

                            // Contar alunos já matriculados
                            foreach (var i in inscricoes)
                            {
                                if (i.ClassesId == turmaId &&
                                    i.Status == "Matriculado")
                                {
                                    matriculados++;
                                }
                            }

                            inscricao.UsuarioId = u.Id;
                            inscricao.ClassesId = t.Id;
                            inscricao.DataSolicitacao = DateTime.Now;
                            inscricao.Status = matriculados < t.CapacidadeMaxima
                                ? "Matriculado"
                                : "Aguardando";

                            _context.ClassEnrollments.Add(inscricao);
                            await _context.SaveChangesAsync();

                            return inscricao;
                        }
                    }
                }
            }

            return null!;
        }
    }
}
