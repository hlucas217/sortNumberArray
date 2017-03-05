using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_a_Random_Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // print out the numbers in order
            // by ordering the array and printing the array


            // This type of solution to repeatedly swap adjacent elements using two nested loops is called a "bubble sort"
            int[] unsorted = { 3, 6, 2, 3, 7, 1, 9, 3, 2 };
            int tempNum = 0;
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[i])
                    {
                        tempNum = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = tempNum;
                    }
                }
            }
            for (int i = 0; i < unsorted.Length; i++) // this loop just shows the user what has been done with the array
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.ReadLine();




            //// This is an alternative way without using a temporary storage area (new variable) *Good interview question!!!
            //int[] unsorted = { 3, 6, 2, 3, 7, 1, 9, 3, 2 };
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    for (int j = i + 1; j < unsorted.Length; j++)
            //    {
            //        if (unsorted[j] < unsorted[i])
            //        {
            //            unsorted[i] = unsorted[i] + unsorted[j];
            //            unsorted[j] = unsorted[i] - unsorted[j];
            //            unsorted[i] = unsorted[i] - unsorted[j];
            //        }
            //    }
            //}
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    Console.Write(unsorted[i] + " ");
            //}

            //Console.ReadLine();




            // This was the way I started doing but was unsuccessful...

            //int storageNum = 0;
            //int compareNum;

            //// The array below is declared differently than this alternative way ---> int[] unsorted = new int[9];

            //int[] unsorted = { 3, 6, 2, 3, 7, 1, 9, 3, 2, };


            //var i = 1;
            //var compareLoop = true;

            //while (compareLoop)
            //{
            //    i = i + 1;

            //    if (unsorted[5] == )
            //    {
            //        compareLoop == false;
            //    }


            //    if (unsorted[i] > unsorted[i + 1])
            //    {
            //        storageNum = unsorted[i]; // first array number goes to storage
            //        unsorted[i] = unsorted[i + 1] // second array number goes to first position in array
            //        unsorted[i + 1] = storageNum; // storage number goes to second position in the array
            //    }
            //}

            Console.ReadLine();

            
        }
    }
}
