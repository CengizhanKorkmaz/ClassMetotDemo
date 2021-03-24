using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager : ICustomerService
    {
        List<Customer> customers = new List<Customer> { };
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.CustomerName+ "adlı müşteri sisteme eklendi");
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine(customer.CustomerName+ "adlı müşteri silindi.");
        }

        public void GetAll()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustormerLastName);
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+"adlı müşteri bilgileri güncellendi.");
        }
    }
}
