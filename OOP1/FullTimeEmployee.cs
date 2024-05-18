using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class FullTimeEmployee : Employee
    {

        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8*PaymentPerHour;
        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return string.Format("Full Time Employee, Name: {0}, Payment per Hour: {1}", Name, PaymentPerHour);
        }

    }
}
