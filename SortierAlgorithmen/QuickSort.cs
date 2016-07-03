namespace SortierAlgorithmen
{
    class QuickSort
    {
        public double[] data { get; private set; }
        public QuickSort() { }
        public QuickSort(double[] data) : this() { SetData(data); }
        public void SetData(double[] data)
        {
            this.data = data;
        }
        public double[] SortIt()
        {
            GoQuickSort(0, data.Length - 1);
            return data;
        }
        public void GoQuickSort(int links, int rechts)
        {
            if (links < rechts)
            {
                int teiler = Teile(links, rechts);
                GoQuickSort(links, teiler - 1);
                GoQuickSort(teiler + 1, rechts);
            }
        }
        public int Teile(int links, int rechts)
        {
            double tmp;
            int i = links;
            // Starte mit j links vom Pivotelement
            int j = rechts - 1;
            double pivot = data[rechts];
            do
            {
                // Suche von links ein Element, welches größer als das Pivotelement ist
                while (data[i] <= pivot && i < rechts)
                    i++;
                // Suche von rechts ein Element, welches kleiner als das Pivotelement ist
                while (data[j] >= pivot && j > links)
                    j--;
                if (i < j)
                {
                    tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                }
            } while (i < j); // solange i an j nicht vorbeigelaufen ist 

            // Tausche Pivotelement (daten[rechts]) mit neuer endgültiger Position (daten[i])
            if (data[i] > pivot)
            {
                tmp = data[i];
                data[i] = data[rechts];
                data[rechts] = tmp;
            }
            // gib die Position des Pivotelements zurück
            return i;
        }
    }
}
