using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //first loop (outer loop)
            for (int i = 0; i <= 5; i++)
            {
                //second loop (inner loop)
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine("j value: {0}", j);
                }
            }
            Console.ReadLine();
        }
    }
}
