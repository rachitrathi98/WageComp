using System;

namespace WageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageComp empWageBuilder = new EmployeeWageComp();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 2, 20);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 14, 40);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total wage for Dmart is: " + empWageBuilder.GetTotalWage("Dmart"));
            Console.ReadKey();
        }
    }

    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        void ComputeEmpWage();
    }

    public interface IComputeWageV2
    {
        int GetTotalWage(string company);
    }

}
