using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal abstract class Person
    {

        public string Name { get; set; }

        public string Address { get; set; }

        protected Person(string Name, string Address)
        {
            this.Address = Address;
            this.Name = Name;
        }

        public abstract void Display();
    }
}
