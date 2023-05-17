using System;

namespace ConsoleApp01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30; double d = 12.5;
            Console.WriteLine($"Sum = {Add(a,b,d)}");
            Console.ReadLine();
        }
        // $" ": string interpolation

        public static int Add(int x, int y) => x + y;
        // int default = int32
        // overloading: nạp chồng/quá tải (cùng tên hàm, có thể khác kiểu dữ liệu, khác số lượng tham số)
        public static double Add(double x, double y) => x + y;
        public static double Add(int x, int y, double z) => Add(Add(x,y),z);
        
            
        
            
    }
}