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
    public class ProductRepo : IRepository<Product>
    {
        private readonly E_commerceContextDb _context;

        public ProductRepo()
        {
            _context = new E_commerceContextDb();
        }
<<<<<<< HEAD
        public void Add(Product obj)
        {
            _context.Add(obj);
            
=======
        public Product Add(Product obj)
        {
            var add_obj = _context.Products?.Add(obj);
            return add_obj.Entity;
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
        }

        public bool Delete(Product obj)
        {
            return _context.Products?.Remove(obj) != null;

        }

        public Product? Get(Expression<Func<Product, bool>> exp)
        {
            return _context.Products?.FirstOrDefault(exp);
        }

        public Product? Get(int id)
        {
            return _context.Products?.SingleOrDefault(i => i.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> exp)
        {
            return exp != null ? _context.Products.Where(exp) : _context.Products;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

<<<<<<< HEAD
        public void Update(Product obj)
        {
            _context.Products?.Update(obj);
            
        }
    }
}
=======
        public Product Update(Product obj)
        {
            var add_obj = _context.Products.Update(obj);
            return add_obj.Entity;
        }
    }
}
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
