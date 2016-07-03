using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Statistik.Tests
{
    [TestClass()]
    public class ArithmetischesMittelTests
    {
        [TestMethod()]
        public void ArithmetischesMittelTest()
        {
            var aret = new ArithmetischesMittel();
            Assert.IsTrue(aret != null);
        }

        [TestMethod()]
        public void ArithmetischesMittelTest1()
        {
            var test = new double[] { 9, 11, 1, 6, 4, 3 };

            var aret = new ArithmetischesMittel(test);
            Assert.IsTrue(aret != null);

            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(test[i], aret.Data[i]);
            }
            Assert.AreEqual(test.Length, aret.Data.Length);
        }

        [TestMethod()]
        public void SetDataTest()
        {
            var test = new double[] { 9, 11, 1, 6, 4, 3 };

            var aret = new ArithmetischesMittel();
            Assert.IsTrue(aret != null);

            aret.SetData(test);

            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(test[i], aret.Data[i]);
            }
            Assert.AreEqual(test.Length, aret.Data.Length);
        }

        [TestMethod()]
        public void CalculateTest()
        {
            var aret = new ArithmetischesMittel();
            aret.SetData(new double[] { 2, 4, 4, 2 });
            var result = aret.Calculate();
            double expect = 3;
            Assert.AreEqual(expect, result[0]);
            Assert.AreEqual(expect, aret.ResultData[0]);
        }

        [TestMethod()]
        public void GetResultTest()
        {
            var aret = new ArithmetischesMittel();
            aret.SetData(new double[] { 2, 4, 4, 2 });
            aret.Calculate();
            var result = aret.GetResult();
            double expect = 3;
            Assert.AreEqual(expect, result[0]);
            Assert.AreEqual(expect, aret.ResultData[0]);
        }

        [TestMethod()]
        public void GetDataTest()
        {
            var aret = new ArithmetischesMittel();
            aret.SetData(new double[] { 2, 4, 4, 2 });
            var result = aret.GetData();

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], aret.Data[i]);
            }
            Assert.AreEqual(result.Length, aret.Data.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetResultTest1()
        {
            var aret = new ArithmetischesMittel();
            var result = aret.GetResult();
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetDataTest1()
        {
            var aret = new ArithmetischesMittel();
            var result = aret.GetData();
        }
    }
}