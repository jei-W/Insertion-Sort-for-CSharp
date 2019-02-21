using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] arg = { 5, 9, 7, 24, 0, 8, 3, 7 };

            Print();

            InsertionSort.AscendingSort(arg);
            Print();

            InsertionSort.DescendingSort(arg);
            Print();


            void Print()
            {
                foreach( int i in arg )
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
