using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSamples.ExtensionMethods;

namespace CSharpSamples.DSAndAlgorithms.Algorithms
{
    public class AlgorithmProgram : IProgram
    {
        public void Run()
        {
            // Simple sort
            List<int> numbers = new List<int>()
            {
                1243,
                1131,
                24,
                123,
                2
            };
            Console.WriteLine("\t Before Simple Sorting");
            numbers.Print();
            numbers.SimpleSort();
            numbers.Print();
            Console.WriteLine("\t After simple Sorting");

            // Quick sort
            List<int> numbers2 = new List<int>()
            {
               89,
               76,
               92,
               67,
               45,
               99,
               12
            };
            Console.WriteLine("Before quick Sorting");
            numbers2.Print();
            numbers2.QuickSort();
            numbers2.Print();
            Console.WriteLine("After quick Sorting");

            // Simple sort optimised
            List<int> numbers3 = new List<int>()
            {
               89,
               76,
               92,
               67,
               45,
               99,
               12
            };
            Console.WriteLine("Before simple sort optimised Sorting");
            numbers3.Print();
            numbers3.SimpleSortOptimised();
            numbers3.Print();
            Console.WriteLine("After simple sort optimised Sorting");

            // Merge sort
            List<int> numbers4 = new List<int>()
            {
               89,
               76,
               92,
               67,
               45,
               99,
               12
            };
            Console.WriteLine("Before merge Sorting");
            numbers4.Print();
            numbers4.MergeSort();
            numbers4.Print();
            Console.WriteLine("After merge Sorting");

            // Bubble sort optimised
            List<int> numbers5 = new List<int>()
            {
               89,
               76,
               92,
               67,
               45,
               99,
               12
            };
            Console.WriteLine("Before bubble sort optimsied");
            numbers5.Print();
            numbers5.BubbleSortOptimised();
            numbers5.Print();
            Console.WriteLine("After bubble sort optimsied");

            // Bubble sort 
            List<int> numbers6 = new List<int>()
            {
               89,
               76,
               92,
               67,
               45,
               99,
               12
            };
            Console.WriteLine("Before bubble sort");
            numbers6.Print();
            numbers6.BubbleSortOptimised();
            numbers6.Print();
            Console.WriteLine("After bubble sort");

            //numbers.InsertionSort();
            //numbers.InsertionSortBookAlgo();
            //numbers2.ShellSort();
            //numbers.Slide(1243, 0, 3);            

            List<string> stringList = new List<string>()
            {
                "B",
                "e",
                "f",
                "o",
                "r",
                "Before Sorting",
                "After bubble Sorting"
            };
            //stringList.Print();
            //stringList.BubbleSort();
            //stringList.Print();
        }

    }
}
