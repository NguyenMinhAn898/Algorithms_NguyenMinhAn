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
            Console.WriteLine(tinhLai(money, rate));
        }

        static double tinhLai(double money,double rate)
        {
            double tongGocLai = 0;
            int month = 1;
            for(int i = month; i < 1000; i++)
            {
                tongGocLai = calMonth(money, rate, month);
                if(tongGocLai >= 2 * money)
                {
                    break;
                }
                month++;
            }
            return month;
        }

        /*
         * Using Recursion
         * Lượng thay đổi lãi và gốc bằng lượng gốc
         */
      
        static double calMonth(double money, double rate, int month)
        {
            if(month == 0)
            {
                return money;
            }
            return calMonth(money, rate, month-1) + calMonth(money,rate,month-1)*(rate/100);
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
