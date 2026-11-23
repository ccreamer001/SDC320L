/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Derived class representing a Salaried Employee, extending the base
 *          Employee class and implementing polymorphic compensation logic.
 ******************************************************************************/

using System;

namespace EmployeeManagementApp
{
    public class SalariedEmployee : Employee
    {
        public decimal AnnualSalary { get; set; }

        public SalariedEmployee(int employeeId, string fullName, JobDetails jobInfo, decimal annualSalary)
            : base(employeeId, fullName, jobInfo)
        {
            AnnualSalary = annualSalary;
        }

        public override string GetEmployeeSummary()
        {
            return base.GetEmployeeSummary() + $" | Type: Salaried | Salary: {AnnualSalary:C}/yr";
        }

        // [INLINE DOC: Interface implementation & polymorphism]
        public override decimal CalculatePay()
        {
            return AnnualSalary / 12m;
        }
    }
}