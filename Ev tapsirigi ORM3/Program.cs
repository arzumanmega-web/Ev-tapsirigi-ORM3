using Ev_tapsirigi_ORM3.Repository;
using Ev_tapsirigi_ORM3.Table;

namespace Ev_tapsirigi_ORM3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctr=new CategoryRepo();
            var category = new Category() { Name = "Elektronika"};
            
            ctr.SaveChanges();

            var csr = new CustomerRepo();
            var customer = new Customer() { Name="Sabir",Email="Sabir_S@gmail.com"};
            
            csr.SaveChanges();

            var csar = new CustomerAdressRepo();
            var customeradress = new CustomerAdress() { Adress="Bileceri",City="Baki"};
            
            csar.SaveChanges();

            var prr = new ProductRepo();
            var product = new Product() { Name = "NoteBook", Price = 1500};
           

            var productcollect = new List<Product>();
            productcollect.Add(product);
            var orr = new OrderRepo();
            var order = new Order() { Customer = customer,CustomerId=customer.Id,Products=productcollect };

            product.Category = category;
            product.CategoryId = category.Id;
            product.Orders.Add(order);

            category.Products.Add(product);

            customer.Orders.Add(order);
            customer.CustomerAdress = customeradress;

            customeradress.Customer= customer;
            customeradress.CustomerId= customer.Id;

            ctr.Add(category);
            ctr.SaveChanges();
            csr.Add(customer);
            csr.SaveChanges();
            csar.Add(customeradress);
            csar.Add(customeradress);
            prr.Add(product);
            prr.SaveChanges();
            orr.Add(order);
            orr.SaveChanges();

        }
    }
}
