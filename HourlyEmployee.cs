/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: HourlyEmployee.cs
 * Author: R. Snell
 * Date: Feb. 03, 2020
 * Purpose: To demonstrate 3 levels of class hierarchy and their functioning
 *          with polymorphism. 
 *          This is a subclass of Employee in the hierarchy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    class HourlyEmployee : Employee
    {
        private decimal wage;   // per hour
        private decimal hours;   // per week

        // 5-parameter constructor
        public HourlyEmployee(string fn, string ln, string ssn, decimal w,
            decimal h):base(fn, ln, ssn)
        {
            Wage = w;
            Hours = h;
        }   // end constructor

        // The Wage property
        public decimal Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Wage)} must be >= 0");
                }   // end if
            }   // end Set
        }   // end Wage property

        // The Hours property
        public decimal Hours
        {
            get { return hours; }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Hours)} must " +
                        $"be >= 0 and <= 168");
                }   // end if
            }   // end set
        }   // end Hours property

        // Override Earnings in the parent class
        public override decimal Earnings()
        {
            if (Hours <= 40)
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }   // end Earnings

        // Override ToString()
        public override string ToString()
        {
            return String.Format($"Hourly employee: {base.ToString()}\n" +
                $"hourly wage: {Wage:C}\nhours worled: {Hours:F2}");
        }   // end ToString()
    }   // end class
}   // end namespace
