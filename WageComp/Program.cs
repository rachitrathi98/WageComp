using System;

namespace WageComp
{
    class Program
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Problem");

            compEmpWage("Reliance", 20, 20, 100);//Company Name, Wage per hour, Working days, Max monthly hours
            compEmpWage("Tata", 20, 10, 50);

        }

        public static void compEmpWage(String company, int wagePerHr, int workDays, int maxMonHr)
        {
            int monthlySalary = 0; int totalWorkingDays = 0; int totalEmpHrs = 0;
            while (totalEmpHrs < maxMonHr && totalWorkingDays < workDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = random.Next(1, 4);
                int empHrs = getWorkingHrs(rand);
                totalEmpHrs = totalEmpHrs + empHrs;

            }
            monthlySalary = wagePerHr * totalEmpHrs;
            Console.WriteLine("Total Salary of " + company + " employee in the month is " + monthlySalary);
        }
        public static int getWorkingHrs(int check)
        {
            int empHrs = 0;
            switch (check)
            {
                case PART_TIME:
                    empHrs = 4;
                    break;
                case FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            return empHrs;
        }
    }
}



