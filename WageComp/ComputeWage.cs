using System;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    class ComputeWage
    {
        public string company;
        public int wagePerHr;
        public int workDays;
        public int maxMonHr;
        public int totalEmpWage;

        public ComputeWage(String company, int wagePerHr, int workDays, int maxMonHr)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.workDays = workDays;
            this.maxMonHr = maxMonHr;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
