using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void GetAll();
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
