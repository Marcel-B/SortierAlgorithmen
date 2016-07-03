using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortierAlgorithmen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void QuickSortTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QuickSortTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortItTest()
        {
            var target = new QuickSort();
            target.SetData(new double[] { 5, 6, 9, 7, 1, 5 });
            var actual = target.SortIt();
            var expected = (new double[] { 1, 5, 5, 6, 7, 9 });


            Assert.AreEqual(expected, actual);
        }
    }
}