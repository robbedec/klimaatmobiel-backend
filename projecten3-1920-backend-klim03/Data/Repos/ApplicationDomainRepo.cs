using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class ApplicationDomainRepo : IApplicationDomainRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<ApplicationDomain> _applicationDomains;

        public ApplicationDomainRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _applicationDomains = dbContext.ApplicationDomains;
        }

        public void Add(ApplicationDomain obj)
        {
            _applicationDomains.Add(obj);
        }

        public ICollection<ApplicationDomain> GetAll()
        {
            throw new NotImplementedException();
        }

        public ApplicationDomain GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ApplicationDomain obj)
        {
            _applicationDomains.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
