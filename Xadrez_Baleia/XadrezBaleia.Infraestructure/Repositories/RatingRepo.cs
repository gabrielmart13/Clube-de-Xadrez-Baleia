using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class RatingRepo : IRatingRepo
    {
        private readonly DataContext _context;

        public RatingRepo(DataContext context)
        {
            _context = context;
        }
        public Task<Usuarios?> ConsultarDesempenhoUsuarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HistoricoRating>> ConsultarHistoricoDesempenho(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios?> ConsultarUsuarioNoRanking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuarios>> ListarUsuariosPorRating()
        {
            throw new NotImplementedException();
        }
    }
}
