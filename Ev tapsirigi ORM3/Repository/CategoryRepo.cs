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
    public class CategoryRepo : IRepository<Category>
    {
        private readonly E_commerceContextDb _context;

        public CategoryRepo()
        {
<<<<<<< HEAD
            _context = new E_commerceContextDb();
        }
        public void Add(Category obj)
        {
            _context.Add(obj);
            
=======
            _context=new E_commerceContextDb();
        }
        public Category Add(Category obj)
        {
            var add_obj = _context.Categories?.Add(obj);
            return add_obj.Entity;
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
        }

        public bool Delete(Category obj)
        {
<<<<<<< HEAD
            return _context.Categories?.Remove(obj) != null;
=======
            return _context.Categories?.Remove(obj) !=null;
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431

        }

        public Category? Get(Expression<Func<Category, bool>> exp)
        {
            return _context.Categories?.FirstOrDefault(exp);
        }

        public Category? Get(int id)
        {
<<<<<<< HEAD
            return _context.Categories?.SingleOrDefault(i => i.Id == id);
=======
            return _context.Categories?.SingleOrDefault(i=>i.Id==id);
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> exp)
        {
            return exp != null ? _context.Categories.Where(exp) : _context.Categories;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

<<<<<<< HEAD
        public void Update(Category obj)
        {
            _context.Categories?.Update(obj);
           
        }
    }
}
=======
        public Category Update(Category obj)
        {
            var add_obj= _context.Categories.Update(obj);
            return add_obj.Entity;
        }
    }
}
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
