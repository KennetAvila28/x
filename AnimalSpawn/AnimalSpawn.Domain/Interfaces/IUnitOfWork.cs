using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IAnimalRepository AnimalRepository { get; }
        public IRespository<Country> CountryRepository { get; }
        public IRespository<Family> FamilyRepository { get; }
        public IRespository<Genus> GenusRepository { get; }
        public IRespository<Photo> PhotoRepository { get; }
        public IRespository<ProtectedArea> ProtectedAreaRepository { get; }
        public IRespository<Researcher> ResearcherRepository { get; }
        public IRespository<RfidTag> RfidTagRepository { get; }
        public IRespository<Sighting> SightingRepository { get; }
        public IRespository<Species> SpeciesRepository { get; }
        public IRespository<UserAccount> UserAccountRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();

        
    }
}
