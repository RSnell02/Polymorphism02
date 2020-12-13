/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: SalariedEmployee.cs
 * Author: R. Snell
 * Date: Feb. 03, 2020
 * Purpose: To demonstrate 3 levels of class hierarchy and their functioning
 *          with polymorphism. 
 *          This is a subclass of Employee.cs in the hierarchy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        //  4-parameter constructor
        public SalariedEmployee(string fn, string ln, string ssn,
            decimal ws):base(fn, ln, ssn)
        {
            weeklySalary = ws;    // Validate via property
        }   // end constructor

        //  The WeeklySalary property
        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set
            {
                if (value < 0)  // Validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(weeklySalary)} must be >= 0");
                }   // end if
                weeklySalary = value;
            }   // end set
        }   // end property

        // Calculate the earnings; override the abstract method in the
        // parent class
        public override decimal Earnings()
        {
            return WeeklySalary;
        }   // end Earnings

        // Override the ToString() method in the parent
        public override string ToString()
        {
            return string.Format($"Salaried employee: {base.ToString()}\n" +
                $"weekly salary: {WeeklySalary:C}");
        }   // end ToString()
    }   // end class
}   // end namespace
