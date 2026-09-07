using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapsirigi_ORM3.Table
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
