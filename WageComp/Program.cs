using System;

namespace WageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagePerHour = 20;
            int empHrs;
            Random r = new Random();

            int check = r.Next(0, 2);
            if (check == 1)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;

            }
            Console.WriteLine("The Wage is not so good third" + empHrs * wagePerHour);

        }
    }
}
