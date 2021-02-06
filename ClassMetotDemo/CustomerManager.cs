using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri  eklendi...");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " " + customer.FirstName + " " + customer.LastName + " Müşterisi Silindi");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerId + " " + customer.FirstName + " " + customer.LastName);
            }
        }
    }
}
