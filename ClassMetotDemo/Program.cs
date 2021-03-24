using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Cengizhan";
            customer1.CustormerLastName = "Korkmaz";
            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "İrem Nur";
            customer2.CustormerLastName= "Özesen";
            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Tuncay Cem";
            customer3.CustormerLastName = "Uzun";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.GetAll();
            customerManager.Delete(customer2);
            
        }
    }
}
