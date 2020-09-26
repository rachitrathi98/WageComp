using System;

namespace WageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int check = r.Next(0, 2);
            if (check == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
    }
}
