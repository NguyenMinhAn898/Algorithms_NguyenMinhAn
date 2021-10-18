using System;
/*
 * Sắp xếp nổi bọt dãy tăng dần 
 */
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 11, 2, 8, 15, 7, 22, 3, 14 };

            BubbleSort(arr);

            display(arr);
        }

        static void BubbleSort(int[] ar)
        {
            for(int i =0; i < ar.Length -1; i++)
            {
                //bool swapped = true;
                for(int j = 0; j < ar.Length - 1 - i; j++)
                {
                    if(ar[j] > ar[j + 1])
                    {
                        int temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;

                        //swapped = false;
                    }
                }
                //if (swapped)
                //{
                //    break;
                //}
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
