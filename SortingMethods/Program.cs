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
                //NumList.randomize();



                Console.ReadLine();
            }
        }
    }

    class NumList
    {
        // settings
        static int length = 3;
        static int lowerBound = 0;
        static int upperBound = 100;

        // private variables
        private int[] nums = { 2, 5, 8 };

        // constructor
        public NumList()
        {
            //nums[0] = 2;
            //nums[1] = 6;
            //nums[3] = 10;
            //this.randomize();
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

        // sort checker TODO Borken :/
        public void sortCheck()
        {
            if (traverse(1) == true )
            {
                br();
                Console.WriteLine("Sorted!");
                br();
            }
            else
            {
                br();
                Console.WriteLine("Not Sorted :(");
                br();

            }
        }

        // to be used in sortCheck()
        public bool traverse(int i)
        {
            // return true if end is reached
            if ( i == nums.Length)
                return true;
            else
            {
                if (nums[i-1] < nums[i])
                {
                    i++;

                    // recursion
                    traverse(i);
                }
                // return false if end isn't reached
                return false;
            }
        } // it's jumping up to traverse(i)...



        // --------------------------------------------
        //sorts below
        // --------------------------------------------

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

        public void bogoSort()
        {
            // if not sorted, randomize.
            if (traverse(0) == false)
            {
                randomize();
                bogoSort();
            }
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