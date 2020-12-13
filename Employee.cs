/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: Employee.cs
 * Author: R. Snell
 * Date: Jan. 29, 2020
 * Purpose: To demonstrate 3 levels of class hierarchy and their functioning
 *          with polymorphism. 
 *          This is the parent class in the hierarchy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    abstract class Employee
    {
        // Properties
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        // 3-parameter constructor
        public Employee(string fn, string ln, string ssn)
        {
            FirstName = fn;
            LastName = ln;
            SocialSecurityNumber = ssn;
        }   // end constructor

        // Return a string representation of the class
        public override string ToString()
        {
            return String.Format($"{FirstName} {LastName}\n" + 
                   $"social security number: {SocialSecurityNumber}");
        }

        // Abstract method to be overridden by derived classes
        public abstract decimal Earnings(); // No implementation
    }   // end class
}   // end namespace
