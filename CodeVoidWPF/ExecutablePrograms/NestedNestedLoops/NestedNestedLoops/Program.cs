using System;

namespace Loop
{
    class NestedLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;

            //first loop init (outer)
            while (i <= 5)
            {
                //second loop init (inner)
                for (int j = 1; j <= i; j++)
                {   
                    //Iterations
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                //Incrementation
                i++;
            }
            Console.ReadLine();
        }
    }
}