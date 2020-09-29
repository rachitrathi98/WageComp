using System;

namespace WageComp
{
    class Program
    {
        const int wagePerHour = 20;
        int empHrs = 8;
        int workingDays = 20;
        int monthlyWages = 0;
        int dailyWages;
        int monthWorkHrs = 0;
        const int maxMonthWorkHrs = 100;
        static void Main(string[] args)
        {
            
           
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
        public static int getWorkingHrs()
        {
            Random r = new Random();
        }
    }
}




