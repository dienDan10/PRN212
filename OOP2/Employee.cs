using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Employee : Person
    {

        public int Salary { get; set; }


        public Employee(string Name, string Address, int Salary) : base(Name, Address)
        {
            this.Salary = Salary;
        }

        public override void Display()
        {
            Console.WriteLine($"Employee, Name = {Name}, address = {Address}, salary = {Salary}");
        }
    }
}
