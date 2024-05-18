using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP1
{
    internal abstract class Employee : IEmployee
    {

        public string Name { get; set; }

        public int PaymentPerHour { get; set; }

        public Employee(string name, int paymentPerHour)
        {
            this.Name = name;
            this.PaymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public abstract string getName();

        public virtual string ToString()
        {
            return string.Format("Employee name: {0}, PaymentPerHour: {1}", Name, PaymentPerHour);
        }

    }
}
