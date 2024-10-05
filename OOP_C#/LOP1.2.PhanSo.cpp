using System;

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
        ~PhanSo(){}
        public void Nhap() {
            string input = Console.ReadLine();
            string[] divide = input.Split(' ');
            int[] a = Array.ConvertAll(divide, int.Parse);
            x = a[0];
            y = a[1];
        }
        public void Xuat() {
            Console.WriteLine($"{x}/{y}");
        }
        public int UCLN(int a, int b) {
            if(b == 0) return a;
            return UCLN(b, a % b);
        }
        public PhanSo RutGon() {
            int gcd = UCLN(Math.Abs(x), Math.Abs(y));
            return new PhanSo(x / gcd, y / gcd);
        }
        public PhanSo PSND() {
            if(x == 0) return new PhanSo(0, 1);
            return new PhanSo(y, x);
        }
        public static PhanSo operator +(PhanSo a, PhanSo b) {
            PhanSo kq = new PhanSo();
            kq.x = a.x * b.y + a.y * b.x;
            kq.y = a.y * b.y;
            return kq.RutGon();
        }
        public static PhanSo operator -(PhanSo a, PhanSo b) {
            PhanSo kq = new PhanSo();
            kq.x = a.x * b.y +- a.y * b.x;
            kq.y = a.y * b.y;
            return kq.RutGon();
        }
        public static PhanSo operator *(PhanSo a, PhanSo b) {
            PhanSo kq = new PhanSo();
            kq.x = a.x * b.x;
            kq.y = a.y * b.y;
            return kq.RutGon();
        }
        public static PhanSo operator /(PhanSo a, PhanSo b) {
            PhanSo kq = new PhanSo();
            kq.x = a.x * b.y;
            kq.y = a.y * b.x;
            return kq.RutGon();
        }
        public static bool operator > (PhanSo a, PhanSo b) {
            return a.x * b.y > a.y * b.x;
        } 
        public static bool operator < (PhanSo a, PhanSo b) {
            return a.x * b.y < a.y * b.x;
        }
        public static bool operator >= (PhanSo a, PhanSo b) {
            return a.x * b.y >= a.y * b.x;
        }
        public static bool operator <= (PhanSo a, PhanSo b) {
            return a.y * b.x <= a.x * b.y;
        }
    }
    class Program {
    static void Main(string[] args) {
            PhanSo p = new PhanSo();
            p.Nhap();
            p.Xuat();
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            PhanSo nd = p.PSND();
            nd.Xuat();
            PhanSo rg = p.RutGon();
            rg.Xuat();
            PhanSo tong = p + nd;
            tong.Xuat();
            Console.ReadKey();
        }
    }
}