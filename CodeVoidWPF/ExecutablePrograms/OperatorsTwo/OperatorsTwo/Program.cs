using System;
namespace DataType
{
    class Example
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            Console.WriteLine((a > b) && (b < a));
            Console.WriteLine((a > b) || (b < a));
            Console.WriteLine(a != b);
        }
    }
}

