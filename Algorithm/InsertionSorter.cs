using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithm
{
    public static class InsertionSorter
    {
        public static void DoInsertionSort(this int[] numbers)
        {
            for(int i=1; i<numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j-1] > numbers[j]; j--)
                {
                    numbers.SwapValueAtIndices(j, j - 1);
                }
            }
        }

        public static void TestInsertionSort()
        {
            int[] numbers = { 2, 4, 3, 1, 5 };

            numbers.DoInsertionSort();

            foreach(int number in numbers)
                Console.Write(number + " ");
        }
    }
}
