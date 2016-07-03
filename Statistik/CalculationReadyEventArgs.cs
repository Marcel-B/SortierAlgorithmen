using System;

namespace Statistik
{
    public class CalculationReadyEventArgs : EventArgs
    {
        public double[] Result { get; set; }
        public string Sender { get; set; }

    }
}