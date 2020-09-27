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

            int check = r.Next(0, 3);
            if (check == 1)
            {
                empHrs = 8;

            }
            else if(check==2)
            {
                empHrs = 4;

            }
            else
            {
                empHrs = 0;
            }
            Console.WriteLine("The daily wage is " + empHrs * wagePerHour);

        }
    }
}
