using System;

namespace filip2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, reverse=0, reverse2 = 0, rem;
            Console.WriteLine("skriv in ett tresiffrigt heltal");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv in ett annat tresiffrigt heltal");
            n2 = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /=10;

                rem = n2 % 10;
                reverse2 = reverse2 * 10 + rem;
                n2 /= 10;
            }
            
            if(reverse<reverse2)
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
