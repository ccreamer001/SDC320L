/*************************************************************
 * Author: Christopher Creamer
 * Date: November 15, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Derived class representing a Salaried Employee, 
 *          extending the base Employee class.
 *************************************************************/

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
            return base.GetEmployeeSummary() + $" | Type: Salaried | Salary: {AnnualSalary:C}";
        }
    }
}