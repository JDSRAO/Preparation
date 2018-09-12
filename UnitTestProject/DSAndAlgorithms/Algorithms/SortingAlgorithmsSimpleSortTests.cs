using CSharpSamples.DSAndAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CSharpSamples.DSAndAlgorithms.Algorithms.Tests
{
    [TestFixture()]
    public class SortingAlgorithmsSimpleSortTests
    {
        [Test()]
        public void SimpleSortIntegerTest()
        {
            var actual = new List<int>() { 1, 3, 2, 5, 10 };
            var expected = new List<int>() { 10, 5, 3, 2, 1 };
            Assert.IsTrue(actual.SimpleSort().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortCharTest()
        {
            var actual = new List<char>() { 'b', 'a', 'c' };
            var expected = new List<char> { 'c', 'b', 'a' };
            Assert.IsTrue(actual.SimpleSort().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortOptimisedIntegerTest()
        {
            var actual = new List<int>() { 1, 3, 2, 5, 10 };
            var expected = new List<int>() {  1, 2, 3, 5, 10 };
            Assert.IsTrue(actual.SimpleSortOptimised().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortOptimisedCharTest()
        {
            var actual = new List<char>() { 'b', 'a', 'c' };
            var expected = new List<char> { 'a', 'b', 'c' };
            Assert.IsTrue(actual.SimpleSortOptimised().SequenceEqual(expected));
        }
    }
}