/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Derived class representing an Hourly Employee, extending the base
 *          Employee class and implementing polymorphic compensation logic.
 ******************************************************************************/

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
            return base.GetEmployeeSummary() + $" | Type: Hourly | Rate: {HourlyRate:C}/hr | Hours: {HoursWorked:0.0}";
        }

        // [INLINE DOC: Interface implementation & polymorphism]
        public override decimal CalculatePay()
        {
            if (HoursWorked <= 40.0)
            {
                return (decimal)HoursWorked * HourlyRate;
            }

            decimal regularPay = 40m * HourlyRate;
            decimal overtimePay = (decimal)(HoursWorked - 40.0) * HourlyRate * 1.5m;
            return regularPay + overtimePay;
        }
    }
}