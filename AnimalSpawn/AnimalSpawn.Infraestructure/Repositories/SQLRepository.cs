using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using AnimalSpawn.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class SQLRepository<T> : IRespository<T> where T: BaseEntity
    {
        private readonly AnimalSpawnContext _context;
        private readonly DbSet<T> _entities;
        public SQLRepository(AnimalSpawnContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");

           await _entities.AddAsync(entity);
            //await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            if (id <= 0) throw new ArgumentNullException("Entity");

            var entity = await GetById(id);

            _entities.Remove(entity);
           // await _context.SaveChangesAsync();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return  _entities.Where(expression).AsNoTracking().AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return  _entities.AsNoTracking().AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");

            if (entity.Id <= 0) throw new ArgumentNullException("Entity");

            _entities.Update(entity);
           // await _context.SaveChangesAsync();
        }
    }
}
