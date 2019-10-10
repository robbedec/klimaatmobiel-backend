using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class BestellingRepo : IBestellingRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Bestelling> _bestellingen;

        public BestellingRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _bestellingen = dbContext.Bestellingen;
        }

        public void Add(Bestelling obj)
        {
            _bestellingen.Add(obj);
        }

        public ICollection<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bestelling GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Bestelling obj)
        {
            _bestellingen.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
