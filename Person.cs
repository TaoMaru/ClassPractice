using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Person
    {
            //instance variables:
            private string firstName;
            private string lastName;

            //instance methods:
            public void Introduce()
            {
                Console.WriteLine("Hello, my name is {0} {1}!", firstName, lastName);
            }

            public void setName(string fName, string lName)
            {
                this.firstName = fName;
                this.lastName = lName;
            }

    }
}
