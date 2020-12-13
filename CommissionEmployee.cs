/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: CommissionEmployee.cs
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
    class CommissionEmployee : Employee
    {
        private decimal grossSales; // weekly gross sales
        private decimal commissionRate; // percentage commission

        // 5-parameter constructor
        public CommissionEmployee(string fn, string ln, string ssn, decimal gs,
            decimal cr) : base(fn, ln, ssn)
        {
            GrossSales = gs;
            CommissionRate = cr;
        }   // end constructor

        // The GrossSales property
        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(GrossSales)} must be >= 0");
                }   // end if

                grossSales = value;
            }   // end set
        }   // end GrossSales property

        // The CommissionRate property
        public decimal CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(CommissionEmployee)} must be > 0 and < 1.");
                }   // end if
            }   // end set
        }   // end CommissionRate property

        // Overriding the Earnings method in the parent (Employee) class
        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }   // end Earnings

        // Ovveride ToString() in Employee
        public override string ToString()
        {
            return String.Format($"Commission employee: {base.ToString()}\n" + 
                $"gross sales: {GrossSales:C}\n" + 
                $"commission rate: {CommissionRate: F2}");
        }   // end ToString()
    }   // end class
}   // end namespace
