using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;
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
        public Task<bool> CancelarIngresso(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassEnrollments>> ListarAlunosMatriculados(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Classes>> ListarTurmasDisponiveis()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverAluno(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<ClassEnrollments> SolicitarIngresso(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
