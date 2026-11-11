
using Microsoft.EntityFrameworkCore;
using XadrezBaleia.Domain.Models;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;
using XadrezBaleia.Infrastructure;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class EventRepo : IEventRepo
    {
        private readonly DataContext _context;

        public EventRepo(DataContext context)
        {
            _context = context;
        }

        // Cancelar inscrição de um usuário em um evento
        public async Task<bool> CancelarInscricao(int eventoid, int usuarioid)
        {
            var eventos = await _context.Eventos.ToListAsync();
            var usuarios = await _context.Usuarios.ToListAsync();
            var inscricoes = await _context.EventRegistros.ToListAsync();

            foreach (Usuarios u in usuarios)
            {
                if (u.Id == usuarioid)
                {
                    foreach (Eventos e in eventos)
                    {
                        if (e.Id == eventoid)
                        {
                            foreach (EventRegistros inscricao in inscricoes)
                            {
                                if (inscricao.UsuarioId == u.Id &&
                                    inscricao.EventoId == e.Id)
                                {
                                    _context.EventRegistros.Remove(inscricao);
                                    await _context.SaveChangesAsync();

                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        // Inscrever um usuário em um evento
        public async Task<EventRegistros> InscreverUsuario(int eventoid, int usuarioid)
        {
            var eventos = await _context.Eventos.ToListAsync();
            var usuarios = await _context.Usuarios.ToListAsync();

            EventRegistros inscricao = new EventRegistros();

            foreach (Usuarios u in usuarios)
            {
                if (u.Id == usuarioid)
                {
                    foreach (Eventos e in eventos)
                    {
                        if (e.Id == eventoid)
                        {
                            inscricao.UsuarioId = u.Id;
                            inscricao.EventoId = e.Id;
                            inscricao.DataInscricao = DateTime.Now;
                            inscricao.Status = "inscrito";

                            _context.EventRegistros.Add(inscricao);
                            await _context.SaveChangesAsync();

                            return inscricao;
                        }
                    }
                }
            }

            return null!;
        }

        // Listar eventos disponíveis
        public async Task<List<Eventos?>> ListarEventosDisponiveis()
        {
            var eventos = await _context.Eventos.ToListAsync();

            List<Eventos> disponiveis = new List<Eventos>();

            foreach (Eventos e in eventos)
            {
                if (e.Status == "Aberto")
                {
                    disponiveis.Add(e);
                }
            }

            return disponiveis;
        }

        // Listar inscritos em um evento
        public async Task<List<EventRegistros>> ListarInscritos(int eventoid)
        {
            var eventosregistros = await _context.EventRegistros.ToListAsync();

            List<EventRegistros> inscritos = new List<EventRegistros>();

            foreach (EventRegistros er in eventosregistros)
            {
                if (er.EventoId == eventoid)
                {
                    inscritos.Add(er);
                }
            }

            return inscritos;
        }

        // Listar inscrições de um usuário
        public async Task<List<EventRegistros>> ListarMinhasInscricoes(int usuarioid)
        {
            var eventosregistros = await _context.EventRegistros.ToListAsync();

            List<EventRegistros> inscricoes = new List<EventRegistros>();

            foreach (EventRegistros er in eventosregistros)
            {
                if (er.UsuarioId == usuarioid)
                {
                    inscricoes.Add(er);
                }
            }

            return inscricoes;
        }
    }
}
