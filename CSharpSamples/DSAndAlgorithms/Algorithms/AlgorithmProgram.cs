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
            Console.WriteLine("Before Sorting");
            numbers.Print();
            //numbers.SimpleSort();
            //numbers.MergeSort();
            numbers.BubbleSort();
            //numbers.QuickSort();
            //numbers.InsertionSort();
            //numbers.InsertionSortBookAlgo();
            //numbers.Slide(1243, 0, 3);
            Console.WriteLine("After bubble Sorting");
            numbers.Print();

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
