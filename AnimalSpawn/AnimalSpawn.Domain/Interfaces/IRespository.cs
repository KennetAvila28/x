using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IRespository<T> where T : BaseEntity
    {
        Task Add(T entity);
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> GetById(int id);
        IEnumerable<T> GetAll();
        Task Delete(int id);
        void Update(T entity);
        //IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter);
    }
}
