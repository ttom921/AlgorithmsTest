using QuickSort;
using System;

namespace QuickSortTest
{
    class Program
    {
        static int count = 100;
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(1,1000);
            }
            Print(array);
            Console.WriteLine("------------------");
            QuickSortInplace.Sort(array);
            Print(array);
            Console.ReadKey();
        }
        static void Print(int [] array)
        {
            for (int i = 0; i < count; i++)
            {
                string msg = $"{array[i]},";
                Console.Write(msg);
            }
            Console.WriteLine();


        }
    }
}
