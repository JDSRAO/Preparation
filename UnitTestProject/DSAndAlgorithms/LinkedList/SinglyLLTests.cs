using NUnit.Framework;
using CSharpSamples.DSAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.LinkedList.Tests
{
    [Author("KJDS SRINVASA RAO")]
    [TestFixture()]
    public class SinglyLLTests
    {
        SinglyLL<int> sll1;
        SinglyLL<char> sll2;

        [SetUp]
        public void Setup()
        {
            sll1 = new SinglyLL<int>();
            sll2 = new SinglyLL<char>();
        }

        [Test()]
        public void Add_Integer_Test()
        {
            sll1.Add(1);
            sll1.Add(4);
            sll1.Add(20);
            Assert.AreEqual(3, sll1.Count);
        }

        [Test()]
        public void Delete_Integer_Test()
        {
            int expextedCount = 2;
            int valueToDelete = 20;
            int valueNotInLLToDelete = 56;
            sll1.Add(1);
            sll1.Add(4);
            sll1.Add(20);
            var positiveScenarioResult = sll1.Delete(valueToDelete);
            var negativeScenarioResult = sll1.Delete(valueNotInLLToDelete);
            Assert.AreEqual(expextedCount, sll1.Count);
            Assert.IsTrue(positiveScenarioResult);
            Assert.IsFalse(negativeScenarioResult);
            Assert.IsFalse(sll1.Contains(valueToDelete));
            Assert.IsFalse(sll1.Contains(valueNotInLLToDelete));
        }

    }
}