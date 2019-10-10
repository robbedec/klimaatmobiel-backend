using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Project> _projecten;

        public ProjectRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _projecten = dbContext.Projecten;
        }

        public void Add(Project obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Project obj)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
