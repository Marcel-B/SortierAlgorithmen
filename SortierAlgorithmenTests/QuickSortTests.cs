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
            var target = new QuickSort();
            bool rdy = target != null ? true : false;
            bool exp = true;
            Assert.AreEqual(rdy, exp);
        }

        [TestMethod()]
        public void QuickSortTest1()
        {
            var target = new QuickSort(new double[] { 2, 10, 1, 4 });
            var dat = new double[] { 2, 10, 1, 4 };
            for (int i = 0; i < dat.Length; i++)
            {
                Assert.AreEqual(dat[i], target.data[i]);
            }
            Assert.AreEqual(dat.Length, target.data.Length);
        }

        [TestMethod()]
        public void SetDataTest()
        {
            var target = new QuickSort();
            var dat = new double[] { 2, 10, 1, 4 };
            target.SetData(dat);
            for (int i = 0; i < dat.Length; i++)
            {
                Assert.AreEqual(dat[i], target.data[i]);
            }
            Assert.AreEqual(dat.Length, target.data.Length);
        }

        [TestMethod()]
        public void SortItTest()
        {
            var target = new QuickSort();
            target.SetData(new double[] { 5, 6, 9, 7, 1, 5 });
            target = new QuickSort(new double[] { 5, 6, 9, 7, 1, 5 });
            var actual = target.SortIt();
            var expected = (new double[] { 1, 5, 5, 6, 7, 9 });


            Assert.AreEqual(actual.Length, expected.Length);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}