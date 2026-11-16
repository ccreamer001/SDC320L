/*************************************************************
 * Author: Christopher Creamer
 * Date: November 15, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Main application entry point for the Employee Management System,
 *          providing interactive console workflows, inheritance, and composition.
 *************************************************************/

using System;
using System.Collections.Generic;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display Project Indicator & Welcome Header
            Console.WriteLine("==================================================");
            Console.WriteLine(" SDC320L Project Week 1: Inheritance & Composition ");
            Console.WriteLine(" Author: Christopher Creamer | Date: 11/15/2026   ");
            Console.WriteLine("==================================================");
            Console.WriteLine("\"Programming is like writing a joke. If you have to explain it, it’s bad.\"\n");

            // Instantiate Composition objects
            JobDetails devDept = new JobDetails("Software Engineering", "Building A, Suite 200");
            JobDetails hrDept = new JobDetails("Human Resources", "Building B, Suite 100");

            // Instantiate Derived Classes demonstrating Inheritance and Composition
            List<Employee> employees = new List<Employee>
            {
                new SalariedEmployee(101, "Sarah Jenkins", devDept, 85000.00m),
                new HourlyEmployee(102, "Marcus Vance", hrDept, 24.50m, 40.0)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Employee Management Menu ---");
                Console.WriteLine("1. Display All Employees");
                Console.WriteLine("2. Add Sample Employee");
                Console.WriteLine("Q. Quit Application");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("Current Employee Records:");
                    foreach (var emp in employees)
                    {
                        // INHERITANCE IN ACTION: Calling overridden methods from derived classes
                        Console.WriteLine(emp.GetEmployeeSummary());
                    }
                }
                else if (input == "2")
                {
                    JobDetails salesDept = new JobDetails("Sales & Marketing", "Building C, Suite 300");
                    employees.Add(new SalariedEmployee(103, "Elena Rostova", salesDept, 72000.00m));
                    Console.WriteLine("Successfully added new salaried employee!");
                }
                else if (input?.ToUpper() == "Q")
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