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
            List<int> numbers = new List<int>()
            {
                1243,
                1131,
                24,
                123,
                2
            };            

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
            Console.WriteLine("Before Sorting");
            numbers2.Print();
            numbers.Contains(2);
            //numbers.SimpleSort();
            //numbers.SimpleSortOptimised();
            //numbers.MergeSort();
            //numbers.BubbleSort();
            //numbers.BubbleSortOptimised();
            numbers2.QuickSort();
            //numbers.InsertionSort();
            //numbers.InsertionSortBookAlgo();
            //numbers2.ShellSort();
            //numbers.Slide(1243, 0, 3);
            Console.WriteLine("After bubble Sorting");
            numbers2.Print();

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
