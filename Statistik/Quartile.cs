using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public class Quartile : IStats
    {
        public double[] Data { get; private set; }
        public double[] ResultData { get; private set; }
        public Quartile() { }
        public Quartile(double[] Data) { SetData(Data); }
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
            throw new NotImplementedException();
        }
    }
}
