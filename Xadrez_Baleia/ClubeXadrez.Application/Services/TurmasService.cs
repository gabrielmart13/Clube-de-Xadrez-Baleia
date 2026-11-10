using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;

namespace XadrezBaleia.Application.Services
{
    public class TurmasService : ITurmasService
    {
        private readonly GeralRepo _geralrepo;

        public TurmasService(GeralRepo geralRepo)
        {
            _geralrepo = geralRepo;
        }
        public Task<bool> AtualizarTurma(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelarIngresso(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<int?> ConsultarPosicaoFila(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<Classes?> ConsultarTurma(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Classes> CriarTurma()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DesativarTurma(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassEnrollments>> ListarAlunosTurma(int turmaId)
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
