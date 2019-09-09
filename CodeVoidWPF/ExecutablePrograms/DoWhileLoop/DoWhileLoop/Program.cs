using System;
namespace DoWhileLoop
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                i++;
            }
            while (i <= 4);
            Console.WriteLine("Press Enter Key to Exit.." );
            Console.ReadLine();
        }
    }
}