using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { CustomerId = 1, FirstName = "Nazlıcan", LastName = "Aslan" };
            Customer customer2 = new Customer() { CustomerId = 2, FirstName = "Cemal", LastName = "Aslan" };
            Customer customer3 = new Customer() { CustomerId = 3, FirstName = "Şefika", LastName = "Aslan" };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);
        }
    }
}
