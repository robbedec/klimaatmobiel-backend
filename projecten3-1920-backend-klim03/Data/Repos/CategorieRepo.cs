using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class CategorieRepo : ICategorieRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Categorie> _categorieen;

        public CategorieRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _categorieen = dbContext.Categorieen;
        }

        public void Add(Categorie obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Categorie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categorie GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Categorie obj)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
