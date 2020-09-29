using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace WageComp
{
    public class Program
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private string company;
        private int wagePerHr;
        private int workDays;
        private int maxMonHr;
        private int totalEmpWage;

        public Program(String company, int wagePerHr, int workDays, int maxMonHr)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.workDays = workDays;
            this.maxMonHr = maxMonHr;
        }

        public void computeWage()
        {
            int totalWorkingDays = 0; int totalEmpHrs = 0;
            while (totalEmpHrs < maxMonHr && totalWorkingDays < workDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = random.Next(1, 4);
                int empHrs = getWorkingHrs(rand);
                totalEmpHrs = totalEmpHrs + empHrs;

            }
            totalEmpWage = wagePerHr * totalEmpHrs;
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
    public string toString()
    {
        return "Total Emp wage for the company " + company + " is " + totalEmpWage;
    }
    }
}





