using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IAnimalRepository : IRespository<Animal>
    {
        IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter);
    }
}
