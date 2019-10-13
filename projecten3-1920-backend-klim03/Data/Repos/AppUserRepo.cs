using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class AppUserRepo : IAppUserRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<AppUser> _appUsers;

        public AppUserRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _appUsers = dbContext.AppUsers;
        }

        public void Add(AppUser obj)
        {
            _appUsers.Add(obj);
        }

        public ICollection<AppUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(AppUser obj)
        {
            _appUsers.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
