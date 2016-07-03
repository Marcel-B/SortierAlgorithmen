using SortierAlgorithmen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public class Spannweite : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }
        public double[] SortedData { get; private set; }

        public Spannweite() { }
        public Spannweite(double[] Data) { SetData(Data); }
        public double[] Calculate()
        {
            if (SortedData == null)
            {
                var sort = new QuickSort(Data);
                SortedData = sort.SortIt();
            }
            double[] rd = new double[1];
            rd[0] = SortedData[SortedData.Length - 1] - SortedData[0];
            ResultData = rd;
            return rd;
        }
        public void SetSortedData(double[] Data)
        {
            SortedData = Data;
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
        public override string ToString()
        {
            return "Spannweite";
        }
    }
}
