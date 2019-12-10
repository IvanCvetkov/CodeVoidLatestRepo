using System;

namespace Arrays
{
    class Array
    {
        static void Main(string[] args)
        {
            /*Array declaration*/
            int[] n = new int[10];
            int j;

            /*Increments each value by 100*/
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /*Prints all elements of the array*/
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }
    }
}