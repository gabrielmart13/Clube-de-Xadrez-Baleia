using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Infraestructure.Repositories.Interfaces
{
    public interface IEventRepo
    {
        Task<List<Eventos?>> ListarEventosDisponiveis();
        Task<EventRegistros> InscreverUsuario(int eventoid, int usuarioid);
        Task<bool> CancelarInscricao(int eventoid, int usuarioid);
        Task<List<EventRegistros>> ListarInscritos(int eventoid);
        Task <List<EventRegistros>> ListarMinhasInscricoes(int usuarioid);

    }
}