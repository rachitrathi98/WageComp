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
            int monthWorkHrs = 0;
            int maxMonthWorkHrs = 100;
            Random r = new Random();

           
            for(int i = 0; i < workingDays; i++)
            {
                if (monthWorkHrs < maxMonthWorkHrs)
                {
                    int check = r.Next(0, 2);
                    if (check == 1)
                    {
                        dailyWages = wagePerHour * empHrs * check;
                        monthWorkHrs = monthWorkHrs + empHrs*check;
                    }
                    else
                    {
                        dailyWages = wagePerHour * empHrs * check;
                        monthWorkHrs = monthWorkHrs + empHrs*check;

                    }
                    monthlyWages = monthlyWages + dailyWages;

                }
                else
                {
                    Console.WriteLine("Reached Maximum Working Hours");
                }

            }
            Console.WriteLine("The monthly wages are " + monthlyWages);
                      

        }
    }
}




