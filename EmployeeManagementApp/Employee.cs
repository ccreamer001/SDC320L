/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Abstract base class representing general organizational personnel,
 *          implementing IPayable and demonstrating Inheritance and Composition.
 ******************************************************************************/

using System;

namespace EmployeeManagementApp
{
    // [INLINE DOC: Interface implementation] Base class implements IPayable contract
    public abstract class Employee : IPayable
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }

        // // COMPOSITION: JobDetails is composed within Employee
        public JobDetails JobInfo { get; set; }

        // // Constructor for base class
        public Employee(int employeeId, string fullName, JobDetails jobInfo)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            JobInfo = jobInfo;
        }

        // // Virtual method to be overridden in derived classes (Polymorphism)
        public virtual string GetEmployeeSummary()
        {
            return $"ID: {EmployeeId} | Name: {FullName} | {JobInfo}";
        }

        // [INLINE DOC: Polymorphism] Abstract method overridden by derived classes
        public abstract decimal CalculatePay();
    }
}