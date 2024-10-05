using System;
using System.Collections.Generic;

namespace Demo {
    class PhanSo {
        public int x { get; set; }
        public int y { get; set; }
        
        public PhanSo() {
            x = 0;
            y = 1;
        }
        public PhanSo(int X, int Y) {
            x = X;
            y = Y;
        }
        public void Display() {
            Console.WriteLine($"{x}/{y}");
        }
    }
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] divide = input.Split(' ');
            int[] a = Array.ConvertAll(divide, int.Parse);
            PhanSo p = new PhanSo(a[0], a[1]);
            p.Display();
            Console.ReadKey();
        }
    }
}