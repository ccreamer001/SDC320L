/*************************************************************
 * Author: Christopher Creamer
 * Date: November 15, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Derived class representing an Hourly Employee, 
 *          extending the base Employee class.
 *************************************************************/

using System;

namespace EmployeeManagementApp
{
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(int employeeId, string fullName, JobDetails jobInfo, decimal hourlyRate, double hoursWorked)
            : base(employeeId, fullName, jobInfo)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override string GetEmployeeSummary()
        {
            return base.GetEmployeeSummary() + $" | Type: Hourly | Rate: {HourlyRate:C}/hr | Hours: {HoursWorked}";
        }
    }
}