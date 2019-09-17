using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            //first while loop init
            while (i < 5)
            {
                Console.WriteLine("Value of i: {0}", i);

                //inner variable initialization
                int j = 1;

                i++;

                //second while loop init
                while (j < 5)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                }

                //new line after every time the second while loop iterates from 1 to 4  
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
