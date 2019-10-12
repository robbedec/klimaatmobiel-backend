using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class ToepassingsGebiedRepo : IToepassingsGebiedRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<ToepassingsGebied> _tgs;

        public ToepassingsGebiedRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _tgs = dbContext.ToepassingsGebieden;
        }

        public void Add(ToepassingsGebied obj)
        {
            _tgs.Add(obj);
        }

        public ICollection<ToepassingsGebied> GetAll()
        {
            throw new NotImplementedException();
        }

        public ToepassingsGebied GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ToepassingsGebied obj)
        {
            _tgs.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
