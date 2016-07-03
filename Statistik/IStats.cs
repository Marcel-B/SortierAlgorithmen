using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public interface IStats
    {
        void SetData(double[] Data);
        void SetSortedData(double[] Data);
        double[] GetData();
        double[] GetResult();
        double[] Calculate();
        //void Calculate();
    }
}
