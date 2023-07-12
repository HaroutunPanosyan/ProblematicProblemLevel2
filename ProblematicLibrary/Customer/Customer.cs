using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Customer
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public DateTime Dob { get; set; }

        public Customer(string firstName, string lastName, int age, DateTime dob)
        {            
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Dob = dob;
        }

    }
}
