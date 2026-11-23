/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Reusable console helper for displaying headers, instructions, and
 *          validated user input across project milestones.
 ******************************************************************************/

using System;

namespace EmployeeManagementApp
{
    public static class ConsoleHelper
    {
        public static void ShowWeek2Banner(string assignmentTitle, string authorName)
        {
            Console.WriteLine("======================================================================");
            Console.WriteLine($"Project Week 2 | {assignmentTitle} | Author: {authorName}");
            Console.WriteLine("======================================================================");
            Console.WriteLine("Welcome to the Employee Management System (Week 2 OOP Expansion)!");
            Console.WriteLine("Instructions: Enter a menu number (1-3) to view employee records,");
            Console.WriteLine("calculate compensation polymorphically, or add a sample employee.");
            Console.WriteLine("Enter 'Q' at any menu prompt to quit the application.\n");
        }

        public static string ReadMenuChoice(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }
    }
}