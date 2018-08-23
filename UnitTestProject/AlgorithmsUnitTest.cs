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
            Assert.AreEqual(2, numbers.BinaryASearch(2));
        }

        [TestMethod]
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
