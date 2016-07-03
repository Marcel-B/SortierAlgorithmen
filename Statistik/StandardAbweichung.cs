using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public class StandardAbweichung : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }

        public StandardAbweichung() { }
        public StandardAbweichung(double[] Data) { SetData(Data); }

        public double[] Calculate()
        {
            double[] result = new double[1];
            var arith = new ArithmetischesMittel(Data);
            result = arith.Calculate();
            var mittel = result[0];
            double sum = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                sum += Math.Pow(Data[i], 2);
            }
            sum /= Data.Length;
            sum -= Math.Pow(mittel, 2);
            result[0] = Math.Sqrt(sum);
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

        public void SetData(double[] Data)
        {
            this.Data = Data;
        }

        public void SetSortedData(double[] Data)
        {
            this.Data = Data;
        }
        public override string ToString()
        {
            return "Standardabweichung";
        }
    }
}
