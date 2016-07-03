using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik.Tests
{
    [TestClass()]
    public class MedianTests
    {
        [TestMethod()]
        public void MedianTest()
        {
            var median = new Median();
            Assert.IsTrue(median != null);
        }

        [TestMethod()]
        public void MedianTest1()
        {
            var test = new double[] { 9, 11, 1, 6, 4, 3 };

            var median = new Median(test);
            Assert.IsTrue(median != null);

            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(test[i], median.Data[i]);
            }
            Assert.AreEqual(test.Length, median.Data.Length);

        }

        [TestMethod()]
        public void SetDataTest()
        {
            var test = new double[] { 9, 11, 1, 6, 4, 3 };

            var median = new Median();
            Assert.IsTrue(median != null);

            median.SetData(test);

            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(test[i], median.Data[i]);
            }
            Assert.AreEqual(test.Length, median.Data.Length);

        }

        [TestMethod()]
        public void CalculateTest()
        {
            var med = new Median();
            med.SetData(new double[] { 9, 11, 1, 6, 4, 3 });
            var result = med.Calculate();
            double expect = 5;
            Assert.AreEqual(expect, result[0]);
            Assert.AreEqual(expect, med.ResultData[0]);
        }

        [TestMethod()]
        public void GetDataTest()
        {
            var aret = new Median();
            aret.SetData(new double[] { 2, 4, 4, 2 });
            var result = aret.GetData();

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], aret.Data[i]);
            }
            Assert.AreEqual(result.Length, aret.Data.Length);
        }

        [TestMethod()]
        public void GetResultTest()
        {
            var aret = new Median();
            aret.SetData(new double[] { 2, 4, 4, 2 });
            aret.Calculate();
            var result = aret.GetResult();
            double expect = 3;
            Assert.AreEqual(expect, result[0]);
            Assert.AreEqual(expect, aret.ResultData[0]); 
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetDataTest1()
        {
            var aret = new Median();
            var result = aret.GetData();
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetResultTest1()
        {
            var aret = new Median();
            var result = aret.GetResult();
        }
    }
}