using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Customer : Person
    {

        public int Balance { get; set; }

        public Customer(string Name, string Address, int Balance) : base(Name, Address)
        {
            this.Balance = Balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Customer, Name = {Name}, address = {Address}, balance = {Balance}");
        }
    }
}
