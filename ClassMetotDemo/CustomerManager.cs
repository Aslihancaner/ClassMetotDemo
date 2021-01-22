using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " eklendi.");
        }
        public void GetAll(Customer customer)
        {
            Console.WriteLine("Tüm Liste : " + customer.FirstName + " " + customer.LastName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " silindi.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " güncellendi. ");
        }

    }
}
