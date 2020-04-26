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

                Console.WriteLine("Bubble");
                NumList.bubbleSort();
                NumList.sortCheck();
                NumList.print();
                NumList.br();
                Console.ReadLine();
                Console.Clear();

                NumList.randomize();


                //Console.WriteLine("BOGO");
                //NumList.bogoSort();
                //NumList.sortCheck();
                //NumList.print();
                //Console.ReadLine();
            }
        }
    }

    class NumList
    {
        // settings
        static int length = 10;
        static int lowerBound = 1;
        static int upperBound = 100;

        // private variables
        private int[] nums = new int[length];
        private Random rand = new Random();


        // constructor
        public NumList()
        {
            this.randomize();
        }

        // array mixer
        public void randomize()
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] = rand.Next(lowerBound, upperBound);
        }

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
        public void br()
        {
            Console.WriteLine("--------------------------");
        }

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

        public void bubbleSort()
        {
            int temp;

            // to iterate the sort multiple times
            for (int t = 0; t < nums.Length-1; t++)
            {
                // to move the values to their spot
                for (int i = 1; i < nums.Length-1; i++)
                {
                    if (nums[i-1] > nums[i])          
                    {
                        temp = nums[i-1];
                        nums[i-1] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        // TODO
        public void bucketSort()
        {
            // TODO BucketSort algorithm
        }

        public void bogoSort()
        {
            int iterations = 0;

            // checks if the iteration is sorted
            while (traverse(nums.Length, nums) != true)
            {
                // temporary array to rearrange variables
                int[] tempArray = new int[nums.Length];
                int tempVar = 0;

                // fill each slot in the array from 0 -> nums.Length
                for (int i = 0; i < nums.Length; i++)
                {
                    // repeats until slot is filled
                    while (tempArray[i] == 0)
                    {
                        // randomizes which slot
                        tempVar = rand.Next(0, nums.Length);

                        if (nums[tempVar] != -1)
                        {
                            // move random variable into the new array
                            tempArray[i] = nums[tempVar];

                            // remove old slot from the pool of choices
                            nums[tempVar] = -1;
                        }
                    }
                }

                // point to new array
                nums = tempArray;

                // !!Only print if you want to watch it compute!!
                //print();

                iterations++;
            }
            br();
            Console.WriteLine("Completed after: {0} iterations", iterations);
            br();
        }

        // TODO
        public void countingSort()
        {
            // TODO CountingSort algorithm
        }

        // TODO
        public void heapSort()
        {
            // TODO HeapSort algorithm
        }

        // TODO
        public void insertionSort()
        {
            // TODO InsertionSort algorithm
        }

        // TODO
        public void mergeSort()
        {
            // TODO MergeSort algorithm
        }

        // TODO
        public void radixSort()
        {
            // TODO RadixSort algorithm
        }

        // TODO
        public void selectionSort()
        {
            // TODO SelectionSort algorithm
        }

        // TODO
        public void shellSort()
        {
            // TODO ShellSort algorithm
        }

        // TODO
        public void quickSort()
        {
            // TODO QuickSort algorithm
        }
    }
}
// Created by Lucas Stoltman 2020