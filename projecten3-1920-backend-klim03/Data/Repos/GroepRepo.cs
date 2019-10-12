using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class GroepRepo : IGroepRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Groep> _groepen;

        public GroepRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _groepen = dbContext.Groepen;
        }

        public void Add(Groep obj)
        {
            _groepen.Add(obj);
        }

        public ICollection<Groep> GetAll()
        {
            return _groepen.ToList();
        }

        public Groep GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Groep obj)
        {
            _groepen.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
