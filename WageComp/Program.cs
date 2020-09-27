using System;

namespace WageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagePerHour = 20;
            int empHrs=8;
            int workingDays = 20;
            int monthlyWages=0;
            int dailyWages;

            Random r = new Random();

           
            for(int i = 0; i < workingDays; i++)
            {
                int check = r.Next(0, 2);
                if (check == 1)
                {
                    dailyWages = wagePerHour * empHrs*check;
                }
                else
                {
                    dailyWages = wagePerHour * empHrs*check;
                }
                monthlyWages = monthlyWages + dailyWages;
            }
            Console.WriteLine("The monthly wages are " + monthlyWages);
                      

        }
    }
}
