namespace Lab_7___OOP_Generic_SamiHarun_NET24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Theo", "Male", 7500);
            Employee emp2 = new Employee(2, "Tim", "Male", 35000);
            Employee emp3 = new Employee(3, "Agaton", "Male", 40000);
            Employee emp4 = new Employee(4, "kim", "Female", 35000);
            Employee emp5 = new Employee(5, "Matilda", "Female", 70000);


            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(emp1);
            EmployeeStack.Push(emp2);
            EmployeeStack.Push(emp3);
            EmployeeStack.Push(emp4);
            EmployeeStack.Push(emp5);

            Console.WriteLine("All objects in the Stack");
            foreach (Employee emp in EmployeeStack)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Amount left in the stack: {EmployeeStack.Count}");
            }
            Console.WriteLine("\nGet object with Pop():");
            while (EmployeeStack.Count > 0)
            {
                Employee emp = EmployeeStack.Pop();
                Console.WriteLine(emp);
                Console.WriteLine($"Amount left in the stack: {EmployeeStack.Count}");
            }

            EmployeeStack.Push(emp1);
            EmployeeStack.Push(emp2);
            EmployeeStack.Push(emp3);
            EmployeeStack.Push(emp4);
            EmployeeStack.Push(emp5);

            Console.WriteLine("\nGets the first two objects with Peek():");
            Console.WriteLine(EmployeeStack.Peek());
            Console.WriteLine($"Amount object left in stack: {EmployeeStack.Count}");
            Console.WriteLine(EmployeeStack.Peek());
            Console.WriteLine($"Amount object left in stack: {EmployeeStack.Count}");

            bool Contains = EmployeeStack.Contains(emp3);
            Console.WriteLine($"\nEmployee 3: {Contains}");
            

            List<Employee> employeeList = new List<Employee> { emp1, emp2, emp3, emp4, emp5 };

            if (employeeList.Contains(emp2))
            {
                Console.WriteLine("Employee 2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list.");
            }

            Employee firstMale = employeeList.Find(e => e.Gender == "Male");
            if (firstMale != null)
            {
                Console.WriteLine($"\nFirst male employee on the list: {firstMale}");
            }
            else
            {
                Console.WriteLine("\nThere is no male.");
            }

            List<Employee> allMales = employeeList.FindAll(e => e.Gender == "Male");
            Console.WriteLine("\nAll male employees on the list:");
            foreach (Employee maleEmployee in allMales)
            {
                Console.WriteLine(maleEmployee);
            }
        }

    }
}
