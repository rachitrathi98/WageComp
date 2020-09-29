using System;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    public class EmployeeWageComp
    {
        static void Main(string[] args)
        {
            Program reliance = new Program("Reliance", 20, 20, 100);
            reliance.computeWage();
            Console.WriteLine(reliance.toString());
            Program Tata = new Program("Tata", 20, 10, 50);
            Tata.computeWage();
            Console.WriteLine(Tata.toString());


        }
    }
}
