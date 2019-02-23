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
        public Employee(int age, string surname)
        {
            Age = age;
            Surname = surname;
        }
        private string GetAge()
        {
            string res = Age.ToString();
            return res;
        }
        public void SetNewSurname(string newsurname)
        {
            Surname = newsurname;
        }
        public string GetInfo()
        {
            string Info = "Surname: " + this.Surname + ",Age: " + this.Age;
            return Info;
        }
    }
}
