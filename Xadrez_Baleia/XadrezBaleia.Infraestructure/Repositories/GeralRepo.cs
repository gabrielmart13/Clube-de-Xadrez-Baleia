using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;

namespace XadrezBaleia.Infraestructure.Repositories
{
    public class GeralRepo : IGeralRepo
    {
        private readonly DataContext _context;

        public GeralRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<T> Adicionar<T>(T entity) where T : class
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Atualizar<T>(T entity) where T : class
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;

        }

        public async Task<T?> PegarPorId<T>(int id) where T : class
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;
            
        }

        public async Task<List<T>> PegarTodos<T>() where T : class
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> Remover<T>(T entity) where T : class
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
