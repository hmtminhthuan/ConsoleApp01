using System;

namespace ConsoleApp01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30; double d = 12.5;
            Console.WriteLine($"Sum = {Add(a,b,d)}");
            Console.WriteLine($"Sum of Serials = {sumOfSerials(a)}");
            Console.WriteLine($"Sum of Serials By Loop = {sumOfSerialsByLoop(a)}");
            Console.WriteLine($"Sum of Fibonacci = {findFibonacci(8)}");
            Console.ReadLine();
        }
        // $" ": string interpolation

        public static int Add(int x, int y) => x + y;
        // int default = int32
        // overloading: nạp chồng/quá tải (cùng tên hàm, có thể khác kiểu dữ liệu, khác số lượng tham số)
        public static double Add(double x, double y) => x + y;
        public static double Add(int x, int y, double z) => Add(Add(x,y),z);

        /*
         Required: Sum of serials: 1+2...+n
        + loop
        + recursion
        */
        public static long sumOfSerials(int n)
        {
            if (n <= 0) return 0;
            return n%2==0 ? (sumOfSerials(n-1)+n) : sumOfSerials(n-1);
        }

        public static long sumOfSerialsByLoop(int n)
        {
            long total = 0;
            int i = 0;
            // while, do while, for, foreach
            while (i <= n) { 
                if(i%2==0) total += i; 
                i++; 
                // toan tu 1 ngoi: unary : +=, ++
            }
            return total;
        }

        public static long findFibonacci(int n)
        {
            if (n <= 1) return 1;
            return findFibonacci(n-1)+findFibonacci(n-2);
        }

    }
}