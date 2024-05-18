namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() { 
                new Employee("Andrew", "Canada", 5000),
                new Employee("William", "US", 4500),
                new Employee("Carol", "UK", 6000)
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer("Harry", "France", 150000),
                new Customer("Bane", "Italy", 120000),
                new Customer("Argus", "Germany", 200000)
            };


            while (true)
            {
                ShowMenu();
                int option = GetUserOption(1, 5);

                switch (option)
                {
                    case 1:
                        FindHighestSalaryEmployee(employees);
                        Console.WriteLine();
                        break;
                    case 2:
                        FindLowestBalanceCustomer(customers);
                        Console.WriteLine();
                        break;
                    case 3:
                        FindEmployeeByName(employees);
                        Console.WriteLine();
                        break;
                    case 4:
                        ShowAllEmployeeAndCustomer(employees, customers);
                        Console.WriteLine();
                        break;
                    case 5:
                        return;
                }

            }

        }

        private static void ShowMenu()
        {
            Console.WriteLine("Please choose your option: ");
            Console.WriteLine("1. Find highest salary employee.");
            Console.WriteLine("2. Find lowest balance customer.");
            Console.WriteLine("3. Find employee by name.");
            Console.WriteLine("4. Show all employee and customer.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("Enter your choice: ");
        }

        private static int GetUserOption(int min, int max)
        {
            while (true)
            {
                try
                {

                    string input = Console.ReadLine();
                    int res = int.Parse(input);

                    if (res > max || res < min)
                    {
                        throw new Exception();
                    }

                    return res;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        private static void FindHighestSalaryEmployee(List<Employee> list)
        {
            if (list == null || list.Count <= 0)
            {
                Console.WriteLine("No employee in database.");
                return;
            }

            Employee em = null;
            int salary = 0;
            foreach (Employee emp in list)
            {
                if (emp.Salary > salary)
                {
                    salary = emp.Salary;
                    em = emp;
                }
            }

            Console.WriteLine("Highest salary employee: ");
            if (em == null) return;
            em.Display();
        }

        private static void FindLowestBalanceCustomer(List<Customer> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("No customer in database.");
                return;
            }

            Customer cus = null;
            int balance = 0;
            foreach (Customer customer in list) {
                if (customer.Balance < balance)
                {
                    balance = customer.Balance;
                    cus = customer;
                }
            }

            Console.WriteLine("Lowest balance customer: ");
            if (cus == null) return;
            cus.Display();
        }

        private static void FindEmployeeByName(List<Employee> list)
        {
            string name = GetEmployeeName();
            foreach (Employee emp in list)
            {
                if (emp.Name.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("Employee: ");
                    emp.Display();
                    return;
                }
            }
            Console.WriteLine("No employee with name = {0} found", name);
        }

        private static string GetEmployeeName()
        {
            string input = "";
            Console.WriteLine("Enter employee name:");
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid name input.");
                    Console.WriteLine("Enter again: ");
                    continue;
                }
                break;
            }
            return input;
        }

        private static void ShowAllEmployeeAndCustomer(List<Employee> employees, List<Customer> customers)
        {
            Console.WriteLine("Employee List: ");
            foreach (Employee emp in employees)
            {
                emp.Display();
            }
            Console.WriteLine("Customer List: ");
            foreach (Customer cus in customers)
            {
                cus.Display();
            }
        }
    }
}
