using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Customer customer = new Customer()
            {
                FirstName="Aslıhan",
                LastName="Caner",
                Gender=true,
                Id=5
            };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);
            customerManager.GetAll(customer);
        }
    }
}
