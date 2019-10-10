using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class GebruikerRepo : IGebruikerRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Gebruiker> _gebruikers;

        public GebruikerRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _gebruikers = dbContext.Gebruikers;
        }

        public void Add(Gebruiker obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Gebruiker> GetAll()
        {
            throw new NotImplementedException();
        }

        public Gebruiker GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Gebruiker obj)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
