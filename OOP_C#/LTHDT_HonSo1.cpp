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
        public void XuatPS() {
            Console.WriteLine($"{x}/{y}");
        }
        public static PhanSo operator +(PhanSo a, PhanSo b) {
            PhanSo kq = new PhanSo();
            kq.x = a.x * b.y + a.y * b.x;
            kq.y = a.y * b.y;
            return kq;
        }
    }
    class HonSo : PhanSo {
        public int nguyen { get; set; }
        
        public HonSo() : base(0, 1){
            nguyen = 0;
        }
        public HonSo(int Nguyen, int X, int Y) : base(X, Y) {
            nguyen = Nguyen;
        }
        public void XuatHS() {
            Console.WriteLine($"{nguyen} {x}/{y}");
        }
        public static HonSo operator +(HonSo a, HonSo b) {
            HonSo kq = new HonSo();
            kq.nguyen = a.nguyen + b.nguyen;
            kq.x = a.x * b.y + a.y * b.x;
            kq.y = a.y * b.y;
            return kq;
        }
    }
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] divide = input.Split(' ');
            int[] a = Array.ConvertAll(divide, int.Parse);
            HonSo hs = new HonSo(a[0], a[1], a[2]);
            
            string input2 = Console.ReadLine();
            string[] divide2 = input2.Split(' ');
            int[] b = Array.ConvertAll(divide2, int.Parse);
            HonSo hs1 = new HonSo(b[0], b[1], b[2]);
            //HonSo hs = new HonSo(1, 2, 3);
            //HonSo hs1 = new HonSo(4, 5, 6);
            HonSo kq = hs + hs1;
            kq.XuatHS();
            Console.ReadKey();
        }
    }
}
