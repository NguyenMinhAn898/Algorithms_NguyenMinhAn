using System;

namespace B21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bai 21");
            Console.Write("Nhap tien gui : ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Nhap so nam gui : ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Su dung de quy tinh");
            Console.WriteLine(callSallary(salary, year));

            Console.WriteLine("Khong su dung de quy tinh");
            Console.WriteLine(callSallary2(salary, year));
        }

        /*
         * Using Recursion
         */
        static double callSallary(double salary, int year)
        {
            if(year == 0)
            {
                return salary;
            }
            return callSallary(salary, year - 1) + callSallary(salary, year - 1) * 0.1;
        }

        /*
         * Not use Recursion
         */
        static double callSallary2(double salary, int year)
        {
            double ouput = salary;
            if(year == 0)
            {
                return salary;
            }
            while(year >= 1)
            {
                ouput += ouput * 0.1;
                year--;
            }
            return ouput;
        }
    }
}
