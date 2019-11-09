using projecten3_1920_backend_klim03.Domain.Models;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class PupilRepo : IPupilRepo
    {

        /*private readonly ApplicationDbContext _context;
        private readonly DbSet<OrderItem> _orderItems;

        public OrderItemRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _orderItems = dbContext.OrderItems;
        }*/


        public void Add(Pupil obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pupil> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pupil GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool PupilExists(string voornaam, string achternaam)
        {
            throw new NotImplementedException();
        }

        public void Remove(Pupil obj)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
