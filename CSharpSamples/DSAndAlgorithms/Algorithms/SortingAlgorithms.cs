using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Algorithms
{
    /// <summary>
    /// Contains below soring algorithms
    /// Bubble sort, Merge Sort, Quick sort, Insertion Sort
    /// </summary>
    public static class SortingAlgorithms
    {
        public static void SimpleSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                T item1 = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    T item2 = list[j];
                    if (Compare(item1, item2) > 0)
                    {
                        int index = list.FindIndex(x => x.Equals(item1));
                        list.Swap(index,j);
                    }
                }
            }
        }

        public static void BubbleSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (Compare(list[j], list[j + 1]) > 0)
                    {
                        list.Swap(j, j+1);
                    }
                }
            }
        }

        public static void QuickSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null))
            {
                if (list.Any())
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = i; j < list.Count; j++)
                        {
                            T item2 = list[j];
                            if (Compare(item1, item2) > 0)
                            {
                                int index = list.FindIndex(x => x.Equals(item1));
                                list.Swap(index, j);
                            }
                        }
                    }
                }
            }
        }

        public static void MergeSort<T>(this List<T> list) where T : IComparable<T>
        {
            if (!ReferenceEquals(list, null))
            {

            }
        }

        public static void InsertionSort1<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list,null))
            {
                if (list.Any())
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = i; j > 0; j--)
                        {
                            T item2 = list[j];
                            if (Compare(item1, item2) > 0)
                            {
                                //list.Slide(item2, j, i);
                            }
                        }
                    }
                }
            }
        }

        public static void InsertionSort<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list, null))
            {
                if (list.Any())
                {
                    var localList = list.ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        T item1 = list[i];
                        for (int j = 0; j <= i; j++)
                        {
                            T item2 = localList[j];
                            if (Compare(item1, item2) > 0)
                            {
                                localList.Slide(item2, j, i);
                                break;
                            }
                        }
                    }
                    list = localList.ToList();
                }
            }
        }

        public static void InsertionSortBookAlgo<T>(this List<T> list) where T : struct, IComparable<T>
        {
            if (!ReferenceEquals(list,null) && list.Any())
            {
                int unSorted = 1;
                while (unSorted < list.Count)
                {
                    T hold = list[unSorted];
                    int i = unSorted - 1;
                    T item = list[i];
                    while (i >=0 && (Compare(hold, item) < 0))
                    {
                        list[i + 1] = list[i];
                        i = i - 1;
                    }
                    list[i + 1] = hold;
                    unSorted = unSorted + 1;
                }
            }
        }

        public static void Slide<T>(this List<T> list, T item, int min, int max) where T : IComparable<T>
        {
            if (min < max && (list.Count > max))
            {
                //var subList = list.GetSubList(min, max);
                //for (int i = min + 1; i <= max; i++)
                //{
                //    int j = i - min - 1;
                //    list[i] = subList[j];
                //}
                //list[min] = item;
                for (int i = min; i < max; i++)
                {
                    list[i + 1] = list[i];
                }
                list[min] = item;
            }
        }

        public static List<T> GetSubList<T>(this List<T> list, int min, int max) where T : IComparable<T>
        {
            if (ReferenceEquals(list, null))
            {
                return null;
            }
            if (list.Count == 0)
            {
                return new List<T>();
            }
            if (list.Count < max)
            {
                throw new InvalidOperationException();
            }

            List<T> subList = new List<T>();

            for (int i = min; i <= max; i++)
            {
                subList.Add(list[i]);
            }

            return subList;
        }

        # region Helper Methods
        private static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private static int Compare<T>(T item1, T item2) where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }

        private static void Swap<T>(this List<T> list, int min, int max)
        {
            if (!ReferenceEquals(list, null) && (max < list.Count))
            {
                T temp = list[min];
                list[min] = list[max];
                list[max] = temp;
            }
        }
        # endregion 
    }
}
