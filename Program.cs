/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: Project.cs
 * Author: R. Snell
 * Date: Jan. 29, 2020
 * Purpose: To demonstrate 3 levels of class hierarchy and their functioning
 *          with polymorphism. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create derived class objects
            var salariedEmployee = new SalariedEmployee("John", "Smith",
                "111-22-3333", 800.00M);
            var hourlyEmployee = new HourlyEmployee("Karen", "Price",
                "222-33-4444", 16.75M, 12.50M);
            var commissionEmployee = new CommissionEmployee("Sue",
                "Jones", "333-44-555", 10000.00M, 0.06M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee(
                "Bob", "Lewis", "444-55-6666", 5000.00M, 0.05M, 300.00M);

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine($"{salariedEmployee}\nearned: " +
                $"{salariedEmployee.Earnings():C}\n");
            Console.WriteLine($"{hourlyEmployee}\nearned: " +
                $"{hourlyEmployee.Earnings():C}\n");
            Console.WriteLine($"{commissionEmployee}\nearned: " +
                $"{commissionEmployee.Earnings():C}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
                $"{basePlusCommissionEmployee.Earnings():C}\n");

            // Create a list of employees
            var employees = new List<Employee>() { salariedEmployee,
                hourlyEmployee, commissionEmployee,
                basePlusCommissionEmployee};

            Console.WriteLine("Employees polymorhically:\n");

            // Process the elements of the list
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); // call the ToString()method

                // Date: Feb. 05, 2020
                // Determine wheather the element is BasePlusCommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee)currentEmployee;

                    employee.BaseSalary += 1.1M;
                    Console.WriteLine("New base salary with 10% increase is: " +
                        $"{employee.BaseSalary:C}");
                }   // end if
            }   // end foreach
        } //end Main()
    }   // end class
}   // end namespace
