using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly AnimalSpawnContext _context;
        public UnitOfWork(AnimalSpawnContext context)
        {
            this._context = context;
        }

        private readonly IAnimalRepository _animalRepository;
        private readonly IRespository<Country> _countryRepository;
        private readonly IRespository<Family> _familyRepository;
        private readonly IRespository<Genus>  _genusRepository;
        private readonly IRespository<Photo>  _photoRepository;
        private readonly IRespository<ProtectedArea> _protectedAreaRepository;
        private readonly IRespository<Researcher> _researcherRepository;
        private readonly IRespository<RfidTag> _rfidTagRepository;
        private readonly IRespository<Sighting> _sightingRepository;
        private readonly IRespository<Species> _speciesRepository;
        private readonly IRespository<UserAccount> _userAccountRepository;


        public IAnimalRepository AnimalRepository => _animalRepository ??  new AnimalRepository(_context);

        public IRespository<Country> CountryRepository => _countryRepository ?? new SQLRepository<Country>(_context);

        public IRespository<Family> FamilyRepository => _familyRepository ?? new SQLRepository<Family>(_context);

        public IRespository<Genus> GenusRepository => _genusRepository ?? new SQLRepository<Genus>(_context);

        public IRespository<Photo> PhotoRepository => _photoRepository ?? new SQLRepository<Photo>(_context);

        public IRespository<ProtectedArea> ProtectedAreaRepository => _protectedAreaRepository ?? new SQLRepository<ProtectedArea>(_context);

        public IRespository<Researcher> ResearcherRepository => _researcherRepository ?? new SQLRepository<Researcher>(_context);

        public IRespository<RfidTag> RfidTagRepository => _rfidTagRepository ?? new SQLRepository<RfidTag>(_context);

        public IRespository<Sighting> SightingRepository => _sightingRepository ?? new SQLRepository<Sighting>(_context);

        public IRespository<Species> SpeciesRepository => _speciesRepository ?? new SQLRepository<Species>(_context);

        public IRespository<UserAccount> UserAccountRepository => _userAccountRepository ?? new SQLRepository<UserAccount>(_context);

        public void Dispose()
        {
            if (_context == null)
                _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
