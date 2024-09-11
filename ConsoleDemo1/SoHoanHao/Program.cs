using System;

namespace Demo
{
    class Program
    {
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == n)
            {
                return true;
            } else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(IsPerfect(n))
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}