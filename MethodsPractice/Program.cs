using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the digits for the first array: ");
            int[] arr1 = ArrayInit();

            Console.WriteLine("Enter the digits for the second array: ");
            int[] arr2 = ArrayInit();
            Console.WriteLine();

            Console.WriteLine("First array: ");
            ShowMeYourArray(arr1);
            Console.WriteLine();
            Console.WriteLine("Second array: ");
            ShowMeYourArray(arr2);
            Console.WriteLine();

            Console.WriteLine("Sorted first array: ");
            SortYourArray(arr1);
            Console.WriteLine();
            Console.WriteLine("Sorted second array: ");
            SortYourArray(arr2);
            Console.WriteLine();

            Console.Write("Equal?:");
            EqualOrNot(arr1, arr2);
        }

        static int[] ArrayInit()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static void ShowMeYourArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }
            return;
        }

        static void SortYourArray(int[] array)
        {
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write("{0}\t", i);
            }
        }

        static bool EqualOrNot(params int[][] arrays)
        {
            for (int i = 0; i < arrays[0].Length; i++)
            {
                for (int j = 1; j < arrays.Length; j++)
                {
                    if (arrays[0][i] != arrays[j][i])
                    {
                        Console.WriteLine("NO!");
                        return false;
                    }
                }

            }
            Console.WriteLine("True! They are equal");
            return true;

        }
    }

}