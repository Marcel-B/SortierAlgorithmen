using System;
using SortierAlgorithmen;

namespace Statistik
{
    public class Median : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }

        public Median() { }
        public Median(double[] Data) { SetData(Data); }
        public void SetData(double[] Data)
        {
            this.Data = Data;
        }
        public double[] Calculate()
        {
            double[] result = new double[1];
            var quick = new QuickSort(Data);
            var data = quick.SortIt();
            var len = data.Length;
            if(len % 2 == 0)
            {
                len /= 2;
                result[0] = (data[len] + data[len - 1]);
                result[0] /= 2;
            }
            else
            {
                len /= 2;
                result[0] = data[len];
            }
            ResultData = result;
            return result;
        }

        public double[] GetData()
        {
            if (Data != null)
                return Data;
            else
                throw new NullReferenceException();
        }

        public double[] GetResult()
        {
            if (ResultData != null)
                return ResultData;
            else
                throw new NullReferenceException();
        }
    }
}
