using System;

namespace Statistik
{
    public class Median : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }
        public double[] SortedData { get; private set; }

        public Median() { }
        public Median(double[] Data) { SetData(Data); }
        public void SetData(double[] Data)
        {
            this.Data = Data;
        }
        public double[] Calculate()
        {
            double[] result = new double[1];
            if (SortedData == null)
            {
                var sort = new QuickSort(Data);
                SortedData = sort.Calculate();
            }
            var len = SortedData.Length;
            if(len % 2 == 0)
            {
                len /= 2;
                result[0] = (SortedData[len] + SortedData[len - 1]);
                result[0] /= 2;
            }
            else
            {
                len /= 2;
                result[0] = SortedData[len];
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
        public void SetSortedData(double[] Data)
        {
            SortedData = Data;
        }
        public override string ToString()
        {
            return "Median";
        }
    }
}
