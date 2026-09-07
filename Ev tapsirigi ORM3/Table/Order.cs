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
<<<<<<< HEAD
=======
            OrderDate= DateTime.Now;
            Customer=new Customer();
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
            Products = new List<Product>();
        }

        public int Id { get; set; }
<<<<<<< HEAD
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }= DateTime.Now;
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
=======
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
