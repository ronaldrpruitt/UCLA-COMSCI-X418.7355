using System;
using System.Linq;

namespace ronpruitt_usearray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee[] employees = Employee.GetEmployeeData();

            //Step 3
            Console.WriteLine(Employee.EmployeeReportTitle("Employee Report Data Dump"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            //Step 4
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with less than 1 year of service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees.Where(e => e.YearsOfService < 1))
            {
                Console.WriteLine(employee);
            }

            //Step 5
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with 1 to 5 years of service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees.Where(e => e.YearsOfService >= 1 && e.YearsOfService <= 5))
            {
                Console.WriteLine(employee);
            }

            //Step 6
            Console.WriteLine(Employee.EmployeeReportTitle("Employees with 6 to 10 years of service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees.Where(e => e.YearsOfService >= 6 && e.YearsOfService <= 10))
            {
                Console.WriteLine(employee);
            }

            //Step 7
            Console.WriteLine(Employee.EmployeeReportTitle("Employees more than 10 years of service"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees.Where(e => e.YearsOfService > 10))
            {
                Console.WriteLine(employee);
            }

            //Step 8 BONUS
            Console.WriteLine(Employee.EmployeeReportTitle("Employees sorted by employment status"));
            Console.WriteLine(Employee.ColumnHeader());
            foreach (Employee employee in employees.OrderByDescending(e => e.EmpStatus))
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nHit any key to continue...");
            Console.ReadKey();
        }
    }
}