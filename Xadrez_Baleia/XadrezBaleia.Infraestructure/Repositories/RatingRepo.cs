
using Microsoft.EntityFrameworkCore;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infrastructure;
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

        // Consultar os dados de desempenho de um usuário
        public async Task<Usuarios?> ConsultarDesempenhoUsuarios(int id)
        {
            var ratingusuario = await _context.Usuarios.FindAsync(id);
            return ratingusuario;
        }

        // Consultar o histórico de rating de um usuário
        public async Task<List<HistoricoRating>> ConsultarHistoricoDesempenho(int id)
        {
            var historicos = await _context.HistoricoRating.ToListAsync();

            List<HistoricoRating> historicoUsuario = new List<HistoricoRating>();

            foreach (HistoricoRating h in historicos)
            {
                if (h.UsuarioId == id)
                {
                    historicoUsuario.Add(h);
                }
            }

            return historicoUsuario;
        }

        // Consultar um usuário específico no ranking
        public async Task<Usuarios?> ConsultarUsuarioNoRanking(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            return usuario;
        }

        // Listar todos os usuários ordenados pelo rating
        public async Task<List<Usuarios>> ListarUsuariosPorRating()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            usuarios.Sort((a, b) => b.Rating.CompareTo(a.Rating));

            return usuarios;
        }
    }
}
