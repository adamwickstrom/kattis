using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a three-digit number");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write another three-digit number");
            int tal2 = int.Parse(Console.ReadLine());
            int reverse = 0;
            int reverse2 = 0;
            while (0 < tal1 && tal1 < 1000)
            {
                int remainder = tal1 % 10;
                reverse = (reverse * 10) + remainder;
                tal1 = tal1 / 10;

            }

            while (0 < tal2 && tal2 < 1000)
            {
                int remainder2 = tal2 % 10;
                reverse2 = (reverse2 * 10) + remainder2;
                tal2 = tal2 / 10;
            }

            if (reverse < reverse2)
            {
                Console.WriteLine(reverse2);
            }

            else
            {
                Console.WriteLine(reverse);

            }



        }
    }
}
