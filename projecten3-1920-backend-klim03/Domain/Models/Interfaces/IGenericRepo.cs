using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        ICollection<T> GetAll();
        T GetById(long id);
        void Add(T obj);
        void Remove(T obj);
        void SaveChanges();
    }
}
