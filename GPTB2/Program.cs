using System;

namespace GPTB2
{
    class Program
    {
        // định nghĩa biến cần dùng
        static double a, b, c;
        static double delta;
        static double x1, x2;
        // định nghĩa hàm nhập 3 thông số a,b,c của pt bậc 2
        static void NhapABC()
        {
            String buf;
        L1:
            Console.Write("Nhap a: "); buf = Console.ReadLine();
            a = Double.Parse(buf);
            if (a == 0) goto L1;
            Console.Write("N`hap b: "); buf = Console.ReadLine();
            b = Double.Parse(buf);
            Console.Write("Nhap c: "); buf = Console.ReadLine();
        }
        // định nghĩa hàm tính nghiệm của pt bậc 2
        static void GiaiPT()
        {
            //tính delta của phương trình
            delta = b * b - 4 * a * c;
            //nghiệm thực
            if (delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta) / 2 / a);
                x2 = (-b + Math.Sqrt(delta) / 2 / a);
            }
        }
        // định nghĩa hàm xuất kết quả
        static void XuatKetQua()
        {
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình 2 nghiệm thực");
                Console.WriteLine("X1 =" + x1);
                Console.WriteLine("X2 =" + x2);
            }
        }
        static void Main(string[] args)
        {
            NhapABC();
            GiaiPT();
            XuatKetQua();
            //Chờ người dùng enter để dừng chương trình
            Console.Write("Ấn Enter để dừng chương trình: ");
            Console.Read();
        }
    }//kết thúc class
}//kết thúc namespace
