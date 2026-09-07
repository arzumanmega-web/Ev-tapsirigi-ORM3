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
        T Update(T obj);
        T Add(T obj);
        bool Delete(T obj);
        bool SaveChanges();
    }
}
