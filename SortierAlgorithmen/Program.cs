using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var dok = new QuickSort();
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<double> ddd = new List<double>();
            for (int i = 0; i < 50; i++)
            {
                ddd.Add(rnd.NextDouble());
                Console.WriteLine(ddd[i]);
            }
            Console.WriteLine("=======================");
            dok.SetData(ddd.ToArray());
            dok.SetData(new double[] { 5, 6, 9, 7, 1, 5 });
            var result = dok.SortIt();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
