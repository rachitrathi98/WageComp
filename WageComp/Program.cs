using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace WageComp
{
    public class Program
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        private ComputeWage[] computeWageArray;
        private int noOfCompany = 0;

         public Program()
        {
            this.computeWageArray = new ComputeWage[5];
        }
        public void addCompanyEmpWage(String company, int wagePerHr, int workDays, int maxMonHr)
        {
            computeWageArray[this.noOfCompany] = new ComputeWage(company, wagePerHr, workDays, maxMonHr);

            noOfCompany++;
        }
        public void computeWage()
            {
                for(int i = 0; i < noOfCompany; i++)
                {
                computeWageArray[i].setTotalEmpWage(this.computeWage(this.computeWageArray[i]));
                    Console.WriteLine(this.computeWageArray[i].toString());
                }
            }

        private int computeWage(ComputeWage compEmpWage)
        {
            int totalWorkingDays = 0; int totalEmpHrs = 0; 
            while (totalEmpHrs < compEmpWage.maxMonHr && totalWorkingDays < compEmpWage.workDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = random.Next(1, 4);
                int empHrs = getWorkingHrs(rand);
                totalEmpHrs = totalEmpHrs + empHrs;

            }
            return compEmpWage.wagePerHr * totalEmpHrs;
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





