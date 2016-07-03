using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public class Statistik
    {
        public event EventHandler<CalculationReadyEventArgs> RunCalculationReady;
        private IStats _Stats;
        public IStats Stats
        {
            get { return _Stats; }
            set { _Stats = value; }
        }
        public Statistik() { }
        public Statistik(IStats Stats)
        {
            _Stats = Stats;
        }
        public void SetData(double[] Data)
        {
            Stats.SetData(Data);
        }
        public void SetSortedData(double[] Data)
        {
            Stats.SetSortedData(Data);
        }
        public async void RunCalculationAsync()
        {
            Console.WriteLine("Start " + Stats.ToString());
            var sender = Stats.ToString();
            var result = await Task<double[]>.Factory.StartNew(Stats.Calculate);
            OnRunCalculationReady(new CalculationReadyEventArgs() { Result = result, Sender = sender });
        }
        public double[] RunCalculation()
        {
            return Stats.Calculate();
        }
        public void OnRunCalculationReady(CalculationReadyEventArgs e)
        {
            Console.WriteLine("End " + Stats.ToString());
            RunCalculationReady?.Invoke(this, e);
        }

    }
}
