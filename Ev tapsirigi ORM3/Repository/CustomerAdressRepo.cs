using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ev_tapsirigi_ORM3.DbContex;
using Ev_tapsirigi_ORM3.Repository.IRepository;
using Ev_tapsirigi_ORM3.Table;

namespace Ev_tapsirigi_ORM3.Repository
{

    public class CustomerAdressRepo : IRepository<CustomerAdress>
    {
        private readonly E_commerceContextDb _context;

        public CustomerAdressRepo()
        {
            _context = new E_commerceContextDb();
        }
        
        public CustomerAdress Add(CustomerAdress obj)
        {
            var add_obj = _context.CustomerAdresses?.Add(obj);
            return add_obj.Entity;
        }

        public bool Delete(CustomerAdress obj)
        {
            return _context.CustomerAdresses?.Remove(obj) != null;

        }

        public CustomerAdress? Get(Expression<Func<CustomerAdress, bool>> exp)
        {
            return _context.CustomerAdresses?.FirstOrDefault(exp);
        }

        public CustomerAdress? Get(int id)
        {
            return _context.CustomerAdresses?.SingleOrDefault(i => i.Id == id);
        }

        public IEnumerable<CustomerAdress> GetAll()
        {
            return _context.CustomerAdresses;
        }

        public IEnumerable<CustomerAdress> GetAll(Expression<Func<CustomerAdress, bool>> exp)
        {
            return exp != null ? _context.CustomerAdresses.Where(exp) : _context.CustomerAdresses;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public CustomerAdress Update(CustomerAdress obj)
        {
            var add_obj = _context.CustomerAdresses.Update(obj);
            return add_obj.Entity;
        }
    }
}
