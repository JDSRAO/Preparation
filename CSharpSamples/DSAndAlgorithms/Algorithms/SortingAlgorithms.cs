using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Algorithms
{
    public class SortingAlgorithms
    {
        public static void BubbleSort<T>(ref List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                T item1 = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    T item2 = list[j];
                    if (Compare(item1, item2) < 0)
                    {
                        Swap(ref item1, ref item2);
                    }
                }
            }
        }

        private static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private static int Compare<T>(T item1, T item2)
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }
    }
}
