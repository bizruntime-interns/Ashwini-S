using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data;
using System.IO;

namespace ConsoleApp4
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public designation Designation { get; set; }
        public department Department { get; set; }

    }
    public enum designation
    {
        JuniorHR,
        SeniorHR,
        SoftwareDeveloper,
        QualityAssurance,
        Infrastructure,
        Manager,
        CTO,
        COO
    }

    public enum department
    {
        HR,
        DEV,
        TESTING,
        QA,
        MANAGEMENT
    }
}

class Program
{
    static void Main(string[] args)
    {
        CompanyEmployees();
    }
    public static void CompanyEmployees()
    {
        Employee emp = new Employee();
        string[] empname = { "Sneha1", "Sneha2", "Sneha3", "Sneha4", "Sneha5" };
        int[] compId = { 10, 20, 30, 40, 50 };
        string[] compName = { "Asus", "Samsung", "HP", "Lenevo", "Acer" };

        StringBuilder csvcontent = new StringBuilder();
        csvcontent.AppendLine("EmployeeId, EmployeeName, CompanyId, CompanyName, Designation, Department");
        int EmployeeId = 1;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 200; j++)
            {
                if (j % 6 == 0)
                {
                    csvcontent.AppendLine(EmployeeId + " ," + empname[0] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.JuniorHR + " ," + Department.HR);
                }
                else

                    if (j % 5 == 0)
                    {
                        csvcontent.AppendLine(EmployeeId + " ," + empname[1] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.SeniorHR + " ," + Department.HR);
                    }
    
                else

                    if (j % 4 == 0)
                    {
                        csvcontent.AppendLine(EmployeeId + " ," + empname[2] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.SoftwareDeveloper + " ," + Department.DEV);
                    }

                else
        
                    if (j % 3 == 0)
                    {
                        csvcontent.AppendLine(EmployeeId + " ," + empname[3] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.QualityAssurance + " ," + Department.QA);
                    }

                else
                    if (j % 2 == 0)
                    {
                        csvcontent.AppendLine(EmployeeId + " ," + empname[4] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.Infrastructure + " ," + Department.QA);
                    }

                else
 
                    if (j % 1 == 0)
                    {
                        csvcontent.AppendLine(EmployeeId + " ," + empname[5] + " ," + " ," + emp.CompanyId + ", " + emp.CompanyName + " ," + Designation.Manager + " ," + Department.MANAGEMENT);
                    }

            }
        }
        string csvPath = "";
        File.AppendAllText(csvPath, csvcontent.ToString());
    }

    public static void ReadingFile()
    {
        try
        {
            string file = File.ReadAllText("");
            Console.WriteLine(file);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }


}