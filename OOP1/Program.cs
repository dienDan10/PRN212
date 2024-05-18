namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao mot list chua cac employee
            List<Employee> employees = new List<Employee>() { 
                new FullTimeEmployee ("John", 20),
                new PartTimeEmployee("Harry", 25, 5),
                new FullTimeEmployee("Augus", 25),
                new PartTimeEmployee("Micheal", 30, 4)
            };

            while (true)
            {
                showMenu();
                int option = getUserOption(1, 5);

                switch(option)
                {
                    case 1:
                        findHighestSalaryEmp(employees);
                        Console.WriteLine();
                        break;
                    case 2:
                        findEmployeeByName(employees);
                        Console.WriteLine();
                        break;
                    case 3:
                        addNewEmployee(employees);
                        break;
                    case 4:
                        showAllEmployee(employees);
                        break;
                    default:
                        return;
                }

            }



        }

        private static void showMenu()
        {
            Console.WriteLine("Choose Your options: ");
            Console.WriteLine("1. Find employee with highest salary.");
            Console.WriteLine("2. Find employee by name.");
            Console.WriteLine("3. Add new employee.");
            Console.WriteLine("4. Show all employee.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("Enter your options: ");
        }


        /// <summary>
        /// Get a valid user option from 1 to 4
        /// </summary>
        /// <returns>Option of user in integer</returns>
        private static int getUserOption(int min, int max)
        {
            while (true)
            {
                try
                {

                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        if (value <= max && value >= min)
                        {
                            return value;
                        }
                    
                    }
                        throw new Exception();

                } catch (Exception ex)
                {
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        /// <summary>
        /// Find the max salary employee in a list
        /// </summary>
        /// <param name="list">List of employees</param>
        private static void findHighestSalaryEmp(List<Employee> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("There are no employee in database.");
                return;
            }

            Employee emp = null;
            int maxSalary = 0;
            foreach (Employee employee in list)
            {
                if (employee.calculateSalary()  > maxSalary)
                {
                    maxSalary = employee.calculateSalary();
                    emp = employee;
                }
            }

            if (emp != null)
            {
                Console.WriteLine("Max salary employee is: " + emp.ToString());
            } else
            {
                return;
            }
        }
       
        /// <summary>
        /// Prompt the user for a name and find the employee 
        /// with the same name
        /// </summary>
        /// <param name="list">List of employees</param>
        private static void findEmployeeByName(List<Employee> list)
        {
            // get name from user
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No employee with that name exist.");
                return;
            }

            Employee emp = list.Find(em => em.Name.ToLower().Equals(name.ToLower()));

            if (emp == null)
            {
                Console.WriteLine("No Employee with name = {0} exist.", name);
                return;
            }

            Console.WriteLine("Employee with name = {0} is {1}", name, emp.ToString());
        }

        /// <summary>
        /// Add a new employee to db
        /// </summary>
        /// <param name="list"></param>
        private static void addNewEmployee(List<Employee> list)
        {
            Console.WriteLine("Choose type of employee:");
            Console.WriteLine("1. Full-time employee.");
            Console.WriteLine("2. Part-time employee.");
            Console.WriteLine("Enter your options: ");

           

            int options = getUserOption(1, 2);
            switch (options)
            {
                        case 1:
                            addFullTimeEmployee(list);
                            break;
                        case 2:
                            addPartTimeEmployee(list);
                            break;
                        default:
                            break;
            }

            Console.WriteLine("Add new employee successful");
            return;
        }

        private static void addFullTimeEmployee(List<Employee> list)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Payment per hour: ");
            int pph;
            if (!int.TryParse(Console.ReadLine(), out pph))
            {
                Console.WriteLine("Your input is invalid");
                return;
            }

            list.Add(new FullTimeEmployee(name, pph));
        }

        private static void addPartTimeEmployee(List<Employee> list)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Payment per hour: ");
            int pph;
            if (!int.TryParse(Console.ReadLine(), out pph))
            {
                Console.WriteLine("Your input is invalid");
                return;
            }
            Console.WriteLine("Enter working hour: ");
            int wh;
            if (!int.TryParse (Console.ReadLine(), out wh))
            {
                Console.WriteLine("Your input is invalid");
                return;
            }

            list.Add(new PartTimeEmployee(name, pph, wh));
        }

        private static void showAllEmployee(List<Employee> list)
        {
            Console.WriteLine("All employee: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("-----------------------------------");
        }

    }
}
