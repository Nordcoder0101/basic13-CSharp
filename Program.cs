using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void printNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void printOddNumbers()
        {
            for (int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void printSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }

        public static void iterateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("{0} is the max number", max);
        }

        public static void getAverage(int[] arr)
        {
            int sum = 0;
            foreach (int n in arr)
            {
                sum += n;
            }
            int average = (sum / arr.Length);
            Console.WriteLine("The average of the array is {0}", average);
        }

        public static int[] makeArray()
        {
            List<int> newlist = new List<int>();
            for (int i = 1; i < 256; i +=2)
            {   
                newlist.Add(i);
            }
            int[] returnedArray = newlist.ToArray();
            foreach (int n in returnedArray)
            {
                Console.WriteLine(n);
            }
            return returnedArray;
        }

        public static int greaterThanY(int[] arr, int y)
        {
            int counter = 0;
            foreach (int i in arr)
            {
                if (i > y)
                {
                    counter ++;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }

        public static int[] squareTheArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

        public static int[] removeNegatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                    
                }
            Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static void minMaxAverage(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                
            {
                sum += arr[i];

                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int average = (sum / arr.Length);
            Console.WriteLine("The max is {0}, the min is {1}, the average is {2}", max, min, average);
        }

        public static int[] shiftValues(int[] arr)
        {
            for (int i = 0; i < arr.Length -1; i++)
            {
                arr[i] = arr[i+1];                
            }
            arr[arr.Length - 1] = 0;
            return arr;
        }

        public static object[] numberToString(int[] arr)
        {
            object[] array = new object[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    array[i] = "Dojo";
                }
                else
                {
                    array[i] = arr[i];
                }
            }
            foreach (var n in array)
            {
                Console.WriteLine(n);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = {-1, 2, 3, 4, 5};
            int[] nextArray = { -1, 2, 3, 4, 5};
            int[] anotherArray = {-1, 1, -3, 4};
            printNumbers();
            printOddNumbers();
            printSum();
            iterateArray(array);
            findMax(array);
            getAverage(array);
            makeArray();
            greaterThanY(array, 3);
            squareTheArray(array);
            removeNegatives(nextArray);
            minMaxAverage(nextArray);
            shiftValues(nextArray);
            numberToString(anotherArray);
        }
    }
}
