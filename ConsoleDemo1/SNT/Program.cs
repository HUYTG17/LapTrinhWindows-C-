using System;

namespace Demo
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(IsPrime(n))
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}