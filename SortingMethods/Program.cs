// Created by Lucas Stoltman 2020

using System;

namespace SortingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Thing!");

            NumList NumList = new NumList();

            while (true)
            {
                NumList.sortCheck();
                NumList.print();
                Console.ReadLine();

                NumList.randomize();

                //NumList.bubbleSort();
                //NumList.sortCheck();
                //NumList.print();
                //Console.ReadLine();
            }
        }
    }

    class NumList
    {
        // settings
        static int length = 7;
        static int lowerBound = 0;
        static int upperBound = 100;

        // private variables
        private int[] nums = new int[length];

        // constructor
        public NumList()
        {
            this.randomize();
        }

        // array mixer
        public void randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(lowerBound, upperBound);
            }
        }

        // print
        public void print()
        {
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length-1)
                    Console.Write(" {0} ", nums[i]);
                else
                    Console.Write(" {0},", nums[i]);
            }
            Console.Write("]\n\n\n\n");
        }

        // to break up output
        static void br()
        {
            Console.WriteLine("--------------------------");
        }

        // sort checker
        public void sortCheck()
        {
            if (traverse(nums.Length, nums) == true)
                Console.WriteLine("SORTED");
            if (traverse(nums.Length, nums) == false)
                Console.WriteLine("NOT SORTED");
        }

        private bool traverse(int arraySize, int[] array)
        {
            // base case
            // if the array has at most 1 element
            if (arraySize <= 1)
                return true;

            // recursive case
            // compare the last element to the one before it
            if (array[arraySize - 1] >= array[arraySize - 2])
                return traverse(arraySize - 1, array);

            return false;
        }


        // --------------------------------------------
        // different sorts below
        // --------------------------------------------

        // TODO
        public void bubbleSort()
        {
            int temp;

            // to iterate the sort multiple times
            for (int t = 0; t < nums.Length-1; t++)
            {
                // to move the values to their spot
                for (int i = 1; i < nums.Length-1; i++)
                {
                    if (nums[i-1] > nums[i])          // TODO i+1 is a problem
                    {
                        temp = nums[i];
                        nums[i-1] = nums[i];          // TODO i+1 is a problem
                        nums[i + 1] = temp;
                    }
                }
            }
        }

        public void bucketSort()
        {
            // TODO BucketSort algorithm
        }

        // TODO needs to randomize WITH the numbers in it.
        public void bogoSort()
        {
            // if not sorted, randomize.
            while (traverse(nums.Length, nums) != true)
                this.randomize();
        }

        public void countingSort()
        {
            // TODO CountingSort algorithm
        }

        public void heapSort()
        {
            // TODO HeapSort algorithm
        }

        public void insertionSort()
        {
            // TODO InsertionSort algorithm
        }

        public void mergeSort()
        {
            // TODO MergeSort algorithm
        }

        public void radixSort()
        {
            // TODO RadixSort algorithm
        }

        public void selectionSort()
        {
            // TODO SelectionSort algorithm
        }

        public void shellSort()
        {
            // TODO ShellSort algorithm
        }

        public void quickSort()
        {
            // TODO QuickSort algorithm
        }
    }
}
// Created by Lucas Stoltman 2020