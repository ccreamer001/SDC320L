/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Main application entry point for the Employee Management System,
 *          demonstrating inheritance, composition, interfaces, and polymorphism.
 ******************************************************************************/

using System;
using System.Collections.Generic;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.ShowWeek2Banner("Interfaces & Polymorphism", "Christopher Creamer");

            JobDetails devDept = new JobDetails("Software Engineering", "Building A, Suite 200");
            JobDetails hrDept = new JobDetails("Human Resources", "Building B, Suite 105");

            List<Employee> employees = new List<Employee>
            {
                new SalariedEmployee(101, "Sarah Jenkins", devDept, 85000.00m),
                new HourlyEmployee(102, "Marcus Vance", hrDept, 24.50m, 40.0)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Employee Management Menu ---");
                Console.WriteLine("1. Display All Employees (Polymorphic Summary & Pay)");
                Console.WriteLine("2. Add Sample Employee");
                Console.WriteLine("Q. Quit Application");
                string input = ConsoleHelper.ReadMenuChoice("Select an option: ");
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("Current Employee Records:");
                    foreach (Employee emp in employees)
                    {
                        // [INLINE DOC: Polymorphism] Invoking overridden summary and interface pay method
                        IPayable payableEmp = emp;
                        Console.WriteLine($"{emp.GetEmployeeSummary()} | Monthly Pay: ${payableEmp.CalculatePay():F2}");
                    }
                }
                else if (input == "2")
                {
                    JobDetails salesDept = new JobDetails("Sales & Marketing", "Building C, Suite 110");
                    employees.Add(new SalariedEmployee(103, "Elena Rostova", salesDept, 72000.00m));
                    Console.WriteLine("Successfully added new salaried employee!");
                }
                else if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    running = false;
                    Console.WriteLine("Exiting application. Have a great day!");
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
        }
    }
}