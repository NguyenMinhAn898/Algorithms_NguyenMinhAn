using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bai 22");

            Console.Write("Nhap so tien : ");
            double money = double.Parse(Console.ReadLine());
            Console.Write("\nNhap lai suat : ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Tinh theo de quy: ");
            Console.WriteLine(calMonth2(money, rate));

            Console.Write("Tinh khong de quy: ");
            Console.WriteLine(calMonth(2*money, rate));
        }

        /*
         * Using Recursion
         * Lượng thay đổi lãi và gốc bằng lượng gốc
         */
      
        static int calMonth(double money, double rate)
        {
            int temp = money * rate;
            if(money <= 0)
            {
                return 0;
            }
            return calMonth(money - (money*(1+rate/100), rate) + 1;
        }

        /*
         * No Using Recursion
         */
        static int calMonth2(double money, double rate)
        {
            int month = 0;
            double m = money;
            while(m <= 2 * money)
            {
                m = m + m * rate / 100;
                month++;
            }
            return month;
        }
    }
}
