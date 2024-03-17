using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Classes.Persons
{
    public partial class Person  // we can use same name for class if its partial class
    {
        public Person(string firstname, string lastname, DateOnly dob)  //constructors
        {
            FirstName = firstname;
            LastName = lastname;
            DoB = dob;
        }
        public int GetAge()
        {
            Console.WriteLine($"Date of birth is {DoB}");
            var age = DateTime.Now.Year - DoB.Year;
            return age;
        }

        //Method Overloading
        public int GetAge(int year)
        {
            var age = year - DoB.Year;
            return age;
        }
    }
}
