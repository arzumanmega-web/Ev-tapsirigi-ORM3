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
    public class CustomerRepo : IRepository<Customer>
    {
        private readonly E_commerceContextDb _context;

        public CustomerRepo()
        {
            _context = new E_commerceContextDb();
        }
        public Customer Add(Customer obj)
        {
            var add_obj = _context.Customers?.Add(obj);
            return add_obj.Entity;
        }

        public bool Delete(Customer obj)
        {
            return _context.Customers?.Remove(obj) != null;

        }

        public Customer? Get(Expression<Func<Customer, bool>> exp)
        {
            return _context.Customers?.FirstOrDefault(exp);
        }

        public Customer? Get(int id)
        {
            return _context.Customers?.SingleOrDefault(i => i.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> exp)
        {
            return exp != null ? _context.Customers.Where(exp) : _context.Customers;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Customer Update(Customer obj)
        {
            var add_obj = _context.Customers.Update(obj);
            return add_obj.Entity;
        }
    }
}
