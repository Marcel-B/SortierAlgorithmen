using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistik
{
    public class QuickSort : IStats
    {
        public double[] Data { get; private set; }
        public double[] SortedData { get; private set; }
        public QuickSort() { }
        public QuickSort(double[] Data) : this() { SetData(Data); }
        public double[] Calculate()
        {
            SortedData = new double[Data.Length];
            for (int i = 0; i < Data.Length; i++)
            {
                SortedData[i] = Data[i];
            }

            GoQuickSort(0, SortedData.Length - 1);
            return SortedData;
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
            if (SortedData != null)
                return SortedData;
            else
                throw new NullReferenceException();
        }

        public void SetData(double[] Data)
        {
            this.Data = Data;
        }

        public void SetSortedData(double[] Data)
        {
            throw new InvalidOperationException();
        }
        private void GoQuickSort(int links, int rechts)
        {
            if (links < rechts)
            {
                int teiler = Teile(links, rechts);
                GoQuickSort(links, teiler - 1);
                GoQuickSort(teiler + 1, rechts);
            }
        }
        private int Teile(int links, int rechts)
        {
            double tmp;
            int i = links;
            // Starte mit j links vom Pivotelement
            int j = rechts - 1;
            double pivot = SortedData[rechts];
            do
            {
                // Suche von links ein Element, welches größer als das Pivotelement ist
                while (SortedData[i] <= pivot && i < rechts)
                    i++;
                // Suche von rechts ein Element, welches kleiner als das Pivotelement ist
                while (SortedData[j] >= pivot && j > links)
                    j--;
                if (i < j)
                {
                    tmp = SortedData[i];
                    SortedData[i] = SortedData[j];
                    SortedData[j] = tmp;
                }
            } while (i < j); // solange i an j nicht vorbeigelaufen ist 

            // Tausche Pivotelement (daten[rechts]) mit neuer endgültiger Position (daten[i])
            if (SortedData[i] > pivot)
            {
                tmp = SortedData[i];
                SortedData[i] = SortedData[rechts];
                SortedData[rechts] = tmp;
            }
            // gib die Position des Pivotelements zurück
            return i;
        }
        public override string ToString()
        {
            return "Quicksort";
        }
    }
}
