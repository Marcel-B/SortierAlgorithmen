using System;

namespace Statistik
{
    public class Perzentile : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }
        public double[] SortedData { get; private set; }
        public double Perzentil { get; private set; }
        public Perzentile() { Perzentil = 25; }
        public Perzentile(double[] Data) : this() { SetData(Data); }

        public double[] Calculate()
        {
            double[] res = new double[1];
            int pos, n = Data.Length;

            if (SortedData == null)
            {
                var sort = new QuickSort(Data);
                SortedData = sort.Calculate();
            }
            if ((Perzentil * (n / 100)) % 2 == 0)
            {
                pos = (int)(Perzentil * (n / 100));
                res[0] = (SortedData[pos] + SortedData[pos - 1]);
                res[0] /= 2;
            }
            else
            {
                pos = (int)(Perzentil * (n / 100));
                res[0] = SortedData[pos];
            }
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

        public void SetData(double[] Data)
        {
            this.Data = Data;
        }

        public void SetSortedData(double[] Data)
        {
            SortedData = Data;
        }
        public void SetPerzentil(double Perzentil)
        {
            this.Perzentil = Perzentil;
        }
        public override string ToString()
        {
            return "Perzentil " + Perzentil;
        }
    }
}
