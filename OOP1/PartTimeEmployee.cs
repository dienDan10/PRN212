using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class PartTimeEmployee : Employee
    {

        public int WorkingHour { get; set; }

        public PartTimeEmployee(string name, int paymentPerHour, int workingHour) : base(name, paymentPerHour)
        {
            this.WorkingHour = workingHour;
        }

        public override int calculateSalary()
        {
            return WorkingHour * PaymentPerHour;
        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return string.Format("Part Time Employee, Name: {0}, Payment per Hour: {1}, working hour: {2}", Name, PaymentPerHour, WorkingHour);
        }
    }
}
