using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapsirigi_ORM3.Table
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }= DateTime.Now;
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}