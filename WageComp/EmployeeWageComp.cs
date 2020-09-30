using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    public class EmployeeWageComp : IComputeWage, IComputeWageV2
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private List<ComputeWage> companyEmpWagesList = new List<ComputeWage>();
        private Dictionary<string, ComputeWage> companyToEmpWageMap= new Dictionary<string, ComputeWage>();
        
        public EmployeeWageComp()
        {
            //this.companyEmpWagesList = new LinkedList<ComputeWage>();
            //this.companyToEmpWageMap = new Dictionary<string, ComputeWage>();
        }
       

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            ComputeWage companyEmpWage = new ComputeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            //this.companyEmpWagesList.AddLast(companyEmpWage);
            companyToEmpWageMap.Add(company, companyEmpWage);
            companyEmpWagesList.Add(companyEmpWage);
            
        }

        public void ComputeEmpWage()
        {
            foreach (ComputeWage companyEmpWage in companyEmpWagesList)
            {
                int totalEmpWageTemp = this.ComputeEmpWage(companyEmpWage);
                companyEmpWage.SettotalEmpWage(totalEmpWageTemp);
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        public int ComputeEmpWage(ComputeWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours;
            int totalWagePerDay;
            int totalWagePerMonth = 0;
            while (totalEmpHours < companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
            {
                EmployeeWageComp empWageBuilder = new EmployeeWageComp();
                empHours = empWageBuilder.GetWorkingHours();

                if (totalEmpHours == 96)
                {
                    empHours = 4;
                }
                if (empHours != 0)
                {
                    workingDays++;
                    totalEmpHours = empHours + totalEmpHours;
                    totalWagePerDay = empHours * companyEmpWage.ratePerHours;
                    totalWagePerMonth += totalWagePerDay;
                    Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
                }
            }
            return totalWagePerMonth;

        }

        public int GetWorkingHours()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHours = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case FULL_TIME:
                    empHours = 8;
                    break;
                case PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            return empHours;
        }

       public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
      
    }
}