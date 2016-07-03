using System;
using System.Threading;

namespace Statistik
{
    public class ArithmetischesMittel : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }

        public ArithmetischesMittel() { }
        public ArithmetischesMittel(double[] Data) { SetData(Data); }
        public void SetData(double[] Data)
        {
            this.Data = Data;
        }
        public double[] Calculate()
        {
            double[] res = new double[1];
            int n = Data.Length;
            double value = 0;
            for (int i = 0; i < n; i++)
                value += Data[i];
            res[0] = value / n;
            ResultData = res;
            return res;
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
            this.Data = Data;
        }
        public override string ToString()
        {
            return "Arithmetisches Mittel";
        }
    }
}
