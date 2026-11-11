using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Application.DTOs.ClassEnrollments;
using XadrezBaleia.Application.DTOs.Classes;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Application.Services
{
    public class TurmasService : ITurmasService
    {
        private readonly IGeralRepo _geralrepo;
        private readonly IClassesRepo _classesrepo;

        public TurmasService(IGeralRepo geralRepo, IClassesRepo classesrepo)
        {
            _geralrepo = geralRepo;
            _classesrepo = classesrepo;
        }

        public Task<bool> AtualizarTurma(int id, AtualizarClasseDTO classe)
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

        public Task<VisualizarClassesDTO?> ConsultarTurma(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarClassesDTO> CriarTurma(CriarClasseDTO classe)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DesativarTurma(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VisualizarSolicitacaoDTO>> ListarAlunosTurma(int turmaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverAluno(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<VisualizarSolicitacaoDTO> SolicitarIngresso(int turmaId, int usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
