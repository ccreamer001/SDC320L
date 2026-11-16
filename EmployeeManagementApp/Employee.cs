/*************************************************************
 * Author: Christopher Creamer
 * Date: November 15, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Abstract base class representing general organizational 
 *          personnel, demonstrating Inheritance and Composition.
 *************************************************************/

using System;

namespace EmployeeManagementApp
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        
        // COMPOSITION: JobDetails is composed within Employee
        public JobDetails JobInfo { get; set; }

        // Constructor for base class
        public Employee(int employeeId, string fullName, JobDetails jobInfo)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            JobInfo = jobInfo;
        }

        // Virtual method to be overridden in derived classes (Polymorphism preview)
        public virtual string GetEmployeeSummary()
        {
            return $"ID: {EmployeeId} | Name: {FullName} | {JobInfo}";
        }
    }
}