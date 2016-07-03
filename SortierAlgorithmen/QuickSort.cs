namespace SortierAlgorithmen
{
    public class QuickSort
    {
        public double[] data { get; private set; }
        public double[] sorted { get; private set; }


        public QuickSort() { }

        public QuickSort(double[] data) : this() { SetData(data); }

        public void SetData(double[] data)
        {
            this.data = data;
        }

        public double[] SortIt()
        {
            sorted = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                sorted[i] = data[i];
            }

            GoQuickSort(0, sorted.Length - 1);
            return sorted;
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
            double pivot = sorted[rechts];
            do
            {
                // Suche von links ein Element, welches größer als das Pivotelement ist
                while (sorted[i] <= pivot && i < rechts)
                    i++;
                // Suche von rechts ein Element, welches kleiner als das Pivotelement ist
                while (sorted[j] >= pivot && j > links)
                    j--;
                if (i < j)
                {
                    tmp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = tmp;
                }
            } while (i < j); // solange i an j nicht vorbeigelaufen ist 

            // Tausche Pivotelement (daten[rechts]) mit neuer endgültiger Position (daten[i])
            if (sorted[i] > pivot)
            {
                tmp = sorted[i];
                sorted[i] = sorted[rechts];
                sorted[rechts] = tmp;
            }
            // gib die Position des Pivotelements zurück
            return i;
        }
    }
}
