using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 1, 6, 22, 4, 5, 8, 33, 25, 7, 41, 66 };
            Console.WriteLine("Hello World!");
            selectionSort(arr);
            display(arr);
        }
        static void selectionSort(int[] arr)
        {
            int indexMin;
            for(int i=0; i<arr.Length; i++)
            {
                indexMin = i;
                // tìm vị trí số nhỏ nhất
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[indexMin])
                    {
                        indexMin = j;
                    }
                }

                if(indexMin != i)
                {
                    int temp = arr[indexMin];
                    arr[indexMin] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        static void display(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
