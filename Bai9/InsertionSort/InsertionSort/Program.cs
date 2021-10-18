using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 5, 38, 5, 7, 1, 6, 3, 5 };
            insertionSort(arr);
        }

        static void insertionSort(int[] arr)
        {
            int valueInsert;
            int holePosition;
            int i;

            for(i = 1; i < arr.Length; i++)
            {
                valueInsert = arr[i];
                holePosition = i;

                while(holePosition > 0 && arr[holePosition-1] > valueInsert)
                {
                    arr[holePosition] = arr[holePosition - 1];
                    holePosition--;
                }

                if(holePosition != i)
                {
                    arr[holePosition] = valueInsert;
                }
            }
        }
    }
}
