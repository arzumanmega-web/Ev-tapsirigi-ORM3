using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapsirigi_ORM3.Repository.IRepository
{
    public interface IRepository<T>
    {
        T? Get(Expression<Func<T, bool>> exp);
        T? Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> exp);
<<<<<<< HEAD
        void Update(T obj);
        void Add(T obj);
        bool Delete(T obj);
        bool SaveChanges();
    }
}
=======
        T Update(T obj);
        T Add(T obj);
        bool Delete(T obj);
        bool SaveChanges();
    }
}
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
