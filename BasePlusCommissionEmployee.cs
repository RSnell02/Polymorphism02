/*
 * Project: 09-Spring2020-Polymorphism02
 * Filemane: BasePlusCommissionEmployee.cs
 * Author: R. Snell
 * Date: Feb. 03, 2020
 * Purpose: To demonstrate 3 levels of class hierarchy and their functioning
 *          with polymorphism. 
 *          This is a subclass of CommissionEmployee in the hierarchy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // per week

        // 6-parameter constructor
        public BasePlusCommissionEmployee(string fn, string ln, string ssn,
            decimal gs, decimal cr, decimal bs) : base(fn, ln, ssn, gs, cr)
        {
            BaseSalary = bs;
        }   // end constructor

        // The BaseSalary property
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value,
                        $"{nameof(BaseSalary)} must be >= 0");
                }   // end if
            }   // end set
        }   // end BaseSalary property

        // Override Earnings() in the parent
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }   // end Earnings()

        // Override the ToString() method
        public override string ToString()
        {
            return String.Format($"Base + Commission  employee: {base.ToString()}" + 
                $"\nbase salary: {BaseSalary:C}");
        }   // end ToString()
    }   // end class
}   // end namespace
