using System;

namespace Demo
{
    class PhanSo
    {
        public int x { get; set; }
        public int y { get; set; }

        public PhanSo()
        {
            x = 0;
            y = 1;
        }
        public PhanSo(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        public void Display()
        {
            int gcd = UCLN(x, y);
            Console.WriteLine($"{x / gcd}/{y / gcd}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PhanSo[] Mps = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] divide = input.Split(' ');
                int[] a = Array.ConvertAll(divide, int.Parse);
                Mps[i] = new PhanSo(a[0], a[1]);
            }
            for(int i = 0; i < n; i++)
            {
                Mps[i].Display();
            }
            Console.ReadKey();
        }
    }
}