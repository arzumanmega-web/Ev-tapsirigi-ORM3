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
    public class OrderRepo : IRepository<Order>
    {
        private readonly E_commerceContextDb _context;

        public OrderRepo()
        {
            _context = new E_commerceContextDb();
        }
        public Order Add(Order obj)
        {
            var add_obj = _context.Orders?.Add(obj);
            return add_obj.Entity;
        }

        public bool Delete(Order obj)
        {
            return _context.Orders?.Remove(obj) != null;

        }

        public Order? Get(Expression<Func<Order, bool>> exp)
        {
            return _context.Orders?.FirstOrDefault(exp);
        }

        public Order? Get(int id)
        {
            return _context.Orders?.SingleOrDefault(i => i.Id == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders;
        }

        public IEnumerable<Order> GetAll(Expression<Func<Order, bool>> exp)
        {
            return exp != null ? _context.Orders.Where(exp) : _context.Orders;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Order Update(Order obj)
        {
            var add_obj = _context.Orders.Update(obj);
            return add_obj.Entity;
        }
    }
}
