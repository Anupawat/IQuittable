using System;

namespace EmployeeComparison
{
    // Employee class implementing the IQuittable interface
    public class Employee : IQuittable
    {
        // Auto-implemented properties for Employee details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return ReferenceEquals(emp1, emp2);

            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator as a pair to "==" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Overriding Equals method to maintain consistency with "=="
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
                return this.Id == otherEmployee.Id;

            return false;
        }

        // Overriding GetHashCode to avoid compiler warnings
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Implementing the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
        }
    }
}
