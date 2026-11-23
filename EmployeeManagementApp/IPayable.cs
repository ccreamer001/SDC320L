/******************************************************************************
 * Author: Christopher Creamer
 * Date: November 22, 2026
 * Course: SDC320L Advanced Object-Oriented Programming Using C# LAB
 * Purpose: Interface defining a contract for calculating employee compensation.
 ******************************************************************************/

using System;

namespace EmployeeManagementApp
{
    // [INLINE DOC: Interface creation] Defines compensation calculation contract
    public interface IPayable
    {
        decimal CalculatePay();
    }
}