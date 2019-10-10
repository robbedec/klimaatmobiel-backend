using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<School> _scholen;

        public SchoolRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _scholen = dbContext.Scholen;
        }

        public void Add(School obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<School> GetAll()
        {
            throw new NotImplementedException();
        }

        public School GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(School obj)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
