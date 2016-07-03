using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    interface IStats
    {
        void SetData(double[] Data);
        double[] GetData();
        double[] GetResult();
        double[] Calculate();
    }
}
