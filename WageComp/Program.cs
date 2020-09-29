using System;

namespace WageComp
{
    class Program
    {
        public const int WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_MONTH_HRS= 100;
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
       
        public static int totalWorkingDays = 0;
        public static int totalEmpHrs = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Problem");
            compEmpWage();
                     

        }

        public static void compEmpWage()
        {
            int monthlySalary = 0;
            while (totalEmpHrs < MAX_MONTH_HRS && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = random.Next(1, 4);
                int empHrs = getWorkingHrs(rand);
                totalEmpHrs = totalEmpHrs + empHrs;

            }
            monthlySalary = WAGE_PER_HOUR * totalEmpHrs;
            Console.WriteLine("Total Salary of the employee in the month is " + monthlySalary);
        }
        public static int getWorkingHrs(int check)
        {
            int empHrs=0;
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




