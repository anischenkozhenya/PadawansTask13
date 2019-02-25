using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    public class Employee
    {
        private string Surname;
        private int Age;

        public Employee()
        {

        }

        public Employee(string surname, int age)
        {
            Surname = surname;
            Age = age;
        }

        private string GetAgeString()
        {
            return Age.ToString();
        }

        public void SetNewSurname(string newSurname)
        {
            Surname = newSurname;
        }

        public string GetInfo()
        {
            return "Surname: " + Surname + ", Age: " + Age;
        }
    }
}
