using System;

namespace Statistik
{
    public class InterQuartilsAbstand : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }
        public double[] SortedData { get; private set; }
        public InterQuartilsAbstand() { }
        public InterQuartilsAbstand(double[] Data) { SetData(Data); }
        public void SetData(double[] Data)
        {
            this.Data = Data;
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

        public double[] Calculate()
        {
            double[] res = new double[4];
            double unteresQuartil;
            double oberesQuartil;

            if (SortedData == null)
            {
                var sort = new QuickSort(Data);
                SortedData = sort.Calculate();
            }

            int n = SortedData.Length;
            int m = 0;

            if (n % 2 == 0)
            {
                m = n / 2;
                res[2] = (SortedData[m] + SortedData[m - 1]);
                res[2] /= 2;
            }
            else
            {
                m = n / 2;
                res[2] = SortedData[m];
            }


            if (n % 4 == 0)
            {
                m = n / 4;
                unteresQuartil = SortedData[m] + SortedData[m - 1];
                unteresQuartil /= 2;
            }
            else
            {
                m = n / 4;
                unteresQuartil = SortedData[m];
            }
            n *= 3;
            if (n % 4 == 0)
            {
                m = n / 4;
                oberesQuartil = SortedData[m] + SortedData[m - 1];
                oberesQuartil /= 2;
            }
            else
            {
                m = n / 4;
                oberesQuartil = SortedData[m];
            }
            var interQuartilsAbstand = oberesQuartil - unteresQuartil;
            res[0] = interQuartilsAbstand;
            res[1] = unteresQuartil;
            res[3] = oberesQuartil;
            ResultData = res;
            return res;
        }
        public override string ToString()
        {
            return "Interquartilsabstand";
        }

        public void SetSortedData(double[] Data)
        {
            SortedData = Data;
        }
    }
}
