using System;

namespace ronpruitt_usearray
{
    public class Employee
    {
        private readonly int yearsOfService;
        private string empName;
        private int empNumber;
        private EmploymentStatus empStatus;
        private DateTime hireDate;
        private decimal hourlyWage;

        public Employee(int empNumber, string empName, EmploymentStatus empStatus, decimal hourlyWage, DateTime hireDate)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.empStatus = empStatus;
            this.hourlyWage = hourlyWage;
            this.hireDate = hireDate;
            this.yearsOfService = GetYearsOfService();
        }

        public string EmpName { get => empName; set => empName = value; }
        public int EmpNumber { get => empNumber; set => empNumber = value; }
        public EmploymentStatus EmpStatus { get => empStatus; set => empStatus = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public decimal HourlyWage { get => hourlyWage; set => hourlyWage = value; }
        public int YearsOfService { get => yearsOfService; }

        public static string ColumnHeader()
        {
            return "Employee #" + " ".PadLeft(3) + "Name" + " ".PadLeft(20) + "Status" +
            " ".PadLeft(11) + "Wage" + " ".PadLeft(7) + "Hire Date" + " ".PadLeft(5) + "Years of Service\n" +
            "----------" + " ".PadLeft(3) + "----" + " ".PadLeft(20) + "------" +
            " ".PadLeft(10) + "-------" + " ".PadLeft(5) + "---------" + " ".PadLeft(5) + "----------------";
        }

        public static string EmployeeReportTitle(string rptTitle)
        {
            return String.Format(rptTitle +
            "\nReport Date: {0:dddd, MMMM d, yyyy}\n\n", GlobalVars.reportDate);
        }

        public static Employee[] GetEmployeeData()
        {
            var Employees = new Employee[]
            {
                 new Employee(101, "Amie Lee",
                 EmploymentStatus.PartTime, 10.62M, DateTime.Parse("10/13/2008")),
                 new Employee(351, "William Gates",
                 EmploymentStatus.FullTime, 18.94M, DateTime.Parse("2/28/2008")),
                 new Employee(403, "Juan Gomez",
                 EmploymentStatus.Seasonal, 11.48M, DateTime.Parse("11/21/2007")),
                 new Employee(21, "Jesse James",
                 EmploymentStatus.PartTime, 10.62M, DateTime.Parse("3/6/2016")),
                 new Employee(35, "Jalen Rose",
                 EmploymentStatus.FullTime, 18.94M, DateTime.Parse("2/28/2007")),
                 new Employee(345, "Sam Jones",
                 EmploymentStatus.Unknown, 12.48M, DateTime.Parse("9/12/2015")),
                 new Employee(24835, "Karen Lott",
                 EmploymentStatus.PartTime, 16.05M, DateTime.Parse("2/29/1996")),
                 new Employee(24835, "Ron Pruitt",
                 EmploymentStatus.PartTime, 16.05M, DateTime.Parse("2/27/2012"))
            };
            return Employees;
        }

        public int GetYearsOfService()
        {
            DateTime reportDate = GlobalVars.reportDate.Date;
            return YearsElapsed(this.hireDate, reportDate);
        }

        public override string ToString()
        {
            return String.Format("{0,-12} {1,-23} {2,-15} {3,-11:C} {4,-13:MM/dd/yyyy} {5,15}\n",
            empNumber, empName, empStatus, hourlyWage, hireDate, yearsOfService);
        }

        private int YearsElapsed(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}