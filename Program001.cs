using System;
using System.Text;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chương trình C#";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            School.BTBuoi3 callBTBuoi3 = new BTBuoi3();






            Console.ReadKey();
        }
    }
    public class BTBuoi3
    {
        public void bai1()
        {
            Console.WriteLine("Nhập vào hai biến số nguyên");
            Console.Write("Số thứ nhất: ");
            if (!(Int32.TryParse(Console.ReadLine(), out int i1)))
            {
                Console.WriteLine("Dữ liệu số thứ nhất không hợp lệ");
                goto end;
            }
            Console.Write("Số thứ hai: ");
            if (!(Int32.TryParse(Console.ReadLine(), out int i2)))
            {
                Console.WriteLine("Dữ liệu số thứ hai không hợp lệ");
                goto end;
            }
            if (i1 > i2)
            {
                int temp = i1;
                i1 = i2;
                i2 = temp;
            }
            Console.WriteLine($"Số thứ nhất: {i1}, số thứ hai {i2}");
            end:;
        }
        public void bai2()
        {
            Console.WriteLine("Nhập vào ba số thực");
            Console.Write("Số thực thứ nhất: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f1)))
            {
                Console.WriteLine("Dữ liệu số thực thứ nhất không hợp lệ");
                goto end;
            }
            Console.Write("Số thực thứ hai: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f2)))
            {
                Console.WriteLine("Dữ liệu số thực thứ hai không hợp lệ");
                goto end;
            }
            Console.Write("Số thực thứ ba: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f3)))
            {
                Console.WriteLine("Dữ liệu số thực thứ ba không hợp lệ");
                goto end;
            }
            int count = 0;
            if (f1 < 0) count++;
            if (f2 < 0) count++;
            if (f3 < 0) count++;
            if (f1 == 0 || f2 == 0 || f3 == 0)
            {
                Console.WriteLine($"Tích của ba số thực {f1} {f2} {f3} bằng 0");
                goto end;
            }
            if (count == 1 || count == 3) Console.WriteLine($"Tích của ba số thực {f1} {f2} {f3} có dấu âm");
            if (count == 2 || count == 0) Console.WriteLine($"Tích của ba số thực {f1} {f2} {f3} có dấu dương");
            end:;
        }
        public void bai3()
        {
            Console.WriteLine("Nhập vào ba số nguyên");
            Console.Write("Số nguyên thứ nhất: ");
            if (!(Int32.TryParse(Console.ReadLine(), out int i1)))
            {
                Console.WriteLine("Dữ liệu số nguyên thứ nhất không hợp lệ");
                goto end;
            }
            Console.Write("Số nguyên thứ hai: ");
            if (!(Int32.TryParse(Console.ReadLine(), out int i2)))
            {
                Console.WriteLine("Dữ liệu số nguyên thứ hai không hợp lệ");
                goto end;
            }
            Console.Write("Số nguyên thứ ba: ");
            if (!(Int32.TryParse(Console.ReadLine(), out int i3)))
            {
                Console.WriteLine("Dữ liệu số nguyên thứ ba không hợp lệ");
                goto end;
            }
            int max = i1;
            if (i1 < i2)
            {
                max = i2;
                if (i2 < i3) max = i3;
            }
            else
            {
                if (i1 < i3) max = i3;
            }
            Console.WriteLine($"Số lớn nhất trong ba số nguyên là: {max}");
            end:;
        }
        public void bai4()
        {
            Console.WriteLine("Nhập vào ba số thực");
            Console.Write("Số thực thứ nhất: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f1)))
            {
                Console.WriteLine("Dữ liệu số thực thứ nhất không hợp lệ");
                goto end;
            }
            Console.Write("Số thực thứ hai: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f2)))
            {
                Console.WriteLine("Dữ liệu số thực thứ hai không hợp lệ");
                goto end;
            }
            Console.Write("Số thực thứ ba: ");
            if (!(Single.TryParse(Console.ReadLine(), out float f3)))
            {
                Console.WriteLine("Dữ liệu số thực thứ ba không hợp lệ");
                goto end;
            }
            float max = f1, mid, min;
            if (f1 < f2)
            {
                max = f2;
                if (f2 < f3)
                {
                    max = f3;
                    mid = f2;
                    min = f1;
                }
                else
                {
                    if (f1 < f3)
                    {
                        mid = f3;
                        min = f1;
                    }
                    else
                    {
                        mid = f1;
                        min = f3;
                    }
                }
            }
            else
            {
                min = f2;
                if (f1 < f3)
                {
                    max = f3;
                    mid = f1;
                }
                else
                {
                    max = f1;
                    if (f2 < f3)
                    {
                        mid = f3;
                    }
                    else
                    {
                        mid = f2;
                        min = f3;
                    }
                }
            }
            Console.WriteLine($"Thứ tự giảm dần của ba số thực là: {max} > {mid} > {min}");
            end:;
        }
        public void bai5()
        {
            Console.Write("Nhập một chữ số nguyên từ 0 đến 9: ");
            string sNumber = Console.ReadLine();
            if (Int32.TryParse(sNumber, out int number))
            {
                if (number < 0 || number > 9)
                {
                    Console.WriteLine($"Dữ liệu bạn nhập \"{sNumber}\" không nằm trong giới hạn (0 -> 9)");
                }
                else
                {
                    Console.Write($"Từ tiếng Anh tương ứng với {number} là: ");
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("Zero");
                            break;
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Dữ liệu bạn nhập \"{sNumber}\" không hợp lệ");
            }
        }
        public void bai6()
        {
            Console.WriteLine("Vui lòng nhập năm số từ bàn phím");
            string[] sArr = new string[5];
            int[] iArr = new int[5];
            int check = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Số thứ {i + 1} là: ");
                sArr[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                if (!(Int32.TryParse(sArr[i], out iArr[i]))) Console.WriteLine($"Dữ liệu số thứ {i + 1} không hợp lệ!"); 
                else check += 1;
            }
            if (check != 5) goto end;
            Array.Sort(iArr);
            Console.WriteLine("Số lớn nhất trong năm số là: {0}", iArr[4]);
            end:;
        }
        public void bai7()
        {
            Console.Write("Nhập điểm: ");
            var sPoint = Console.ReadLine();
            int iPoint = 0;
            switch (sPoint)
            {
                case "1":
                    iPoint = 1 * 10;
                    break;
                case "2":
                    iPoint = 2 * 10;
                    break;
                case "3":
                    iPoint = 3 * 10;
                    break;
                case "4":
                    iPoint = 4 * 100;
                    break;
                case "5":
                    iPoint = 5 * 100;
                    break;
                case "6":
                    iPoint = 6 * 100;
                    break;
                case "7":
                    iPoint = 7 * 1000;
                    break;
                case "8":
                    iPoint = 8 * 1000;
                    break;
                case "9":
                    iPoint = 9 * 1000;
                    break;
                default: 
                    Console.WriteLine("Điểm bạn nhập không hợp lệ!!");
                    break;
            }
            if (iPoint != 0)
            {
                Console.WriteLine($"Điểm thưởng là: {iPoint}");
            }
        }
        public void bai8()
        {
            Console.Write("Nhập một số nguyên dương từ 0 đến 999: ");
            string sNumber = Console.ReadLine();
            int number;
            if (!(Int32.TryParse(sNumber, out number) && (number >= 0 && number <= 999)))
            {
                Console.WriteLine($"Dữ liệu nhập vào \"{sNumber}\" không hợp lệ");
                goto end;
            }
            int units = 0, dozens = 0, hundreds = 0;
            units = number % 10;
            number /= 10;
            dozens = number % 10;
            number /= 10;
            hundreds = number % 10;

            switch (hundreds)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("một trăm ");
                    break;
                case 2:
                    Console.Write("hai trăm ");
                    break;
                case 3:
                    Console.Write("ba trăm ");
                    break;
                case 4:
                    Console.Write("bốn trăm ");
                    break;
                case 5:
                    Console.Write("năm trăm ");
                    break;
                case 6:
                    Console.Write("sáu trăm ");
                    break;
                case 7:
                    Console.Write("bảy trăm ");
                    break;
                case 8:
                    Console.Write("tám trăm ");
                    break;
                case 9:
                    Console.Write("chín trăm ");
                    break;

            }
            switch (dozens)
            {
                case 0:
                    if (units != 0 && hundreds != 0) Console.Write("lẻ ");
                    break;
                case 1:
                    Console.Write("mười ");
                    break;
                case 2:
                    Console.Write("hai mươi ");
                    break;
                case 3:
                    Console.Write("ba mươi ");
                    break;
                case 4:
                    Console.Write("bốn mươi ");
                    break;
                case 5:
                    Console.Write("năm mươi ");
                    break;
                case 6:
                    Console.Write("sáu mươi ");
                    break;
                case 7:
                    Console.Write("bảy mươi ");
                    break;
                case 8:
                    Console.Write("tám mươi ");
                    break;
                case 9:
                    Console.Write("chín mươi ");
                    break;
            }
            switch (units)
            {
                case 0:
                    break;
                case 1:
                    if (dozens == 1 || dozens == 0) Console.WriteLine("một"); else Console.WriteLine("mốt");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine("bốn");
                    break;
                case 5:
                    if (dozens == 0) Console.WriteLine("năm"); else Console.WriteLine("lăm");
                    break;
                case 6:
                    Console.WriteLine("sáu");
                    break;
                case 7:
                    Console.WriteLine("bảy");
                    break;
                case 8:
                    Console.WriteLine("tám");
                    break;
                case 9:
                    Console.WriteLine("chín");
                    break;
            }
            end:;
        }
    }
}
