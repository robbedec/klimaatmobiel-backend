using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class KlasRepo : IKlasRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Klas> _klassen;

        public KlasRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _klassen = dbContext.Klassen;
        }

        public void Add(Klas obj)
        {
            _klassen.Add(obj);
        }

        public ICollection<Klas> GetAll()
        {
            throw new NotImplementedException();
        }

        public Klas GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Klas obj)
        {
            _klassen.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
