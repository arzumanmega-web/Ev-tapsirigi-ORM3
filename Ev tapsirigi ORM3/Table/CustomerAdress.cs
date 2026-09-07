using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapsirigi_ORM3.Table
{
    public class CustomerAdress
    {
        public CustomerAdress()
        {
            Customer=new Customer();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? Adress { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
