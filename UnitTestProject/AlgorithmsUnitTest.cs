using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CSharpSamples.DSAndAlgorithms.Algorithms;

namespace UnitTestProject
{
    [TestClass]
    public class AlgorithmsUnitTest
    {
        [TestMethod]
        [Timeout(3000)]
        public void BinarySearchTest()
        {
            List<int> numbers = new List<int>()
            {
                1243,
                1131,
                24,
                123,
                2
            };
            numbers.SimpleSortOptimised(); // PreCondition
            Assert.AreEqual(4, numbers.BinaryASearch(2));
        }

        [TestMethod]
        [Timeout(1000)]
        public void QuickSortTest()
        {
            List<int> numbers = new List<int>()
            {
                1243,
                1131,
                24,
                123,
                2
            };
            var sortedNumbers = numbers.SimpleSortOptimised();
            Assert.AreEqual(numbers, sortedNumbers);
        }
    }
}
