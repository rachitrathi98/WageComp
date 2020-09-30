using System;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    public class EmployeeWageComp
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.addCompanyEmpWage("Reliance", 20, 10, 50);
            program.addCompanyEmpWage("Tata", 20, 10, 50);
            program.computeWage();

        }
    }
}
