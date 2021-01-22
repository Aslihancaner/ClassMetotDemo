using System;

namespace ClassMethodDemo
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
            customerManager.Update(customer);
            customerManager.GetAll(customer);
            customerManager.Delete(customer);
        }
    }
}
