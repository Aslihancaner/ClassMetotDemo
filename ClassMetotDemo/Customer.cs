using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
       
        public Customer()
        {
           
        }
        public Customer(int ıd, string firstName, string lastName, bool gender)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Id,-15}{FirstName,-15}{LastName,-15}{Gender,-15}";
        }
    }
}
