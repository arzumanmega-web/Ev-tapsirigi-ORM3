using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ev_tapsirigi_ORM3.Table
{

    public class Product
    {
        public Product()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }


}