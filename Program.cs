using System;

namespace EmploymentSystem
{
    // This interface declares a contract for quitting functionality
    public interface IQuittable
    {
        // Method declaration that any implementing class must fulfill
        void Quit();
    }

    // Employee class inherits from the IQuittable interface
    class Employee : IQuittable
    {
        // Concrete implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            // Output a confirmation that the employee is quitting
            Console.WriteLine("Employee has resigned from their position.");
        }
    }

    class Application
    {
        static void Main(string[] args)
        {
            // Use polymorphism to assign a new Employee to an IQuittable type
            IQuittable resignableEmployee = new Employee();

            // Execute the Quit method on the polymorphic object
            resignableEmployee.Quit();
        }
    }
}
