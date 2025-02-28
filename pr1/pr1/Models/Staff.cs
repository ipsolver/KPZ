using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    public class Staff
    {
        public string Name { get; private set; }
        public string Role { get; private set; }
        private double Salary { get; set; }

        public Staff(string name, string role, double salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }

        public void SetSalary(double newSalary)
        {
            if (newSalary > 0)
                Salary = newSalary;
        }

        public override string ToString()
        {
            return $"{Name}, Post: {Role}, Salary: {Salary} USD";
        }
    }
}

