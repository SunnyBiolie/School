namespace TestCase
{
    public abstract class NhanVien
    {
        protected string hoten;
        protected string diachi;
        protected double sogiolam;
        protected double giatrihangban;
        public string Hoten { get => hoten; }
        public string Diachi { get => diachi; }
        public double Sogiolam { get => sogiolam; set => sogiolam = value; }
        public double Giatrihangban { get => giatrihangban; set => giatrihangban = value; }
        public abstract double tienLuong();
    }
    public class NhanVienHopDong : NhanVien
    {
        public NhanVienHopDong(string hoten, string diachi)
        {
            this.hoten = hoten;
            this.diachi = diachi;
        }

        public override double tienLuong()
        {
            double total = 0;
            if (sogiolam <= 192) total = sogiolam * 6000;
            else total = (192 * 6000 + ((sogiolam - 192) * 9000));
            return total;
        }
    }
    public class NhanVienBienChe : NhanVien
    {
        protected double luongcodinh;
        public NhanVienBienChe(string hoten, string diachi, double luongcodinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.luongcodinh = luongcodinh;
        }
        public override double tienLuong()
        {
            return sogiolam * luongcodinh;
        }
    }
    public class NhanVienBienCheHH : NhanVienBienChe
    {
        public NhanVienBienCheHH(string hoten, string diachi, double luongcodinh) : base(hoten, diachi, luongcodinh)
        {
        }
        public override double tienLuong()
        {
            return base.tienLuong() + Giatrihangban * 0.1;
        }
    }
    public class testNhanVien
    {
        public static void Print()
        {
            NhanVien nvHopDong1 = new NhanVienHopDong("Nguyễn Đức Thọ", "39B Phú Thọ");
            NhanVien nvHopDong2 = new NhanVienHopDong("Lê Trung Hiếu", "12A Trần Phú");
            NhanVien nvBienChe = new NhanVienBienChe("Phạm Đức Huy", "28C Lê Lợi", 8000);
            NhanVien nvBienCheHH = new NhanVienBienCheHH("Hồ Minh Vương", "45D Trường Chinh", 7000);
            nvHopDong1.Giatrihangban = 1000000;
            nvHopDong1.Sogiolam = 168;
            nvHopDong2.Giatrihangban = 1200000;
            nvHopDong2.Sogiolam = 204;
            nvBienChe.Giatrihangban = 1500000;
            nvBienChe.Sogiolam = 192;
            nvBienCheHH.Giatrihangban = 2000000;
            nvBienCheHH.Sogiolam = 192;

            Console.WriteLine(
                $"Nhân viên {nvHopDong1.Hoten}, địa chỉ {nvHopDong1.Diachi}, tiền lương được lãnh {nvHopDong1.tienLuong()}\n" +
                $"Nhân viên {nvHopDong2.Hoten}, địa chỉ {nvHopDong2.Diachi}, tiền lương được lãnh {nvHopDong2.tienLuong()}\n" +
                $"Nhân viên {nvBienChe.Hoten}, địa chỉ {nvBienChe.Diachi}, tiền lương được lãnh {nvBienChe.tienLuong()}\n" +
                $"Nhân viên {nvBienCheHH.Hoten}, địa chỉ {nvBienCheHH.Diachi}, tiền lương được lãnh {nvBienCheHH.tienLuong()}"
            );
        }
        
    }
}



// namespace TestCase
// {
//     public abstract class Shape
//     {
//         public abstract double Area();
//         public abstract double Perimeter();
//     }
//     public class Circle : Shape
//     {
//         public static double PI = 3.14;
//         private double _r;
//         public double R { get => _r; }
//         public Circle(double x)
//         {
//             _r = x;
//         }
//         public override double Area()
//         {
//             return Math.Pow(R, 2) * PI;
//         }
//         public override double Perimeter()
//         {
//             return R * 2 * PI;
//         }
//     }
//     public class Triangle : Shape
//     {
//         protected double _a;
//         protected double _b;
//         protected double _c;
//         public double A { get => _a; }
//         public double B { get => _b; }
//         public double C { get => _c; }
//         public Triangle(double a, double b, double c)
//         {
//             _a = a;
//             _b = b;
//             _c = c;
//         }
//         public override double Area()
//         {
//             double x = Perimeter() / 2;
//             return Math.Sqrt(x*(x-A)*(x-B)*(x-C));
//         }
//         public override double Perimeter()
//         {
//             return A + B + C;
//         }
//     }
//     public class Parllelogam : Triangle
//     {
//         public Parllelogam(double a, double b, double c) : base(a, b, c)
//         {
            
//         }
//         public double Area()
//         {
//             return base.Area() * 2;
//         }
//         public double Perimeter()
//         {
//             return base.Perimeter() - C * 2;
//         }
//     }
//     public class Parllelogam2 : Shape
//     {
//         Triangle t;
//         public Parllelogam2(Triangle A)
//         {
//             t = A;
//         }
//         public Parllelogam2(double A, double B, double C)
//         {
//             t = new Triangle(A, B, C);
//         }
//         public override double Area()
//         {
//             return t.Area() * 2;
//         }

//         public override double Perimeter()
//         {
//             return (t.Perimeter() - t.C) * 2;
//         }
//     }
// }