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
            _context = new E_commerceContextDb();
        }
        public void Add(Category obj)
        {
            _context.Add(obj);
            
        }

        public bool Delete(Category obj)
        {
            return _context.Categories?.Remove(obj) != null;

        }

        public Category? Get(Expression<Func<Category, bool>> exp)
        {
            return _context.Categories?.FirstOrDefault(exp);
        }

        public Category? Get(int id)
        {
            return _context.Categories?.SingleOrDefault(i => i.Id == id);
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

        public void Update(Category obj)
        {
            _context.Categories?.Update(obj);
           
        }
    }
}