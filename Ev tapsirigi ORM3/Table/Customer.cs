using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapsirigi_ORM3.Table
{
    public class Customer
    {
        public Customer()
        {
<<<<<<< HEAD
            Orders = new List<Order>();
=======
            CustomerAdress=new CustomerAdress();
            Orders=new List<Order>();
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
        }

        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
<<<<<<< HEAD
        public virtual CustomerAdress? CustomerAdress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
=======
        public virtual CustomerAdress CustomerAdress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
>>>>>>> 7a11ef8b01370e9921aaa3916126769e16030431
