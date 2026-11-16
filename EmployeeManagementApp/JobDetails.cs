/*************************************************************
 * Author: Christopher Creamer
 * Date: November 15, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Composition class encapsulating department and 
 *          office location details for an Employee.
 *************************************************************/

using System;

namespace EmployeeManagementApp
{
    public class JobDetails
    {
        public string DepartmentName { get; set; }
        public string OfficeLocation { get; set; }

        public JobDetails(string departmentName, string officeLocation)
        {
            DepartmentName = departmentName;
            OfficeLocation = officeLocation;
        }

        public override string ToString()
        {
            return $"Dept: {DepartmentName}, Location: {OfficeLocation}";
        }
    }
}