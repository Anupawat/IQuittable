using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Employee object and setting its properties
            Employee employee = new Employee
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Polymorphism: Using the Employee object as an IQuittable type
            IQuittable quittable = employee;

            // Calling the Quit() method via the IQuittable interface
            quittable.Quit();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
