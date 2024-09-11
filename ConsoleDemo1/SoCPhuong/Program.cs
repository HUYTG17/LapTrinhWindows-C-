using System;

namespace Demo
{
    class Program
    {
       /* static bool IsPerfectSquare(int n)
        {
            int a = (int)Math.Sqrt(n);
            if(a * a == n)
            {
                return true;
            } else
            {
                return false;
            }
        } */
       static void IsPerfectSquare(int n)
        {
            int a = (int)Math.Sqrt(n);
            if(a * a == n)
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            /*if (IsPerfect(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }*/
            IsPerfectSquare(n);
            Console.ReadLine();
        }
    }
}